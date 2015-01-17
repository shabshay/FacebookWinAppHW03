using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of ConcreteCreator in Factory Method pattern.
    /// </summary>
    internal abstract class ParserFactory
    {
        /// <summary>
        /// Creats an Instance of an IFollowersParser 
        /// </summary>
        /// <param name="i_Criteria">the type t create</param>
        /// <returns></returns>
        public static FollowersParser Create(eFollowerCriteria i_Criteria)
        {
            FollowersParser parser;

            switch (i_Criteria)
            {
                case eFollowerCriteria.Albums:
                    parser = new AlbumsParser();
                    break;
                case eFollowerCriteria.Wallposts:
                    parser = new WallpostsParser();
                    break;
                case eFollowerCriteria.Status:
                    parser = new StatusParser();
                    break;
                default:
                    throw new Exception(String.Format("Cannot instansiate parser of type %s", i_Criteria));
            }

            return parser;
        }
    }
}
