using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public enum AccountStatus
    {
        Open, Locked, VerifyEmail, CreatePlayer
    }
    public class StatusObject
    {
        public int StatusID { get; set; }
        public AccountStatus accountStatus { get; set; }
        public string ActivationCode { get; set; }
    }
}