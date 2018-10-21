﻿using System;
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
        public string Password { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}