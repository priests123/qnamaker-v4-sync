using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class QuestionToAdd
    {
        public int Id { get; set; }

        public string Answer { get; set; }

        public string Source { get; set; }

        public List<string> Questions { get; set; }

        public List<QuestionMetadata> QuestionMetaData {get; set;}
    }
}