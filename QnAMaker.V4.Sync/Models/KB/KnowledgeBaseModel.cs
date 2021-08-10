
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace QnAMaker.V4.Sync.Models.KB
{
    public class KnowledgeBaseModel
    {
        [JsonPropertyName("qnaDocuments")]
        public List<KbItem> QnADocuments { get; set; }
    }
}
