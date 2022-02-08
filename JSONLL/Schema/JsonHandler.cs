using System.Collections.Generic;
using Newtonsoft.Json;

namespace JSONLL
{
    public partial class JsonHandler
    {
        [JsonProperty("isSorted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSorted { get; set; }

        [JsonProperty("chain", NullValueHandling = NullValueHandling.Ignore)]
        public List<Chain> Links { get; set; }

        public Chain Root;
    }
}
