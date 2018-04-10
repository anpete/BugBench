using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QueryExample.Entities
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(128)]
        public string Email { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [StringLength(256)]
        public string Fullname { get; set; }


        public ICollection<UserFriend> UserFriends { get; set; }
    }
}
