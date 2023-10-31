using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Admin
    {
        public Admin()
        {
            Services = new HashSet<Service>();
        }

        public int AdminId { get; set; }
        public string AdminName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
