using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryExample.Entities
{
    public class Quest
    {
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public int AuthorId { get; set; }

        [Required]
        [StringLength(256)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(256)]
        public string Answer1Text { get; set; }

        [Required]
        [StringLength(256)]
        public string Answer2Text { get; set; }

        [Required]
        [StringLength(256)]
        public string Answer3Text { get; set; }

        [Required]
        [StringLength(256)]
        public string Answer4Text { get; set; }


        [ForeignKey("AuthorId")]
        public User Author { get; set; }

        public ICollection<QuestTag> QuestTags { get; set; }

        public ICollection<QuestPass> Passes { get; set; }
    }
}
