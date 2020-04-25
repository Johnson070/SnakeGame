using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class timerGame
    {
        public Timer gameTime { get; set; }
        public snake game;
        public int lastTime;

        public void gameTimeTick(object sender, EventArgs e)
        {
            game.stata.time = game.stata.time + (lastTime > 0 ? -1 : 1);

            if (game.stata.time == 0 && lastTime > 0) game.gameOver = true;
        }

        public void gameTimeInit()
        {
            gameTime = null;
            gameTime = new Timer();
            gameTime.Tick += new EventHandler(gameTimeTick);
            gameTime.Interval = 1000;
        }

        public timerGame(snake _game, int time)
        {
            game = _game;
            lastTime = time;

            game.stata.time = (time > 0 ? time : 0);
        }
    }
}
