using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineReservationSystem.Data
{
    public class AspNetUsers : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string CityState { get; set; }
        public int Points { get; set; } = 0;
        public string PreferredPayment { get; set; }
    }
}
