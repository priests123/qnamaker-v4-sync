using System.Text.Json.Serialization;

namespace QnAMaker.V4.Sync.Models.KB
{
    public class MetadataItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
