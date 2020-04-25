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
            this.label2 = new System.Windows.Forms.Label();
            this.sizeCellTable = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.snakeSpeed = new System.Windows.Forms.TrackBar();
            this.barrierGame = new System.Windows.Forms.CheckBox();
            this.tableXSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableYSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Размер ячейки:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Скорость змейки:";
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
            this.tableXSize.Maximum = 50;
            this.tableXSize.Minimum = 10;
            this.tableXSize.Name = "tableXSize";
            this.tableXSize.Size = new System.Drawing.Size(218, 45);
            this.tableXSize.TabIndex = 0;
            this.tableXSize.Value = 15;
            this.tableXSize.Scroll += new System.EventHandler(this.tableSnakeSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер поля(Ширина):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(9, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер поля(Высота):";
            // 
            // tableYSize
            // 
            this.tableYSize.Location = new System.Drawing.Point(12, 103);
            this.tableYSize.Maximum = 50;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableYSize);
            this.Controls.Add(this.barrierGame);
            this.Controls.Add(this.snakeSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sizeCellTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableXSize);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sizeCellTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar snakeSpeed;
        private System.Windows.Forms.CheckBox barrierGame;
        private System.Windows.Forms.TrackBar tableXSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tableYSize;
    }
}