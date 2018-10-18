using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicPlayer.Data.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
