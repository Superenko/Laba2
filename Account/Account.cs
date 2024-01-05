using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labaa2.Base;

namespace Labaa2.Accounts
{
    public class Account : BaseAccount
    {
        public Account(string name) : base(name)
        {

        }
        public override void WinGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            CurrentRating += game.Rating;
            GamesList.Add(game);
        }
        public override void LoseGame(BaseGame game, BaseAccount opponent, DateTime date)
        {
            CurrentRating -= game.Rating;
            GamesList.Add(game);
        }
    }
}
