using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
