using Labaa2.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaa2.Base
{
    public abstract class BaseGame
    {
        public BaseAccount Player { get; }
        public BaseAccount Opponent { get; }
        public DateTime Date { get; }

        private int _rating;
        public int Rating
        {
            get
            {
                return _rating;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Rating should be positive!");
                }
                else
                {
                    _rating = value;
                }
            }
        }

        private static int s_gameID = 31200;
        public int ID { get; }

        public string Type { get; protected set; }
        protected enum GameTypes
        {
            Standard,
            Training,
            SoloRating
        }

        public BaseGame(BaseAccount player, BaseAccount opponent, DateTime date, int rating)
        {
            Player = player;
            Opponent = opponent;
            Date = date;
            Rating = rating;
            Type = GameTypes.Standard.ToString();
            ID = ++s_gameID;
        }

        public abstract void PlayGame();
    }
}
