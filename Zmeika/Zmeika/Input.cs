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
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Up;
                        break;
                    case ConsoleKey.S:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Down;
                        break;
                    case ConsoleKey.D:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Right;
                        break;
                    case ConsoleKey.A:
                        GameData.GetInstance().CurrentKey = GameData.ZmeykaVector.Left;
                        break;
                }
            }
        }
    }
}
