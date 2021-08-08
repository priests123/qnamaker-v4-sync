using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class MetadataUpdate
    {
        public List<QuestionMetadata> Delete { get; set; }

        public List<QuestionMetadata> Add { get; set; }
    }
}