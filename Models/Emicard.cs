using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FINANCE_MANAGEMENT_SYSTEM.Models
{
    public partial class Emicard
    {
        public int EmiCardno { get; set; }
        public string Username { get; set; }
        public string CardType { get; set; }
        public decimal TotalCredit { get; set; }
        public decimal CreditUsed { get; set; }
        public string Status { get; set; }
        public DateTime ValidTill { get; set; }

        public virtual RegistrationU UsernameNavigation { get; set; }
    }
}
