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
        public List<Vector2Int> teloZmeiki = new List<Vector2Int>();
        public enum ZmeykaVector
        {
            Left,
            Right,
            Up,
            Down
        }
        public ZmeykaVector CurrentKey = ZmeykaVector.Up;
        public bool IsGameGO = true;
        public int sms;
        public int level;
    }
}
