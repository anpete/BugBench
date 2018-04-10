namespace QueryExample.Entities
{
    public class QuestTag
    {
        public int QuestId { get; set; }
        public int TagId { get; set; }

        public Quest Quest { get; set; }
        public Tag Tag { get; set; }
    }
}
