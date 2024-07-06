using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    internal class Input
    {

        public void ChekKeyInfo()
        {
            ConsoleKeyInfo keyInfo;
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.W:
                        if(GameData.GetInstance().CurrentKey != GameData.ZmeykaVector.Down)
                            GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Up;
                        break;
                    case ConsoleKey.S:
                        if (GameData.GetInstance().CurrentKey != GameData.ZmeykaVector.Up)
                            GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Down;
                        break;
                    case ConsoleKey.D:
                        if (GameData.GetInstance().CurrentKey != GameData.ZmeykaVector.Left)
                            GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Right;
                        break;
                    case ConsoleKey.A:
                        if (GameData.GetInstance().CurrentKey != GameData.ZmeykaVector.Right)    
                            GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Left;
                        break;
                }
            }
        }
    }
}
