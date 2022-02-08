using Newtonsoft.Json;

namespace JSONLL
{
    public partial class Chain
    {
        public Chain Next;
        public Chain Previous;
        public Chain Left;
        public Chain Right;
        public int Index;
        public int? SortedIndex;

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("prevId", NullValueHandling = NullValueHandling.Ignore)]
        public string PrevId { get; set; }

        [JsonProperty("nextId", NullValueHandling = NullValueHandling.Ignore)]
        public string NextId { get; set; }

        [JsonProperty("blob", NullValueHandling = NullValueHandling.Ignore)]
        public Blob Blob { get; set; }
    }
}
