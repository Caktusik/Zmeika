using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zmeika
{
    public class GameData
    {
        private static GameData _instance;
        private GameData() { }
        public static GameData GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameData();
            }
            return _instance;
        }
        public int[] Cords { get; set; } = new int[2] { 10, 10 };
        public enum ZmeykaVector
        {
            Left,
            Right,
            Up,
            Down
        }
        public ZmeykaVector CurrentKey = ZmeykaVector.Up;
    }
}
