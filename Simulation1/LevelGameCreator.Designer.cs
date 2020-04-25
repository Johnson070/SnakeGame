namespace SnakeGame
{
    partial class LevelGameCreator
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
            this.components = new System.ComponentModel.Container();
            this.tabLevel = new System.Windows.Forms.TabControl();
            this.tabTable = new System.Windows.Forms.TabPage();
            this.table = new System.Windows.Forms.Panel();
            this.rightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.block1 = new System.Windows.Forms.ToolStripMenuItem();
            this.block2 = new System.Windows.Forms.ToolStripMenuItem();
            this.block3 = new System.Windows.Forms.ToolStripMenuItem();
            this.block4 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCell = new System.Windows.Forms.ToolStripMenuItem();
            this.тестJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проверкаЕдыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timeLevel = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.foodGenTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.scoreWin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableYSize = new System.Windows.Forms.TrackBar();
            this.barrierGame = new System.Windows.Forms.CheckBox();
            this.snakeSpeed = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeCellTable = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableXSize = new System.Windows.Forms.TrackBar();
            this.tabLevel.SuspendLayout();
            this.tabTable.SuspendLayout();
            this.rightClickMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGenTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreWin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).BeginInit();
            this.SuspendLayout();
            // 
            // tabLevel
            // 
            this.tabLevel.Controls.Add(this.tabTable);
            this.tabLevel.Controls.Add(this.tabPage2);
            this.tabLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLevel.Location = new System.Drawing.Point(0, 0);
            this.tabLevel.Name = "tabLevel";
            this.tabLevel.SelectedIndex = 0;
            this.tabLevel.Size = new System.Drawing.Size(504, 441);
            this.tabLevel.TabIndex = 0;
            this.tabLevel.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabLevel_Selected);
            // 
            // tabTable
            // 
            this.tabTable.Controls.Add(this.table);
            this.tabTable.Location = new System.Drawing.Point(4, 22);
            this.tabTable.Name = "tabTable";
            this.tabTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabTable.Size = new System.Drawing.Size(496, 415);
            this.tabTable.TabIndex = 0;
            this.tabTable.Text = "Поле";
            this.tabTable.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.ContextMenuStrip = this.rightClickMenu;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(490, 409);
            this.table.TabIndex = 1;
            this.table.Click += new System.EventHandler(this.table_Click);
            this.table.Paint += new System.Windows.Forms.PaintEventHandler(this.table_Paint);
            this.table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.table_MouseMove);
            // 
            // rightClickMenu
            // 
            this.rightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.block1,
            this.block2,
            this.block3,
            this.block4,
            this.clearCell,
            this.тестJsonToolStripMenuItem,
            this.проверкаЕдыToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьУровеньToolStripMenuItem,
            this.загрузитьУровеньToolStripMenuItem});
            this.rightClickMenu.Name = "rightClickMenu";
            this.rightClickMenu.Size = new System.Drawing.Size(216, 230);
            // 
            // block1
            // 
            this.block1.Image = global::snakeGame.Properties.Resources.block1;
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(215, 22);
            this.block1.Text = "Блок-стены";
            this.block1.Click += new System.EventHandler(this.selectBlock);
            // 
            // block2
            // 
            this.block2.Image = global::snakeGame.Properties.Resources.block2;
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(215, 22);
            this.block2.Text = "Блок-двери";
            this.block2.Click += new System.EventHandler(this.selectBlock);
            // 
            // block3
            // 
            this.block3.Image = global::snakeGame.Properties.Resources.block3;
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(215, 22);
            this.block3.Text = "Место спавна";
            this.block3.Click += new System.EventHandler(this.selectBlock);
            // 
            // block4
            // 
            this.block4.Image = global::snakeGame.Properties.Resources.block4;
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(215, 22);
            this.block4.Text = "Блок-завершение уровня";
            this.block4.Click += new System.EventHandler(this.selectBlock);
            // 
            // clearCell
            // 
            this.clearCell.Name = "clearCell";
            this.clearCell.Size = new System.Drawing.Size(215, 22);
            this.clearCell.Text = "Стереть";
            this.clearCell.Click += new System.EventHandler(this.selectBlock);
            // 
            // тестJsonToolStripMenuItem
            // 
            this.тестJsonToolStripMenuItem.Name = "тестJsonToolStripMenuItem";
            this.тестJsonToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.тестJsonToolStripMenuItem.Text = "Тест json";
            this.тестJsonToolStripMenuItem.Click += new System.EventHandler(this.testJson);
            // 
            // проверкаЕдыToolStripMenuItem
            // 
            this.проверкаЕдыToolStripMenuItem.Name = "проверкаЕдыToolStripMenuItem";
            this.проверкаЕдыToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.проверкаЕдыToolStripMenuItem.Text = "Проверка еды";
            this.проверкаЕдыToolStripMenuItem.Click += new System.EventHandler(this.testFood);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // сохранитьУровеньToolStripMenuItem
            // 
            this.сохранитьУровеньToolStripMenuItem.Name = "сохранитьУровеньToolStripMenuItem";
            this.сохранитьУровеньToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.сохранитьУровеньToolStripMenuItem.Text = "Сохранить уровень";
            this.сохранитьУровеньToolStripMenuItem.Click += new System.EventHandler(this.saveLevel);
            // 
            // загрузитьУровеньToolStripMenuItem
            // 
            this.загрузитьУровеньToolStripMenuItem.Name = "загрузитьУровеньToolStripMenuItem";
            this.загрузитьУровеньToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.загрузитьУровеньToolStripMenuItem.Text = "Загрузить уровень";
            this.загрузитьУровеньToolStripMenuItem.Click += new System.EventHandler(this.testLoadLevel);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.timeLevel);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.foodGenTime);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.scoreWin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tableYSize);
            this.tabPage2.Controls.Add(this.barrierGame);
            this.tabPage2.Controls.Add(this.snakeSpeed);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.sizeCellTable);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tableXSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // timeLevel
            // 
            this.timeLevel.Location = new System.Drawing.Point(303, 97);
            this.timeLevel.Name = "timeLevel";
            this.timeLevel.Size = new System.Drawing.Size(120, 20);
            this.timeLevel.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(234, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Время прохождения уровня(сек):";
            // 
            // foodGenTime
            // 
            this.foodGenTime.Location = new System.Drawing.Point(303, 26);
            this.foodGenTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.foodGenTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.foodGenTime.Name = "foodGenTime";
            this.foodGenTime.Size = new System.Drawing.Size(120, 20);
            this.foodGenTime.TabIndex = 22;
            this.foodGenTime.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(259, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Время генерации еды(мс):";
            // 
            // scoreWin
            // 
            this.scoreWin.Location = new System.Drawing.Point(49, 330);
            this.scoreWin.Name = "scoreWin";
            this.scoreWin.Size = new System.Drawing.Size(120, 20);
            this.scoreWin.TabIndex = 19;
            this.scoreWin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кол-во очков\r\nдля прохождения уровня:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Размер поля(Высота):";
            // 
            // tableYSize
            // 
            this.tableYSize.Location = new System.Drawing.Point(10, 97);
            this.tableYSize.Maximum = 50;
            this.tableYSize.Minimum = 10;
            this.tableYSize.Name = "tableYSize";
            this.tableYSize.Size = new System.Drawing.Size(218, 45);
            this.tableYSize.TabIndex = 16;
            this.tableYSize.Value = 15;
            this.tableYSize.Scroll += new System.EventHandler(this.tableYSize_Scroll);
            // 
            // barrierGame
            // 
            this.barrierGame.AutoSize = true;
            this.barrierGame.Checked = true;
            this.barrierGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barrierGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.barrierGame.Location = new System.Drawing.Point(6, 356);
            this.barrierGame.Name = "barrierGame";
            this.barrierGame.Size = new System.Drawing.Size(240, 44);
            this.barrierGame.TabIndex = 15;
            this.barrierGame.Text = "Проигрыш от столкновения\r\nсо стенкой";
            this.barrierGame.UseVisualStyleBackColor = true;
            // 
            // snakeSpeed
            // 
            this.snakeSpeed.LargeChange = 25;
            this.snakeSpeed.Location = new System.Drawing.Point(10, 239);
            this.snakeSpeed.Maximum = 250;
            this.snakeSpeed.Minimum = 50;
            this.snakeSpeed.Name = "snakeSpeed";
            this.snakeSpeed.Size = new System.Drawing.Size(218, 45);
            this.snakeSpeed.SmallChange = 10;
            this.snakeSpeed.TabIndex = 14;
            this.snakeSpeed.Value = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Скорость змейки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Размер ячейки:";
            // 
            // sizeCellTable
            // 
            this.sizeCellTable.Location = new System.Drawing.Point(10, 168);
            this.sizeCellTable.Maximum = 50;
            this.sizeCellTable.Minimum = 10;
            this.sizeCellTable.Name = "sizeCellTable";
            this.sizeCellTable.Size = new System.Drawing.Size(218, 45);
            this.sizeCellTable.TabIndex = 11;
            this.sizeCellTable.Value = 35;
            this.sizeCellTable.Scroll += new System.EventHandler(this.sizeCellTable_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Размер поля(Ширина):";
            // 
            // tableXSize
            // 
            this.tableXSize.Location = new System.Drawing.Point(10, 26);
            this.tableXSize.Maximum = 50;
            this.tableXSize.Minimum = 10;
            this.tableXSize.Name = "tableXSize";
            this.tableXSize.Size = new System.Drawing.Size(218, 45);
            this.tableXSize.TabIndex = 9;
            this.tableXSize.Value = 15;
            this.tableXSize.Scroll += new System.EventHandler(this.tableXSize_Scroll);
            // 
            // LevelGameCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Controls.Add(this.tabLevel);
            this.Name = "LevelGameCreator";
            this.Text = "Редактор уровня";
            this.Shown += new System.EventHandler(this.LevelGameCreator_Shown);
            this.Resize += new System.EventHandler(this.LevelGameCreator_Resize);
            this.tabLevel.ResumeLayout(false);
            this.tabTable.ResumeLayout(false);
            this.rightClickMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodGenTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreWin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableYSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeCellTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableXSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLevel;
        private System.Windows.Forms.TabPage tabTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tableYSize;
        private System.Windows.Forms.CheckBox barrierGame;
        private System.Windows.Forms.TrackBar snakeSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sizeCellTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tableXSize;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.ContextMenuStrip rightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem block1;
        private System.Windows.Forms.ToolStripMenuItem block2;
        private System.Windows.Forms.ToolStripMenuItem block3;
        private System.Windows.Forms.ToolStripMenuItem clearCell;
        private System.Windows.Forms.ToolStripMenuItem block4;
        private System.Windows.Forms.NumericUpDown scoreWin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem тестJsonToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown foodGenTime;
        private System.Windows.Forms.NumericUpDown timeLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem проверкаЕдыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьУровеньToolStripMenuItem;
    }
}