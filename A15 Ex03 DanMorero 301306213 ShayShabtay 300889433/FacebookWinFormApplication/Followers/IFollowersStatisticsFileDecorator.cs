using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    public interface IFollowersStatisticsFileDecorator : IFollowersStatisticsFileBuilder
    {
        IFollowersStatisticsFileBuilder FileBuilder { get; set; }
    }
}
