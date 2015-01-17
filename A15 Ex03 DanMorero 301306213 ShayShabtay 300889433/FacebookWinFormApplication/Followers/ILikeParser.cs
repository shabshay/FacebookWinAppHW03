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
    internal class LikeParser
    {
        protected void updateStatistics(User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers)
        {
            if (i_Statistics.ContainsKey(i_User.Id))
            {
                i_Statistics[i_User.Id]++;
            }
            else
            {
                i_Statistics.Add(i_User.Id, 1);
                i_Followers.Add(i_User.Id, i_User);
            }
        }
    }
}
