using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calendar_api.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
