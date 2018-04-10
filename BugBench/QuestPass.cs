using System;

namespace QueryExample.Entities
{
    public class QuestPass
    {
        public int Id { get; set; }

        public int QuestId { get; set; }

        public int UserId { get; set; }

        public decimal PointsScored { get; set; }

        public int? CompetitionId { get; set; }

        public DateTimeOffset? CreatedAt { get; set; }


        public Quest Quest { get; set; }
        public User User { get; set; }
        public Competition Competition { get; set; }
    }
}
