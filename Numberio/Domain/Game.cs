using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberio.Domain
{
    class Game
    {
        GameStage Stage;
        public Player Player { get; set; }

    }
    class Field
    {
        public Field(int witdh, int height)
        {
            Width = witdh;
            Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public List<Line> Lines { get; set; }
    }
    class Player
    {

    }
}
