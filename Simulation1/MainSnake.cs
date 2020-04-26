using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MainSnake : Form
    {
        snake snakeClass;
        snakeLevelGame levelClass;
        string level;
        timerGame gameTimer;
        Timer timerFood { get; set; }
        Timer timerSnake { get; set; }
        int lastScore = 0;
        int direction = 2;

        public MainSnake()
        {
            InitializeComponent();    
        }

        public void timerFoodInit(int ticks)
        {
            timerFood = null;
            timerFood = new Timer();
            timerFood.Tick += new EventHandler(snakeClass.foodFactory);
            timerFood.Interval = ticks;
        }

        public void timerSnakeInit(int ticks)
        {
            timerSnake = null;
            timerSnake = new Timer();
            timerSnake.Tick += new EventHandler(timerSnakeTick);
            timerSnake.Interval = ticks;
        }

        public void timerSnakeTick(object sender, EventArgs e)
        {
            snakeClass.snakeDirection(snakeClass.direction);
            if (levelClass != null)
            {
                levelClass.checkPos(snakeClass);
                levelClass.drawLevel(snakeClass.snakeTable, snakeClass.stata);
            }
            if (!snakeClass.gameOver) snakeClass.snakeDraw();

            if (lastScore != snakeClass.stata.score)
            {
                lastScore = snakeClass.stata.score;
                if (levelClass != null)
                {
                    snakeClass.foodMap(levelClass.game);
                }
            }

            if (snakeClass.gameOver)
            {
                timerSnake.Enabled = false;
                timerFood.Enabled = false;
                timerSnake = null;
                timerFood = null;
                gameTimer.gameTime.Enabled = false;
                gameTimer = null;

                string time;
                if (levelClass != null && levelClass.game.timeLeft > 0) time = ((levelClass.game.timeLeft - snakeClass.stata.time) / 60) + " мин " + ((levelClass.game.timeLeft - snakeClass.stata.time) - ((((levelClass.game.timeLeft - snakeClass.stata.time) / 60) * 60))) + " сек";
                else time = (snakeClass.stata.time / 60) + " мин " + (snakeClass.stata.time - (((snakeClass.stata.time / 60) * 60))) + " сек";
                MessageBox.Show("Ваш счет: " + snakeClass.stata.score.ToString() + "\nВремя: " + time + "\nСъедено обычной еды: " + snakeClass.stata.foodEat + "\nСъедено большой еды: " + snakeClass.stata.foodEatMass + "\nДлина змейки: " + snakeClass.stata.length, "Конец игры!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (snakeClass.winGame)
            {
                timerSnake.Enabled = false;
                timerFood.Enabled = false;
                timerSnake = null;
                timerFood = null;
                gameTimer.gameTime.Enabled = false;
                gameTimer = null;

                string time;
                if (levelClass != null && levelClass.game.timeLeft > 0) time = ((levelClass.game.timeLeft - snakeClass.stata.time) / 60) + " мин " + ((levelClass.game.timeLeft - snakeClass.stata.time) - ((((levelClass.game.timeLeft - snakeClass.stata.time) / 60) * 60))) + " сек";
                else time = (snakeClass.stata.time / 60) + " мин " + (snakeClass.stata.time - (((snakeClass.stata.time / 60) * 60))) + " сек";

                MessageBox.Show("Ваш счет: " + snakeClass.stata.score.ToString() + "\nВремя: " + time + "\nСъедено обычной еды: " + snakeClass.stata.foodEat + "\nСъедено большой еды: " + snakeClass.stata.foodEatMass + "\nДлина змейки: " + snakeClass.stata.length, "Конец игры! Уровень пройден!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newGame(int[] numCells, int cellSize, bool barrier, int direction)
        {
            snakeClass = null;

            Random rnd = new Random();

            if (levelClass != null)
            {
                foreach (int[] startPos in levelClass.game.table)
                {
                    if (startPos[2] == 2)
                    {
                        snakeClass = new snake(numCells[0], numCells[1], cellSize, direction, Graphics.FromHwnd(tableSnakePanel.Handle), barrier, new int[] { startPos[0], startPos[1] });
                    }
                }
            }
            else snakeClass = new snake(numCells[0], numCells[1], cellSize, 2, Graphics.FromHwnd(tableSnakePanel.Handle), barrier, new int[] { 0, 0 });



            this.Width = cellSize * numCells[0] + 42;
            this.Height = cellSize * numCells[1] + 170;

            this.Left = Screen.PrimaryScreen.Bounds.Width/2 - this.Width/2;
            this.Top = Screen.PrimaryScreen.Bounds.Height/2 - this.Height/2 - 25;

            snakeClass.drawLines();

            updateData.Enabled = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int _directionPast = 0;
            int _direction = 0;

            if (snakeClass != null)
            {
                _directionPast = snakeClass.direction;
            }

            //switch (keyData)
            //{
            //    case snakeGame.Properties.Settings.Default.upControl: _direction = 1; break;//вверх
            //    case Keys.Down: _direction = 3; break;   //вниз
            //    case Keys.Right: _direction = 2; break;   //вправо
            //    case Keys.Left: _direction = 4; break;   //влево
            //    case Keys.G: snakeClass.gameOver = true; break;
            //    case Keys.B: snakeClass.barrier = !snakeClass.barrier; break;
            //    //case Keys.L: snakeClass.eatFoodTrigger += 100; break;
            //    default: return base.ProcessCmdKey(ref msg, keyData);
            //}

            if (keyData == snakeGame.Properties.Settings.Default.upControl) _direction = 1;
            else if (keyData == snakeGame.Properties.Settings.Default.downControl) _direction = 3;
            else if (keyData == snakeGame.Properties.Settings.Default.rightControl) _direction = 2;
            else if (keyData == snakeGame.Properties.Settings.Default.leftControl) _direction = 4;
            else if (keyData == Keys.G) snakeClass.gameOver = true;
            else return base.ProcessCmdKey(ref msg, keyData);

            if (Math.Abs(_direction - _directionPast) != 2)
                snakeClass.direction = _direction;

            return true;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            if (snakeClass != null)
            {
                snakeClass.resize(Graphics.FromHwnd(tableSnakePanel.Handle));
                snakeClass.drawLines();
            }
        }

        private void updateData_Tick(object sender, EventArgs e)
        {
            label1.Text = "Очки: " + snakeClass.stata.score;
            label2.Text = "Время: " + (snakeClass.stata.time / 60) + " мин " + (snakeClass.stata.time -(((snakeClass.stata.time / 60)*60))) + " сек";

            if (snakeClass.gameOver || snakeClass.winGame)
            {
                updateData.Enabled = false;
                gameButton.Enabled = true;
            }
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            Task.Delay(2000);

            if (snakeClass == null || snakeClass.gameOver)
            {
                if (levelClass != null) levelClass.game = JsonConvert.DeserializeObject<structLevelGame>(level);

                newGame(levelClass == null ? new int[] { snakeGame.Properties.Settings.Default.numCellsX, snakeGame.Properties.Settings.Default.numCellsY } : new int[] { levelClass.game.tableSize[0], levelClass.game.tableSize[1] }, levelClass == null ? snakeGame.Properties.Settings.Default.cellSize : levelClass.game.cellSize, levelClass == null ? snakeGame.Properties.Settings.Default.barrier : levelClass.game.barrier, direction);
                if (levelClass != null)
                {
                    levelClass.drawLevel(snakeClass.snakeTable, snakeClass.stata);
                    snakeClass.foodMap(levelClass.game);
                }
            }

            gameButton.Enabled = false;

            if (timerFood == null) timerFoodInit(levelClass == null ? snakeGame.Properties.Settings.Default.timeFood : levelClass.game.timeFood);
            if (timerSnake == null) timerSnakeInit(levelClass == null ? snakeGame.Properties.Settings.Default.timeSnake : levelClass.game.speedSnake);
            if (gameTimer == null)
            {
                gameTimer = new timerGame(snakeClass, (levelClass == null ? -1 : levelClass.game.timeLeft));
                gameTimer.gameTimeInit();
            }

            timerFood.Enabled = !timerFood.Enabled;
            timerSnake.Enabled = !timerSnake.Enabled;
            gameTimer.gameTime.Enabled = !gameTimer.gameTime.Enabled;
        }

        private void SettingForm_Click(object sender, EventArgs e)
        {
            Settings frm = new Settings();

            frm.ShowDialog();

            newGame(new int[] { snakeGame.Properties.Settings.Default.numCellsX, snakeGame.Properties.Settings.Default.numCellsY }, snakeGame.Properties.Settings.Default.cellSize, snakeGame.Properties.Settings.Default.barrier, direction);
        }

        private int map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            return Convert.ToInt32((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }

        private void openLeverEditor_Click(object sender, EventArgs e)
        {
            LevelGameCreator frm = new LevelGameCreator();

            frm.ShowDialog();
        }

        private void loadForm(object sender, EventArgs e)
        {
            newGame(new int[] { snakeGame.Properties.Settings.Default.numCellsX, snakeGame.Properties.Settings.Default.numCellsY }, snakeGame.Properties.Settings.Default.cellSize, snakeGame.Properties.Settings.Default.barrier, direction);
        }

        private void loadLevel_Click(object sender, EventArgs e)
        {
            levelClass = new snakeLevelGame();

            level = levelClass.loadLevel();

            if (levelClass.game != null)
            {
                foreach (int[] block in levelClass.game.table)
                {
                    if (block[2] == 2)
                    {
                        direction = block[3];
                        break;
                    }
                }

                while (levelClass.game.tableSize[0] * levelClass.game.cellSize * levelClass.game.tableSize[1] * levelClass.game.cellSize < 250000)
                {
                    levelClass.game.cellSize -= 1;
                }


                newGame(new int[] { levelClass.game.tableSize[0], levelClass.game.tableSize[1] }, levelClass.game.cellSize, levelClass.game.barrier, direction);

                levelClass.drawLevel(snakeClass.snakeTable, snakeClass.stata);
                snakeClass.foodMap(levelClass.game);
            }
        }

        private void controlSetting_Click(object sender, EventArgs e)
        {
            controlsSetting cntr = new controlsSetting();

            cntr.ShowDialog();
        }

        private void infiinityGame_Click(object sender, EventArgs e)
        {
            levelClass = null;
            newGame(new int[] { snakeGame.Properties.Settings.Default.numCellsX, snakeGame.Properties.Settings.Default.numCellsY }, snakeGame.Properties.Settings.Default.cellSize, snakeGame.Properties.Settings.Default.barrier, direction);
        }
    }
}
