using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of ConcreteProduct in Factory method pattern.
    /// Plays the role of Facade in Facade Pattern.
    /// </summary>
    internal class StatusParser : FollowersParser
    {
        private ComponentParser<Status> m_StatusParser;
        private CommentParser<Status> m_StatusCommentsParser;

        public StatusParser()
        {
            m_StatusCommentsParser = new CommentParser<Status>();
            m_StatusParser = new ComponentParser<Status>(); ;
        }

        public override void Parse(User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            m_StatusCommentsParser.Parse(i_User.Statuses, i_User, ref i_Statistics, ref i_Followers);
            m_StatusParser.Parse(i_User.Statuses, i_User, ref i_Statistics, ref i_Followers);
        }
    }
}
