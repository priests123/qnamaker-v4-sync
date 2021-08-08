using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class Add
    {
        public List<QuestionToAdd> QuestionsToAdd { get; set; }

        public List<string> Urls { get; set; }

        public List<QuestionFile> Files { get; set; }
    }
}