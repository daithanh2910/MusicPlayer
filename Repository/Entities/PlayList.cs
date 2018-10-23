using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Entities
{
    public class PlayList : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
