using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public class AccountObject
    {
        public int _accountID { get; set; }
        public string _email { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _salt { get; set; }
        public string _hash { get; set; }
        public DateTime _registrationDate { get; set; }
        public int _statusRefID { get; set; }
        public StatusObject Status { get; set; }
    }
}