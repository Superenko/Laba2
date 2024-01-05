using Labaa2.Accounts;
using Labaa2.Base;
using Labaa2.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa2.Factories
{
    public class AccountFactory
    {
        public BaseAccount CreateAccount(string name)
        {
            return new Account(name);
        }

        public BaseAccount CreatePremiumAccount(string name)
        {
            return new PremiumAccount(name);
        }

        public BaseAccount CreatePlatinumAccount(string name)
        {
            return new PlatinumAccount(name);
        }
    }
}
