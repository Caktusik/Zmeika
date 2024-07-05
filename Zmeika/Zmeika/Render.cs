using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    
    internal class Render
    {
        bool CursorVisible = false;
        public Render()
        {
            Console.WriteLine("X = *  Y =  *");
        }
        public void PrintCord(int[] Cords)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = CursorVisible;
            Console.SetCursorPosition(4, 0);
            Console.Write("   ");
            Console.SetCursorPosition(4, 0);
            Console.Write(Cords[0]);
            Console.SetCursorPosition(11, 0); 
            Console.Write("   ");
            Console.SetCursorPosition(11, 0);
            Console.Write(Cords[1]);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
