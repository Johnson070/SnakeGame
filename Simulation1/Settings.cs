using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            tableXSize.Value = snakeGame.Properties.Settings.Default.numCellsX;
            tableYSize.Value = snakeGame.Properties.Settings.Default.numCellsY;
            sizeCellTable.Value = snakeGame.Properties.Settings.Default.cellSize;
            snakeSpeed.Value = snakeGame.Properties.Settings.Default.timeSnake;
            barrierGame.Checked = snakeGame.Properties.Settings.Default.barrier;

            //MessageBox.Show((Screen.PrimaryScreen.Bounds.Height * Screen.PrimaryScreen.Bounds.Width).ToString()) ;

            updateDataText();
        }

        private void tableSnakeSize_Scroll(object sender, EventArgs e)
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

        private void updateDataText()
        {
            widthLabel.Text = "Размер поля(Ширина): " + tableXSize.Value;
            heightLabel.Text = "Размер поля(Высота): " + tableYSize.Value;
            sizeCellLabel.Text = "Размер ячейки: " + sizeCellTable.Value + "x" + sizeCellTable.Value;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            snakeGame.Properties.Settings.Default.numCellsX = tableXSize.Value;
            snakeGame.Properties.Settings.Default.numCellsY = tableYSize.Value;
            snakeGame.Properties.Settings.Default.cellSize = sizeCellTable.Value;
            snakeGame.Properties.Settings.Default.timeSnake = snakeSpeed.Value;
            snakeGame.Properties.Settings.Default.timeFood = (snakeSpeed.Value*3000)/100;
            snakeGame.Properties.Settings.Default.barrier = barrierGame.Checked;
            snakeGame.Properties.Settings.Default.Save();
        }

        private void snakeSpeed_Scroll(object sender, EventArgs e)
        {

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
    }
}
