using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// Plays the role of Product in Factory method pattern.
    /// </summary>
    internal abstract class FollowersParser
    {
        public abstract void Parse(User i_User, ref Dictionary<string, int> i_Statistics, ref Dictionary<string, User> i_Followers);
    }
}
