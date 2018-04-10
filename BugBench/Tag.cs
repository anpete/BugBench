using System.ComponentModel.DataAnnotations;

namespace QueryExample.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Value { get; set; }
    }
}
