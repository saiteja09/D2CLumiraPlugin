using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace D2CLumiraPlugin
{
    [DataContract]
    public class DataSourcesJSON
    {
        [DataMember(Name = "dataSources")]
        public DataSourceSet[] ResourceSets { get; set; }
    }

    [DataContract]
    public class DataSourceSet
    {
        [DataMember(Name = "name")]
        public string DataSourceName { get; set;}

        [DataMember(Name = "dataStore")]
        public int DataSourceId { get; set; }
    }
}
