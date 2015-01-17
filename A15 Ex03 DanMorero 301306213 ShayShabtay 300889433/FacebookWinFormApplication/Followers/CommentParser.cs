using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of Subsystem class in Facade pattern
    /// </summary>
    /// <typeparam name="T">A class that inherits from PostedItem</typeparam>
    class CommentParser <T> : LikeParser where T: PostedItem 
    {
        public void Parse(FacebookObjectCollection<T> i_PostedItems, User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            if (i_PostedItems != null)
            {
                //Get posted item statistics
                foreach (PostedItem postedItem in i_PostedItems)
                {
                    if (!postedItem.From.Id.Equals(i_User.Id))
                    {
                        updateStatistics(postedItem.From, ref i_Statistics, ref i_Followers);
                    }

                    if (postedItem.Comments != null)
                    {
                        foreach (Comment comment in postedItem.Comments)
                        {
                            if (!comment.From.Id.Equals(i_User.Id))
                            {
                                updateStatistics(comment.From, ref i_Statistics, ref i_Followers);
                            }
                            if (comment.LikedBy != null)
                            {
                                //Get comment likes statistics
                                foreach (User likedUser in comment.LikedBy)
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
        }
    }
}