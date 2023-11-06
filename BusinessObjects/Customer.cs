﻿using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public string? Sex { get; set; }
        public string? Status { get; set; }
        public string? Adress { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
