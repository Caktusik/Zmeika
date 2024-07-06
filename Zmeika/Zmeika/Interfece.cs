using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    internal class Interfece
    {
        public void Draw()
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Длина змейки: "+GameData.GetInstance().teloZmeiki.Count );
            Console.Write("  |  Еще яблок до победы " + ((GameData.GetInstance().level * 2) + 3 - GameData.GetInstance().teloZmeiki.Count));
            Console.Write("  |  Уровень: " + GameData.GetInstance().level);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
