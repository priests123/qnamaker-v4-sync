using System.Collections.Generic;

namespace QnAMaker.V4.Sync.Models.KBUpdate
{
    public class Delete
    {
        public List<int> Ids { get; set; }

        public List<string> Sources { get; set; }
    }
}