using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
