using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class Update
    {
        public string Name { get; set; }

        public List<QuestionToUpdate> QuestionsToUpdate { get; set; }
    }
}