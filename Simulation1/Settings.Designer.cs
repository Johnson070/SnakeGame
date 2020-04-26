namespace SnakeGame
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.sizeCellLabel = new System.Windows.Forms.Label();
            this.sizeCellTable = new System.Windows.Forms.TrackBar();
            this.speedSnakeLabel = new System.Windows.Forms.Label();
            this.snakeSpeed = new System.Windows.Forms.TrackBar();
            this.barrierGame = new System.Windows.Forms.CheckBox();
            this.tableXSize = new System.Windows.Forms.TrackBar();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.tableYSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeCellLabel
            // 
            this.sizeCellLabel.AutoSize = true;
            this.sizeCellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeCellLabel.Location = new System.Drawing.Point(9, 151);
            this.sizeCellLabel.Name = "sizeCellLabel";
            this.sizeCellLabel.Size = new System.Drawing.Size(126, 20);
            this.sizeCellLabel.TabIndex = 3;
            this.sizeCellLabel.Text = "Размер ячейки:";
            // 
            // sizeCellTable
            // 
            this.sizeCellTable.Location = new System.Drawing.Point(12, 174);
            this.sizeCellTable.Maximum = 50;
            this.sizeCellTable.Minimum = 10;
            this.sizeCellTable.Name = "sizeCellTable";
            this.sizeCellTable.Size = new System.Drawing.Size(218, 45);
            this.sizeCellTable.TabIndex = 2;
            this.sizeCellTable.Value = 10;
            this.sizeCellTable.Scroll += new System.EventHandler(this.sizeCellTable_Scroll);
            // 
            // speedSnakeLabel
            // 
            this.speedSnakeLabel.AutoSize = true;
            this.speedSnakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedSnakeLabel.Location = new System.Drawing.Point(9, 222);
            this.speedSnakeLabel.Name = "speedSnakeLabel";
            this.speedSnakeLabel.Size = new System.Drawing.Size(143, 20);
            this.speedSnakeLabel.TabIndex = 4;
            this.speedSnakeLabel.Text = "Скорость змейки:";
            // 
            // snakeSpeed
            // 
            this.snakeSpeed.LargeChange = 25;
            this.snakeSpeed.Location = new System.Drawing.Point(12, 245);
            this.snakeSpeed.Maximum = 250;
            this.snakeSpeed.Minimum = 50;
            this.snakeSpeed.Name = "snakeSpeed";
            this.snakeSpeed.Size = new System.Drawing.Size(218, 45);
            this.snakeSpeed.SmallChange = 10;
            this.snakeSpeed.TabIndex = 5;
            this.snakeSpeed.Value = 50;
            this.snakeSpeed.Scroll += new System.EventHandler(this.snakeSpeed_Scroll);
            // 
            // barrierGame
            // 
            this.barrierGame.AutoSize = true;
            this.barrierGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barrierGame.Location = new System.Drawing.Point(9, 296);
            this.barrierGame.Name = "barrierGame";
            this.barrierGame.Size = new System.Drawing.Size(240, 44);
            this.barrierGame.TabIndex = 6;
            this.barrierGame.Text = "Проигрыш от столкновения\r\nсо стенкой";
            this.barrierGame.UseVisualStyleBackColor = true;
            // 
            // tableXSize
            // 
            this.tableXSize.Location = new System.Drawing.Point(12, 32);
            this.tableXSize.Maximum = 100;
            this.tableXSize.Minimum = 10;
            this.tableXSize.Name = "tableXSize";
            this.tableXSize.Size = new System.Drawing.Size(218, 45);
            this.tableXSize.TabIndex = 0;
            this.tableXSize.Value = 15;
            this.tableXSize.Scroll += new System.EventHandler(this.tableSnakeSize_Scroll);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthLabel.Location = new System.Drawing.Point(9, 9);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(178, 20);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Размер поля(Ширина):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightLabel.Location = new System.Drawing.Point(9, 80);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(177, 20);
            this.heightLabel.TabIndex = 8;
            this.heightLabel.Text = "Размер поля(Высота):";
            // 
            // tableYSize
            // 
            this.tableYSize.Location = new System.Drawing.Point(12, 103);
            this.tableYSize.Maximum = 100;
            this.tableYSize.Minimum = 10;
            this.tableYSize.Name = "tableYSize";
            this.tableYSize.Size = new System.Drawing.Size(218, 45);
            this.tableYSize.TabIndex = 7;
            this.tableYSize.Value = 15;
            this.tableYSize.Scroll += new System.EventHandler(this.tableYSize_Scroll);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 381);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.tableYSize);
            this.Controls.Add(this.barrierGame);
            this.Controls.Add(this.snakeSpeed);
            this.Controls.Add(this.speedSnakeLabel);
            this.Controls.Add(this.sizeCellLabel);
            this.Controls.Add(this.sizeCellTable);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.tableXSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sizeCellLabel;
        private System.Windows.Forms.TrackBar sizeCellTable;
        private System.Windows.Forms.Label speedSnakeLabel;
        private System.Windows.Forms.TrackBar snakeSpeed;
        private System.Windows.Forms.CheckBox barrierGame;
        private System.Windows.Forms.TrackBar tableXSize;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TrackBar tableYSize;
    }
}