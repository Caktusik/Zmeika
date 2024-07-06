using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    internal class Player
    {
        ConsoleRenderer renderer;
        public Player(ConsoleRenderer renderer ) 
        {
            this.renderer = renderer;
        }
        public void CalculateCord()
        { 
            switch (GameData.GetInstance().CurrentKey)
            {
                case GameData.ZmeykaVector.Left:
                    if (GameData.GetInstance().Cords[0] - 1 >= 0)
                        renderer.SetPixel(GameData.GetInstance().Cords[0], GameData.GetInstance().Cords[1], ' ', 0);
                        GameData.GetInstance().Cords[0] -=1;
                    break;
                case GameData.ZmeykaVector.Right:
                    if (GameData.GetInstance().Cords[0] + 1 < Console.LargestWindowWidth)
                        renderer.SetPixel(GameData.GetInstance().Cords[0], GameData.GetInstance().Cords[1], ' ', 0);
                        GameData.GetInstance().Cords[0] += 1;
                    break;
                case GameData.ZmeykaVector.Up:
                    if (GameData.GetInstance().Cords[1] - 1 >= 0)
                        renderer.SetPixel(GameData.GetInstance().Cords[0], GameData.GetInstance().Cords[1], ' ', 0);
                        GameData.GetInstance().Cords[1] -= 1; 
                    break;
                case GameData.ZmeykaVector.Down:
                    if (GameData.GetInstance().Cords[1] + 1 < Console.LargestWindowHeight)
                        renderer.SetPixel(GameData.GetInstance().Cords[0], GameData.GetInstance().Cords[1], ' ', 0);
                        GameData.GetInstance().Cords[1] += 1;
                    break;
            }
        }
    }
}
