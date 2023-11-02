using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Service
    {
        public Service()
        {
            OrderDetails = new HashSet<OrderDetail>();
            staff = new HashSet<staff>();
        }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; } = null!;
        public DateTime? LatestUpdate { get; set; }
        public int? AmountOfTime { get; set; }
        public double? Price { get; set; }
        public string? Status { get; set; }
        public int? AdminId { get; set; }

        public virtual Admin? Admin { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
