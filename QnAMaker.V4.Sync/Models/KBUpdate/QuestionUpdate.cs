using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class QuestionUpdate
    {
        public List<string> Add { get; set; }

        public List<string> Delete { get; set; }
    }
}