using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserDataBase
{
    public class UserDataBaseContext : DbContext
    {
            public UserDataBaseContext() : base("name =UserDataBaseContextConectionString")
            {

            }      
    }
}