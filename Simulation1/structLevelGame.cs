using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class structLevelGame
    {
        public int[] tableSize { get; set; } = new int[2];
        public int cellSize { get; set; }
        public int timeLeft { get; set; }
        public bool barrier { get; set; }
        public int timeFood { get; set; }
        public int speedSnake { get; set; }
        public int scoreWin { get; set; }
        public List<int[]> table { get; set; } = new List<int[]>();
    }

    //0: пустота 1:блок цвет
}
