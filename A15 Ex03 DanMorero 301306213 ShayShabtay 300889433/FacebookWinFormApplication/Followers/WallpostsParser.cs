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
    internal class WallpostsParser : FollowersParser
    {
        private ComponentParser<Post> m_wallPostsParser;
        private CommentParser<Post> m_wallPostsCommentsParser;

        public WallpostsParser()
        {
            m_wallPostsCommentsParser = new CommentParser<Post>();
            m_wallPostsParser = new ComponentParser<Post>(); ;
        }
        public override void Parse(User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            m_wallPostsCommentsParser.Parse(i_User.WallPosts, i_User, ref i_Statistics, ref i_Followers);
            m_wallPostsCommentsParser.Parse(i_User.WallPosts, i_User, ref i_Statistics, ref i_Followers);
        }
    }
}
