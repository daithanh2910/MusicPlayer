using System.Collections.Generic;

namespace Repository.Entities
{
    public class Singer : BaseEntity
    {
        public string SingerName { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}
