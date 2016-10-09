using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AccountDataBase
{
    public class AccountDataBaseContext : DbContext
    {


        public AccountDataBaseContext() : base("name =AccountDataBaseContextConectionString")
        {

        }
    }
}