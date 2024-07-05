using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    internal class Player
    {
        public void CalculateCord()
        {
            
            switch (GameData.GetInstance().CurrentKey)
            {
                case GameData.ZmeykaVector.Left:
                    GameData.GetInstance().Cords[0] -=1;
                    break;
                case GameData.ZmeykaVector.Right:
                    GameData.GetInstance().Cords[0] += 1;
                    break;
                case GameData.ZmeykaVector.Up:
                    GameData.GetInstance().Cords[1] -= 1;
                    break;
                case GameData.ZmeykaVector.Down:
                    GameData.GetInstance().Cords[1] += 1;
                    break;

            }
        }
    }
}
