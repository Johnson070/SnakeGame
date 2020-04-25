namespace SnakeGame
{
    partial class MainSnake
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSnake));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SettingForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateData = new System.Windows.Forms.Timer(this.components);
            this.snakeGameTool = new System.Windows.Forms.ToolStrip();
            this.snakeLevels = new System.Windows.Forms.ToolStripDropDownButton();
            this.openLeverEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.main = new System.Windows.Forms.ToolStripDropDownButton();
            this.settingsGame = new System.Windows.Forms.ToolStripMenuItem();
            this.loadLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.snakeGameTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 429);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SettingForm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gameButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Игра";
            // 
            // SettingForm
            // 
            this.SettingForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingForm.Location = new System.Drawing.Point(222, 16);
            this.SettingForm.Name = "SettingForm";
            this.SettingForm.Size = new System.Drawing.Size(90, 62);
            this.SettingForm.TabIndex = 3;
            this.SettingForm.Text = "Настройки";
            this.SettingForm.UseVisualStyleBackColor = true;
            this.SettingForm.Click += new System.EventHandler(this.SettingForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Время: ";
            // 
            // gameButton
            // 
            this.gameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gameButton.Location = new System.Drawing.Point(318, 16);
            this.gameButton.Name = "gameButton";
            this.gameButton.Size = new System.Drawing.Size(90, 62);
            this.gameButton.TabIndex = 1;
            this.gameButton.Text = "Начать";
            this.gameButton.UseVisualStyleBackColor = true;
            this.gameButton.Click += new System.EventHandler(this.gameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Очки:";
            // 
            // updateData
            // 
            this.updateData.Tick += new System.EventHandler(this.updateData_Tick);
            // 
            // snakeGameTool
            // 
            this.snakeGameTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeLevels,
            this.main});
            this.snakeGameTool.Location = new System.Drawing.Point(0, 0);
            this.snakeGameTool.Name = "snakeGameTool";
            this.snakeGameTool.Size = new System.Drawing.Size(438, 25);
            this.snakeGameTool.TabIndex = 6;
            this.snakeGameTool.Text = "Уровни";
            // 
            // snakeLevels
            // 
            this.snakeLevels.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.snakeLevels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openLeverEditor,
            this.loadLevel});
            this.snakeLevels.Image = ((System.Drawing.Image)(resources.GetObject("snakeLevels.Image")));
            this.snakeLevels.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.snakeLevels.Name = "snakeLevels";
            this.snakeLevels.Size = new System.Drawing.Size(61, 22);
            this.snakeLevels.Text = "Уровни";
            this.snakeLevels.ToolTipText = "\r\n";
            // 
            // openLeverEditor
            // 
            this.openLeverEditor.Name = "openLeverEditor";
            this.openLeverEditor.Size = new System.Drawing.Size(223, 22);
            this.openLeverEditor.Text = "Открыть редактор уровней";
            this.openLeverEditor.Click += new System.EventHandler(this.openLeverEditor_Click);
            // 
            // main
            // 
            this.main.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.main.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsGame});
            this.main.Image = ((System.Drawing.Image)(resources.GetObject("main.Image")));
            this.main.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(75, 22);
            this.main.Text = "Основное";
            this.main.ToolTipText = "\r\n";
            // 
            // settingsGame
            // 
            this.settingsGame.Name = "settingsGame";
            this.settingsGame.Size = new System.Drawing.Size(180, 22);
            this.settingsGame.Text = "Настройки игры";
            this.settingsGame.Click += new System.EventHandler(this.SettingForm_Click);
            // 
            // loadLevel
            // 
            this.loadLevel.Name = "loadLevel";
            this.loadLevel.Size = new System.Drawing.Size(223, 22);
            this.loadLevel.Text = "Открыть уровень";
            this.loadLevel.Click += new System.EventHandler(this.loadLevel_Click);
            // 
            // MainSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 559);
            this.Controls.Add(this.snakeGameTool);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "MainSnake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.loadForm);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.snakeGameTool.ResumeLayout(false);
            this.snakeGameTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer updateData;
        private System.Windows.Forms.Button gameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SettingForm;
        private System.Windows.Forms.ToolStrip snakeGameTool;
        private System.Windows.Forms.ToolStripDropDownButton snakeLevels;
        private System.Windows.Forms.ToolStripDropDownButton main;
        private System.Windows.Forms.ToolStripMenuItem settingsGame;
        private System.Windows.Forms.ToolStripMenuItem openLeverEditor;
        private System.Windows.Forms.ToolStripMenuItem loadLevel;
    }
}

