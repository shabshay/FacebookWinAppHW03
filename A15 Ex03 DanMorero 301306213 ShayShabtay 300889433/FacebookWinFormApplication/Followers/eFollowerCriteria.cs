using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// A criteria to update most followers.
    /// </summary>
    public enum eFollowerCriteria
    {
        /// <summary>
        /// Most followers that have been posting on user's wall.
        /// </summary>
        Wallposts,

        /// <summary>
        /// Most followers that have been commenting and liking user's statuses.
        /// </summary>
        Status,

        /// <summary>
        /// Most followers that have been commenting and liking user's albums.
        /// </summary>
        Albums,
    }
}
