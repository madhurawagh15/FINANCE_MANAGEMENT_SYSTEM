using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FINANCE_MANAGEMENT_SYSTEM.Models
{
    public partial class RegistrationU
    {
        public RegistrationU()
        {
            Emicard = new HashSet<Emicard>();
            Orders = new HashSet<Orders>();
        }

        public string Name { get; set; }
        public decimal PhoneNo { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string CardType { get; set; }
        public string BankName { get; set; }
        public decimal AccountNum { get; set; }
        public string IfscCode { get; set; }

        public virtual ICollection<Emicard> Emicard { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
