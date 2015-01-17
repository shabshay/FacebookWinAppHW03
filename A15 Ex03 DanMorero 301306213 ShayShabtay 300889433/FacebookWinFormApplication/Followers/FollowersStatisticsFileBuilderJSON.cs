using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    class FollowersStatisticsFileBuilderJSON : IFollowersStatisticsFileBuilder
    {
        public void BuildStatisticsFile(string i_Path, List<FollowerStatisticsData> i_FollowersStatisticsData)
        {
            string json = JsonConvert.SerializeObject(i_FollowersStatisticsData.ToArray(), Formatting.Indented);
            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(i_Path, false))
            {
                file.Write(json);
            }
        }
    }
}
