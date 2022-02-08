using Newtonsoft.Json;

namespace JSONLL
{
    public partial class Blob
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string Data { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public string Hash { get; set; }

        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        [JsonProperty("lastModifiedOn", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedOn { get; set; }

        [JsonProperty("lastModifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }
    }
}
