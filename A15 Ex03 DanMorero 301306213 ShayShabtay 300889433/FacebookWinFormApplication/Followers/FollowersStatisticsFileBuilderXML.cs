using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWinFormApplication.Followers
{
    class FollowersStatisticsFileBuilderXML : IFollowersStatisticsFileBuilder
    {
        public void BuildStatisticsFile(string i_Path, List<FollowerStatisticsData> i_FollowersStatisticsData)
        {
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<FollowerStatisticsData>));

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(i_Path, false))
            {
                writer.Serialize(file, i_FollowersStatisticsData);
            }
        }
    }
}
