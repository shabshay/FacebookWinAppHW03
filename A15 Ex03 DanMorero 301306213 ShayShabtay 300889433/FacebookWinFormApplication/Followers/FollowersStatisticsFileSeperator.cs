using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    public class FollowersStatisticsFileSeperator : IFollowersStatisticsFileDecorator
    {
        private IFollowersStatisticsFileBuilder m_FileBuilder;
        private int m_ResultsPerFile;

        public FollowersStatisticsFileSeperator(IFollowersStatisticsFileBuilder i_FileBuilder, int i_ResultsPerFile)
        {
            m_FileBuilder = i_FileBuilder;
            m_ResultsPerFile = i_ResultsPerFile;
        }

        public IFollowersStatisticsFileBuilder FileBuilder
        {
            get
            {
                return m_FileBuilder;
            }
            set
            {
                m_FileBuilder = value;
            }
        }

        public void BuildStatisticsFile(string i_Path, List<FollowerStatisticsData> i_FollowersStatisticsData)
        {
            if (m_FileBuilder != null)
            {
                if (i_FollowersStatisticsData.Count < m_ResultsPerFile)
                {
                    m_FileBuilder.BuildStatisticsFile(i_Path, i_FollowersStatisticsData);
                }
                else
                {
                    int count = 0;
                    List<FollowerStatisticsData> tempData = new List<FollowerStatisticsData>();

                    foreach (FollowerStatisticsData data in i_FollowersStatisticsData)
                    {
                        tempData.Add(data);
                        count++;

                        if (count % m_ResultsPerFile == 0)
                        {
                            m_FileBuilder.BuildStatisticsFile(i_Path + count, tempData);
                            tempData.Clear();
                        }
                    }
                }
            }
        }
    }
}
