using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class staff
    {
        public staff()
        {
            StaffOrders = new HashSet<StaffOrder>();
        }

        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
        public int? ServiceId { get; set; }
        public string? Password { get; set; }
        public bool? Active { get; set; }

        public virtual Service? Service { get; set; }
        public virtual ICollection<StaffOrder> StaffOrders { get; set; }
    }
}
