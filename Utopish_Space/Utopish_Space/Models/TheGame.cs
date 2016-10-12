using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utopish_Space.Models
{
    public class TheGame
    {
        internal PlayerObject CreateNewPlayerObject(AccountObject acc)
        {
            return new PlayerObject();
        }
    }
}