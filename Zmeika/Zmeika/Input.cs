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
                    case ConsoleKey.UpArrow:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Down;
                        break;
                    case ConsoleKey.RightArrow:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Right;
                        break;
                    case ConsoleKey.LeftArrow:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Left;
                        break;
                }
            }
        }
    }
}
