using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FINANCE_MANAGEMENT_SYSTEM.Models
{
    public partial class Orders
    {
        public int OrderId { get; set; }
        public string Username { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }
        public decimal TotalCost { get; set; }
        public int? EmiTenure { get; set; }

        public virtual Products Product { get; set; }
        public virtual RegistrationU UsernameNavigation { get; set; }
    }
}
