using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of Builder in builder pattern.
    /// </summary>
    public abstract class FollowerProviderBuilder
    {
        /// <summary>
        /// Enables a spesific search criteria
        /// a criteria may be wallposts, albums or status.
        /// </summary>
        /// <param name="i_Criteria"></param>
        /// <returns>FollowerProviderBuilder</returns>
        public abstract FollowerProviderBuilder EnableCriteriaParser(eFollowerCriteria i_Criteria);

        /// <summary>
        /// Disables a spesific search criteria
        /// a criteria may be wallposts, albums or status.
        /// </summary>
        /// <param name="i_Criteria"></param>
        /// <returns>FollowerProviderBuilder</returns>
        public abstract FollowerProviderBuilder DisableCriteriaParser(eFollowerCriteria i_Criteria);

        /// <summary>
        /// sets the criteria for most followers
        /// a criteria may be wallposts, albums or status.
        /// </summary>
        /// <param name="i_Criteria">A list of parsers.</param>
        /// <returns>FollowerProviderBuilder</returns>
        public abstract FollowerProviderBuilder SetCriteriaParsers(List<eFollowerCriteria> i_Criterias);
    }

    /// <summary>
    /// Plays the role of Product in Builder pattern.
    /// FollowersProvider can provide one with his most followers.
    /// the most followers are retrieved upon a pre configured criteria which
    /// may be albums, statuses and/or wallposts.
    /// 
    /// Plays the role of Context in Strategy pattern.
    /// 
    /// Plays the role of Concrete Subject in Observer pattern.
    /// </summary>
    public class FollowersProvider : IProgressObservable
    {
        /// <summary>
        /// Holds all relevant crtieria parsers.
        /// </summary>
        private Dictionary<eFollowerCriteria,FollowersParser> m_CriteriaParsers;
        private IFollowersStatisticsFileBuilder m_StatisticsFileBuilder;
        private IProgressObserver m_ProgressObserver;

        // Progress state percent
        private const int k_StepStart = 20;
        private const int k_Step1 = 70;
        private const int k_Step2 = 90;
        private const int k_StepFinish = 100;

        private FollowersProvider(IFollowersStatisticsFileBuilder i_FollowerStatisticsFileBuilder, IProgressObserver i_ProgressObserver) 
        {
            m_CriteriaParsers = new Dictionary<eFollowerCriteria, FollowersParser>();
            m_StatisticsFileBuilder = i_FollowerStatisticsFileBuilder;
            m_ProgressObserver = i_ProgressObserver;
        }

        /// <summary>
        /// Notify method from Subject role in Observer pattern.
        /// </summary>
        /// <param name="i_Percent"></param>
        public void UpdateObserverProgress(int i_Percent)
        {
            m_ProgressObserver.UpdateProgress(i_Percent);
        }

        /// <summary>
        /// Property for progress bar observer.
        /// Impemented from Subject role in Observer pattern.
        /// </summary>
        public IProgressObserver ProgressObserver
        {
            get
            {
                return m_ProgressObserver;
            }
            set
            {
                m_ProgressObserver = value;
            }
        }

        /// <summary>
        /// Adds a filter criteria which then retrieves the data of that spcific criteria.
        /// </summary>
        /// <param name="i_parser"></param>
        /// <param name="i_followersParser"></param>
        internal void AddCriteriaParser(eFollowerCriteria i_Parser, FollowersParser i_FollowersParser)
        {
            if (!m_CriteriaParsers.ContainsKey(i_Parser))
            {
                m_CriteriaParsers.Add(i_Parser, i_FollowersParser);
            }
        }

        /// <summary>
        /// Calculating statistics of user's follower facebook friends.
        /// </summary>
        /// <param name="i_User">The user you want to caculate his followers.</param>
        /// <returns>Sorted list of the user's facebook friends from the most follower friend.</returns>
        public SortedList<int, User> GetFollowersSortedList(User i_User)
        {
            UpdateObserverProgress(k_StepStart);

            SortedList<int, User> sortedListRetVal = new SortedList<int, User>();
            Dictionary<string, int> statistics;
            Dictionary<string, User> followers;
            List<FollowerStatisticsData> followersStatisticsData = new List<FollowerStatisticsData>(); 

            FetchFollowers(i_User, out statistics, out followers);

            UpdateObserverProgress(k_Step1);

            for (int i = 0; i < followers.Count; i++)
            {
                int count;
                string followerId = getMaxFollowerId(statistics, out count);
                
                if (!string.IsNullOrEmpty(followerId))
                {
                    User follower = followers[followerId];

                    FollowerStatisticsData statisticsData = new FollowerStatisticsData()
                    {
                        Index = i,
                        FollowerName = follower.Name,
                        FollowerId = follower.Id,
                        StatisticsCount = count
                    };
                    followersStatisticsData.Add(statisticsData);

                    sortedListRetVal.Add(i, follower);
                    followers.Remove(followerId);
                    statistics.Remove(followerId);
                }
            }

            UpdateObserverProgress(k_Step2);

            // Strategy executing
            if (m_StatisticsFileBuilder != null)
            {
                m_StatisticsFileBuilder.BuildStatisticsFile(@"Statistics.txt", followersStatisticsData);
            }
            UpdateObserverProgress(k_StepFinish);

            return sortedListRetVal;
        }

        /// <summary>
        /// Starts the process of retrieving the most followers
        /// </summary>
        /// <param name="i_User">the context user. the user upon most followers are searched for.</param>
        /// <param name="i_Statistics"></param>
        /// <param name="i_Followers"></param>
        private void FetchFollowers(User i_User,
            out Dictionary<string, int> i_Statistics, out Dictionary<string, User> i_Followers)
        {
            i_Statistics = new Dictionary<string, int>();
            i_Followers = new Dictionary<string, User>();

            if (i_User != null)
            {
                foreach (KeyValuePair<eFollowerCriteria, FollowersParser> entry in m_CriteriaParsers)
                {
                    FollowersParser parser = entry.Value;
                    parser.Parse(i_User, ref i_Statistics, ref i_Followers);
                }
            }
        }

        private string getMaxFollowerId(Dictionary<string, int> i_Statistics, out int o_Count)
        {
            string retVal = null;
            int maxVal = 0;

            foreach (string followerId in i_Statistics.Keys)
            {
                if (i_Statistics[followerId] > maxVal)
                {
                    maxVal = i_Statistics[followerId];
                    retVal = followerId;
                }
            }

            o_Count = maxVal;
            return retVal;
        }

        /// <summary>
        /// Plays the role of ConcreteBuilder in Builder pattern.
        /// </summary>
        public class Builder : FollowerProviderBuilder
        {
            private List<eFollowerCriteria> m_FollowingCriterias;
            private IFollowersStatisticsFileBuilder m_StatisticsFileBuilder;
 
            public Builder()
            {
                m_FollowingCriterias = new List<eFollowerCriteria>();
            }

            public void SetStatisticsFileBuilder(IFollowersStatisticsFileBuilder i_FollowersStatisticsCapture)
            {
                m_StatisticsFileBuilder = i_FollowersStatisticsCapture;
            }

            public override FollowerProviderBuilder EnableCriteriaParser(eFollowerCriteria i_type)
            {
                // only add if not already added.
                if (!m_FollowingCriterias.Contains(i_type))
                {
                    m_FollowingCriterias.Add(i_type);
                }
                return this;
            }

            public override FollowerProviderBuilder DisableCriteriaParser(eFollowerCriteria i_type)
            {
                m_FollowingCriterias.Remove(i_type);
                return this;
            }

            public override FollowerProviderBuilder SetCriteriaParsers(List<eFollowerCriteria> i_Criterias)
            {
                foreach(eFollowerCriteria criteria in i_Criterias)
                {
                    EnableCriteriaParser(criteria);
                }
                return this;
            }

            /// <summary>
            /// Creates a new instance of FollowersProvider configured with the appropiate criterias.
            /// </summary>
            /// <returns></returns>
            public FollowersProvider Build(IProgressObserver i_ProgressObserver)
            {
                FollowersProvider followersProvider = null;
                if (m_FollowingCriterias.Count == 0)
                {
                    throw new Exception("criteria should not be empty");
                }
                
                followersProvider = new FollowersProvider(m_StatisticsFileBuilder, i_ProgressObserver);
                foreach (eFollowerCriteria criteria in m_FollowingCriterias)
                {
                    FollowersParser parser = ParserFactory.Create(criteria);

                    followersProvider.AddCriteriaParser(criteria, parser);
                }
                
                return followersProvider;
            }
        }
    }
}
