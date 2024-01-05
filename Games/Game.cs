using Labaa2.Base;
using Labaa2.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Labaa2.Games
{
    public class Game : BaseGame
    {
        public Game(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        : base(player, opponent, date, rating)
        {

        }
        public override void PlayGame()
        {
            Player.WinGame(this, Opponent, Date);
            Opponent.LoseGame(this, Player, Date);
        }
    }
}
