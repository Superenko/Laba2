using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labaa2.Accounts;
using Labaa2.Base;
using Labaa2.Games;

namespace Labaa2.Factories
{
    public class GameFactory
    {
        public BaseGame CreateGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        {
            return new Game(player, opponent, date, rating);
        }
        public BaseGame CreateTrainingGame(BaseAccount player, BaseAccount opponent, DateTime date)
        {
            return new TrainingGame(player, opponent, date);
        }

        public BaseGame CreateBoostGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        {
            return new BoostGame(player, opponent, date, rating);
        }
    }
}
