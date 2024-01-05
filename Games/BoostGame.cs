using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labaa2.Base;
using Labaa2.Accounts;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Numerics;

namespace Labaa2.Games
{
    public class BoostGame : BaseGame
    {
        public BoostGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
            : base(player, opponent, date, rating)
        {
            Rating = rating * 3;
            Type = GameTypes.SoloRating.ToString();
        }
        public override void PlayGame()
        {
            Player.WinGame(this, Opponent, Date);
            Opponent.LoseGame(this, Player, Date);
        }
    }
}
