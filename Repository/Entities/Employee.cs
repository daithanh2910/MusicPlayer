using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Entities
{
    public class Employee 
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
