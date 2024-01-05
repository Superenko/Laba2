
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
    public class TrainingGame : BaseGame
    {
        public TrainingGame(BaseAccount player, BaseAccount opponent, DateTime date)
            : base(player, opponent, date, 0)
        {
            Type = GameTypes.Training.ToString();
        }
        public override void PlayGame()
        {
            Player.WinGame(this, Opponent, Date);
            Opponent.LoseGame(this, Player, Date);
        }
    }
}
