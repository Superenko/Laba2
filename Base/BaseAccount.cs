using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Labaa2.Base;

namespace Labaa2.Accounts
{
    public abstract class BaseAccount
    {
        public int StartRating = 10;
        public string UserName { get; set; }

        private int _currentRating;
        public int CurrentRating
        {
            get
            {
                return _currentRating;
            }
            protected set
            {
                if (value < 1)
                {
                    _currentRating = 1;
                }
                else
                {
                    _currentRating = value;
                }
            }
        }

        protected List<BaseGame> GamesList = new List<BaseGame>();

        public BaseAccount(string name)
        {
            UserName = name;
            CurrentRating = StartRating;

        }

        public abstract void WinGame(BaseGame game, BaseAccount opponent, DateTime date);
        public abstract void LoseGame(BaseGame game, BaseAccount opponent, DateTime date);
        public string GetStats()
        {
            var statistics = new StringBuilder();

            statistics.AppendLine($"{UserName}'s Stats:\n");
            statistics.AppendFormat("{0,-15} {1,-10} {2,-10} {3, -15} {4, -10} {5, -10}\n", "Date", "Winner", "Looser", "Game Type", "Rating", "Game ID");

            foreach (var item in GamesList)
            {
                statistics.AppendFormat("{0,-15} {1,-10} {2,-10} {3, -15} {4, -10} {5, -10}\n", $"{item.Date.ToShortDateString()}", $"{item.Player.UserName}", $"{item.Opponent.UserName}", $"{item.Type}", $"{item.Rating}", $"{item.ID}");
            }

            statistics.AppendLine($"Total Games Played: {GamesList.Count}");
            statistics.AppendLine($"{UserName}'s Rating: {CurrentRating.ToString()}");

            return statistics.ToString();
        }
    }
}
