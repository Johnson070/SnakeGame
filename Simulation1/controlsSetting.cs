using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class controlsSetting : Form
    {
        int readState;

        public controlsSetting()
        {
            InitializeComponent();

            updateData();
        }

        private void updateData()
        {
            upKey.Text = snakeGame.Properties.Settings.Default.upControl.ToString();
            downKey.Text = snakeGame.Properties.Settings.Default.downControl.ToString();
            leftKey.Text = snakeGame.Properties.Settings.Default.leftControl.ToString();
            rightKey.Text = snakeGame.Properties.Settings.Default.rightControl.ToString();
        }

        private void upKey_Click(object sender, EventArgs e)
        {
            readState = 1;
            upKey.ForeColor = Color.Red;
        }

        private void downKey_Click(object sender, EventArgs e)
        {
            readState = 2;
            downKey.ForeColor = Color.Red;
        }

        private void leftKey_Click(object sender, EventArgs e)
        {
            readState = 3;
            leftKey.ForeColor = Color.Red;
        }

        private void rightKey_Click(object sender, EventArgs e)
        {
            readState = 4;
            rightKey.ForeColor = Color.Red;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (readState)
            {
                case 1: snakeGame.Properties.Settings.Default.upControl = keyData; upKey.ForeColor = Color.Black; break;//вверх
                case 2: snakeGame.Properties.Settings.Default.downControl = keyData; downKey.ForeColor = Color.Black; break;//вверх
                case 3: snakeGame.Properties.Settings.Default.leftControl = keyData; leftKey.ForeColor = Color.Black; break;//вверх
                case 4: snakeGame.Properties.Settings.Default.rightControl = keyData; rightKey.ForeColor = Color.Black; break;//вверх
                default: return base.ProcessCmdKey(ref msg, keyData);
            }

            updateData();

            return true;
        }
    }
}
