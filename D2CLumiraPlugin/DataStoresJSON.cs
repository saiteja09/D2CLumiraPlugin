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
    public class DataStoresJSON
    {
        [DataMember(Name = "dataStores")]
        public DataStoreSet[] ResourceSets { get; set; }
    }

    [DataContract]
    public class DataStoreSet
    {
        [DataMember(Name = "name")]
        public string DataStoreName { get; set;}

        [DataMember(Name = "id")]
        public int DataStoreId { get; set; }
    }
}
