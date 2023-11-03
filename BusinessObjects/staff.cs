using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BusinessObjects
{
    public partial class staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; } = null!;
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
        [Browsable(false)]
        public int? ServiceId { get; set; }
        [Browsable(false)]

        public string? Password { get; set; }
        [Browsable(false)]

        public virtual Service? Service { get; set; }
    }
}
