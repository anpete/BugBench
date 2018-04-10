using System.ComponentModel.DataAnnotations.Schema;

namespace QueryExample.Entities
{
    public class UserFriend
    {
        public int UserId { get; set; }

        public int FriendId { get; set; }


        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("FriendId")]
        public User Friend { get; set; }
    }
}
