using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    /// <summary>
    /// The strategy role from Strategy pattern.
    /// </summary>
    public interface IFollowersStatisticsFileBuilder
    {
        void BuildStatisticsFile(string i_Path, List<FollowerStatisticsData> i_FollowersStatisticsData);
    }
}
