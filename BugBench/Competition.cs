using System.Collections.Generic;

namespace QueryExample.Entities
{
    public class Competition
    {
        public int Id { get; set; }

        public int QuestId { get; set; }

        public int LikeCount { get; set; }

        public int DislikeCount { get; set; }


        public Quest Quest { get; set; }
        public ICollection<QuestPass> Passes { get; set; }
    }
}
