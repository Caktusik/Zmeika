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
        private bool bol = true;
        Apple apple;
        public Player(ConsoleRenderer renderer ) 
        {
            this.renderer = renderer;
            apple = new Apple(renderer);
            GameData.GetInstance().teloZmeiki.Add(new Vector2Int(10, 10));
            GameData.GetInstance().teloZmeiki.Add(new Vector2Int(11, 10));
            GameData.GetInstance().teloZmeiki.Add(new Vector2Int(12, 10));
        }
        
        public void CalculateCord()
        {
            switch (GameData.GetInstance().CurrentKey)
            {
                case GameData.ZmeykaVector.Left:
                    OneHod(-1,0);

                    break;
                    

                case GameData.ZmeykaVector.Right:
                    OneHod(1, 0);

                    break;


                case GameData.ZmeykaVector.Up:
                    OneHod(0, -1);
                    break;


                case GameData.ZmeykaVector.Down:
                    OneHod(0, 1);
                    break;
            }
            if (bol)
            {
                renderer.SetPixel(GameData.GetInstance().teloZmeiki[GameData.GetInstance().teloZmeiki.Count - 1].X, GameData.GetInstance().teloZmeiki[GameData.GetInstance().teloZmeiki.Count - 1].Y, ' ', 0);
                GameData.GetInstance().teloZmeiki.RemoveAt(GameData.GetInstance().teloZmeiki.Count - 1);
            }
            else bol = true;
            
        }
        private void OneHod(int x,int y)
        {
            if (GameData.GetInstance().teloZmeiki[0].X + x >= 0)
                GameData.GetInstance().teloZmeiki.Insert(0, new Vector2Int(GameData.GetInstance().teloZmeiki[0].X + x, GameData.GetInstance().teloZmeiki[0].Y + y));
            if ((renderer[GameData.GetInstance().teloZmeiki[0].X, GameData.GetInstance().teloZmeiki[0].Y] == '@'))
            {
                apple.SummonApple(apple.RandomPosishonIN().X, apple.RandomPosishonIN().Y);
                bol = false;
            }
            if ((renderer[GameData.GetInstance().teloZmeiki[0].X, GameData.GetInstance().teloZmeiki[0].Y] == '#'|| renderer[GameData.GetInstance().teloZmeiki[0].X, GameData.GetInstance().teloZmeiki[0].Y] == '■'))
            {
                GameData.GetInstance().IsGameGO = false;
                GameData.GetInstance().sms = 0;
            }
        }
    }
    
}
