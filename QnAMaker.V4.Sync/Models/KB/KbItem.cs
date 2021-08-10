using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QnAMaker.V4.Sync.Models.KB
{
    public class KbItem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("questions")]
        public List<string> Questions { get; set; }

        [JsonPropertyName("metadata")]
        public List<MetadataItem> Metadata { get; set; }
    }
}
