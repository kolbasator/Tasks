using System;
using System.Collections.Generic;
using System.Text;

namespace Доска_для_крестиков_ноликов

{
    class Player
    {
        public string Name;
        public int Games;
        public int Wins;
        public Player(string name,int games,int wins)
        {
            this.Name = name;
            this.Games = games;
            this.Wins = wins;
        }

    }
}
