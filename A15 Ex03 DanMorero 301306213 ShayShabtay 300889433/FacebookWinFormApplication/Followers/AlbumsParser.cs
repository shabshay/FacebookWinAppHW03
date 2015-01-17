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
    internal class AlbumsParser : FollowersParser  
    {
        private ComponentParser<Album> m_AlbumsParser;
        private CommentParser<Album> m_AlbumsCommentsParser;

        public AlbumsParser()
        {
            m_AlbumsCommentsParser = new CommentParser<Album>();
            m_AlbumsParser = new ComponentParser<Album>();
        }

        public override void Parse(User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            m_AlbumsParser.Parse(i_User.Albums, i_User, ref i_Statistics, ref i_Followers);
            m_AlbumsCommentsParser.Parse(i_User.Albums, i_User, ref i_Statistics, ref i_Followers);
        }
    }
}
