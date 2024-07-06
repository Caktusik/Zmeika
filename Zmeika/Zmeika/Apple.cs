using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    internal class Apple
    {
        Random random = new Random();
        ConsoleRenderer renderer = new ConsoleRenderer(new ConsoleColor[2] { ConsoleColor.Red, ConsoleColor.Yellow });
        public Apple(ConsoleRenderer renderer) 
        {
            this.renderer = renderer;
        }
        public Vector2Int RandomPosishonIN ()
        {
            return(new Vector2Int(random.Next(4, 109), random.Next(4, 27)));
        }
        public void SummonApple(int X, int Y)
        {
            renderer.SetPixel(X, Y,'@',1);
        }

    }
}
