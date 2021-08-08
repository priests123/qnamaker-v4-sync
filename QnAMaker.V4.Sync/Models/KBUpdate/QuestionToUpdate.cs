using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class QuestionToUpdate
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public string Source { get; set; }

        public QuestionUpdate QuestionUpdate { get; set; }

        public MetadataUpdate MetadataUpdate { get; set; }

        public List<string> Urls { get; set; }
    }
}