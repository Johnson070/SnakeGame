using System;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class confirmForm : Form
    {
        public confirmForm()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
