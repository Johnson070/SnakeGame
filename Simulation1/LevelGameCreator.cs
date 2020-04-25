using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class LevelGameCreator : Form
    {
        Graphics snakeTable;
        private int menuSelectBlock = 0;

        List<int[]> blocks = new List<int[]>();

        public LevelGameCreator()
        {
            InitializeComponent();

            snakeTable = Graphics.FromHwnd(table.Handle);

            updateDataText();
        }

        private void clearTable()
        {
            snakeTable.Clear(Color.LightGray);

            for (int i = 0; i < tableXSize.Value; i++)
            {
                for (int j = 0; j < tableYSize.Value; j++)
                {
                    snakeTable.FillRectangle(Brushes.White, 1 + i * sizeCellTable.Value, 1 + j * sizeCellTable.Value, sizeCellTable.Value - 1, sizeCellTable.Value - 1);
                }
            }

            if (barrierGame.Checked)
            {
                snakeTable.DrawLine(new Pen(Color.Black), 0, 0, 0, tableYSize.Value * sizeCellTable.Value);
                snakeTable.DrawLine(new Pen(Color.Black), 0, 0, tableXSize.Value * sizeCellTable.Value, 0);
                snakeTable.DrawLine(new Pen(Color.Black), tableXSize.Value * sizeCellTable.Value, tableYSize.Value * sizeCellTable.Value, 0, tableYSize.Value * sizeCellTable.Value);
                snakeTable.DrawLine(new Pen(Color.Black), tableXSize.Value * sizeCellTable.Value, tableYSize.Value * sizeCellTable.Value, tableXSize.Value * sizeCellTable.Value, 0);
            }

            foreach (int[] block in blocks)
            {
                Brush br = Brushes.White;

                switch (block[2])
                {
                    case 0: br = Brushes.Black; break;
                    case 1: br = Brushes.Red; break;
                    case 2: br = Brushes.Blue; break;
                    case 3: br = Brushes.LightGreen; break;
                    default: br = Brushes.White; break;
                }

                snakeTable.FillRectangle(br, 1 + block[0] * sizeCellTable.Value, 1 + block[1] * sizeCellTable.Value, sizeCellTable.Value - 1, sizeCellTable.Value - 1);
            }
        }

        private void LevelGameCreator_Resize(object sender, EventArgs e)
        {
            snakeTable = Graphics.FromHwnd(table.Handle);

            clearTable();
        }

        private void updateDataText()
        {
            label1.Text = "Размер поля(Ширина): " + tableXSize.Value;
            label4.Text = "Размер поля(Высота): " + tableYSize.Value;
            label2.Text = "Размер ячейки: " + sizeCellTable.Value + "x" + sizeCellTable.Value;
        }

        private int map(long x, long in_min, long in_max, long out_min, long out_max)
        {
            int buffer =  Convert.ToInt32((x - in_min) * (out_max - out_min) / (in_max - in_min) + out_min);

            if (buffer >= tableXSize.Value || buffer >= tableYSize.Value)
            {
                return -1;
            }
            else if (buffer < 0)
            {
                return -1;
            }
            else return buffer;
        }

        private void fillBlock(int[] cell)
        {
            Brush br = Brushes.White;

            switch (menuSelectBlock)
            {
                case 0: br = Brushes.Black; break;
                case 1: br = Brushes.Red; break;
                case 2: br = Brushes.Blue; break;
                case 3: br = Brushes.LightGreen; break;
                default: br = Brushes.White; break;
            }

            for (int i = 0; i < blocks.Count; i++)
            {
                if (blocks[i][0] == cell[0] && blocks[i][1] == cell[1])
                {
                    blocks.RemoveAt(i);
                    break;
                }
            }

            if (menuSelectBlock != -1)
            {
                if (menuSelectBlock == 1)
                {
                    unlockDoor scoreDoor = new unlockDoor();

                    scoreDoor.ShowDialog();

                    int score = Convert.ToInt32(scoreDoor.scoreUnlock.Value);

                    if (score != 0) blocks.Add(new int[] { cell[0], cell[1], menuSelectBlock, score }); else br = Brushes.White;
                }
                else blocks.Add(new int[] { cell[0], cell[1], menuSelectBlock });
            }

            snakeTable.FillRectangle(br, 1 + cell[0] * sizeCellTable.Value, 1 + cell[1] * sizeCellTable.Value, sizeCellTable.Value - 1, sizeCellTable.Value - 1);
        }

        private void table_Click(object sender, EventArgs e)
        {
            Point point = table.PointToClient(Cursor.Position);

            int[] cell = new int[] { map(point.X, 0, tableXSize.Value * sizeCellTable.Value, 0, tableXSize.Value), map(point.Y, 0, tableYSize.Value * sizeCellTable.Value, 0, tableYSize.Value) };

            if (cell[0] != -1 && cell[1] != -1) fillBlock(cell);
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {
            clearTable();
        }

        private void tableXSize_Scroll(object sender, EventArgs e)
        {
            while (tableXSize.Value * sizeCellTable.Value >= Screen.PrimaryScreen.Bounds.Width - 40)
            {
                tableXSize.Value -= 1;
            }

            while (tableXSize.Value * sizeCellTable.Value * tableYSize.Value * sizeCellTable.Value < 250000)
            {
                sizeCellTable.Value += 1;
            }

            updateDataText();
        }

        private void tableYSize_Scroll(object sender, EventArgs e)
        {
            while (tableYSize.Value * sizeCellTable.Value >= Screen.PrimaryScreen.Bounds.Height - 225)
            {
                tableYSize.Value -= 1;
            }

            while (tableXSize.Value * sizeCellTable.Value * tableYSize.Value * sizeCellTable.Value < 250000)
            {
                sizeCellTable.Value += 1;
            }

            updateDataText();
        }

        private void sizeCellTable_Scroll(object sender, EventArgs e)
        {
            while (tableYSize.Value * sizeCellTable.Value >= Screen.PrimaryScreen.Bounds.Height - 225)
            {
                tableYSize.Value -= 1;
            }

            while (tableXSize.Value * sizeCellTable.Value >= Screen.PrimaryScreen.Bounds.Width - 40)
            {
                tableXSize.Value -= 1;
            }

            while (tableXSize.Value * sizeCellTable.Value * tableYSize.Value * sizeCellTable.Value < 250000)
            {
                sizeCellTable.Value += 1;
            }

            updateDataText();
        }

        private void tabLevel_Selected(object sender, TabControlEventArgs e)
        {
            if (tabLevel.SelectedIndex == 0)
            {
                int Width = sizeCellTable.Value * tableXSize.Value + 31;
                int Height = sizeCellTable.Value * tableYSize.Value + 72;

                this.MinimumSize = new Size(Width, Height);
                this.MaximumSize = new Size(Width, Height);
            }
            else if (tabLevel.SelectedIndex == 1)
            {
                this.MinimumSize = new Size(520, 480);
                this.MaximumSize = new Size(520, 480);
            }
        }

        private void LevelGameCreator_Shown(object sender, EventArgs e)
        {
            tabLevel_Selected(null, null);
        }

        private void selectBlock(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Стереть": menuSelectBlock = -1; break;
                case "Блок-стены": menuSelectBlock = 0; break;
                case "Блок-двери": menuSelectBlock = 1; break;
                case "Место спавна": menuSelectBlock = 2; break;
                case "Блок-завершение уровня": menuSelectBlock = 3; break;
            }
        }

        private void testJson(object sender, EventArgs e)
        {
            structLevelGame level = new structLevelGame();

            level.barrier = barrierGame.Checked;
            level.speedSnake = snakeSpeed.Value;
            level.cellSize = sizeCellTable.Value;
            level.tableSize = new int[] { tableXSize.Value, tableYSize.Value };
            level.timeFood = Convert.ToInt32(foodGenTime.Value);
            level.timeLeft = Convert.ToInt32(timeLevel.Value);
            level.scoreWin = Convert.ToInt32(scoreWin.Value);

            level.table = blocks;


            MessageBox.Show(JsonConvert.SerializeObject(level));

            Clipboard.SetText(JsonConvert.SerializeObject(level));
        }

        private void table_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point point = table.PointToClient(Cursor.Position);

                int[] cell = new int[] { map(point.X, 0, tableXSize.Value * sizeCellTable.Value, 0, tableXSize.Value), map(point.Y, 0, tableYSize.Value * sizeCellTable.Value, 0, tableYSize.Value) };

                if (cell[0] != -1 && cell[1] != -1) fillBlock(cell);
            }
        }

        private void testFood(object sender, EventArgs e)
        {
            int[,] tableFill = new int[tableXSize.Value, tableYSize.Value];

            foreach (int[] block in blocks) 
            {
                if (block[2] == 0 || block[2] == 1)
                {
                    tableFill[block[0], block[1]] = 1;
                }
            }

            List<int[]> foodPos = new List<int[]>();

            foreach (int[] point in blocks)
            {
                if (point[2] == 2)
                {
                    foodPos.Add(new int[] { point[0], point[1] });
                    break;
                }
            }

            for (int i = 0; i < foodPos.Count; i++)
            {
                int[] point = foodPos[i];

                if (point[0] - 1 >= 0 && tableFill[point[0] - 1,point[1]] == 0)
                {
                    foodPos.Add(new int[] { point[0] - 1, point[1] });
                    tableFill[point[0] - 1, point[1]] = 2;
                }
                if (point[0] + 1 < tableXSize.Value && tableFill[point[0] + 1, point[1]] == 0)
                {
                    foodPos.Add(new int[] { point[0] + 1, point[1] });
                    tableFill[point[0] + 1, point[1]] = 2;
                }
                if (point[1] - 1 >= 0 && tableFill[point[0], point[1] - 1] == 0)
                {
                    foodPos.Add(new int[] { point[0], point[1]-1 });
                    tableFill[point[0], point[1] - 1] = 2;
                }
                if (point[1] + 1 < tableYSize.Value && tableFill[point[0], point[1] + 1] == 0)
                {
                    foodPos.Add(new int[] { point[0], point[1]+1 });
                    tableFill[point[0], point[1] + 1] = 2;
                }
            }

            foreach (int[] point in foodPos)
            {
                snakeTable.FillRectangle(Brushes.Red, 1 + point[0] * sizeCellTable.Value, 1 + point[1] * sizeCellTable.Value, sizeCellTable.Value - 1, sizeCellTable.Value - 1);
            }
        }

        private void testLoadLevel(object sender, EventArgs e)
        {
            snakeLevelGame level = new snakeLevelGame();

            level.loadLevel();
        }

        private void saveLevel(object sender, EventArgs e)
        {
            int[] sysBlocks = new int[2] { 0, 0};

            foreach (int[] point in blocks)
            {
                if (point[2] == 2) sysBlocks[0] += 1;
                if (point[2] == 3) sysBlocks[1] += 1;
            }

            if (sysBlocks[0] == 1 && sysBlocks[1] == 1)
            {
                structLevelGame level = new structLevelGame();

                level.barrier = barrierGame.Checked;
                level.speedSnake = snakeSpeed.Value;
                level.cellSize = sizeCellTable.Value;
                level.tableSize = new int[] { tableXSize.Value, tableYSize.Value };
                level.timeFood = Convert.ToInt32(foodGenTime.Value);
                level.timeLeft = Convert.ToInt32(timeLevel.Value);
                level.scoreWin = Convert.ToInt32(scoreWin.Value);

                level.table = blocks;

                snakeLevelGame levelGame = new snakeLevelGame();

                levelGame.saveLevel(JsonConvert.SerializeObject(level));
            }
            else MessageBox.Show("Проверьте кол-во блоков спавна или завершения уровня", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
