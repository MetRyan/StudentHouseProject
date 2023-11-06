using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.ResponseModel
{
    public class StaffOrderModel
    {
        public int StaffId { get; set; }
        public int OrderId { get; set; }
        public DateTime? WorkDate { get; set; }
        public string? Status { get; set; }

        public string? Description { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public StaffOrderModel(int staffId, int orderId, DateTime? workDate, string? status, string? description,ICollection<OrderDetail> orderDetails)
        {
            StaffId = staffId;
            OrderId = orderId;
            WorkDate = workDate;
            Status = status;
            Description = description;
            OrderDetails = orderDetails;
        }
    }
}
