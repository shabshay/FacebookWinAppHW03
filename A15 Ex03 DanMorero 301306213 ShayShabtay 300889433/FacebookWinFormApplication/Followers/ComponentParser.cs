using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of Subsystem class in Facade pattern
    /// </summary>
    /// <typeparam name="T">A class that inherits from PostedItem</typeparam>
    internal class ComponentParser<T> : LikeParser where T: PostedItem 
    {
        public void Parse(FacebookObjectCollection<T> i_PostedItems, User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            foreach (PostedItem postedItem in i_PostedItems)
            {
                //Get status likes statistics
                if (postedItem.LikedBy != null)
                {
                    //Get post likes statistics
                    foreach (User likedUser in postedItem.LikedBy)
                    {
                        if (!likedUser.Id.Equals(i_User.Id))
                        {
                            updateStatistics(likedUser, ref i_Statistics, ref i_Followers);
                        }
                    }
                }
            }
        }
    }
}
