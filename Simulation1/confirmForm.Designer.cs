namespace SnakeGame
{
    partial class confirmForm
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
            this.label = new System.Windows.Forms.Label();
            this.scoreUnlock = new System.Windows.Forms.NumericUpDown();
            this.confirm = new System.Windows.Forms.Button();
            this.direction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreUnlock)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(313, 20);
            this.label.TabIndex = 0;
            this.label.Text = "Кол-во очков для разблокировки двери";
            // 
            // scoreUnlock
            // 
            this.scoreUnlock.Location = new System.Drawing.Point(108, 32);
            this.scoreUnlock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.scoreUnlock.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.scoreUnlock.Name = "scoreUnlock";
            this.scoreUnlock.Size = new System.Drawing.Size(120, 20);
            this.scoreUnlock.TabIndex = 1;
            this.scoreUnlock.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(16, 58);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(309, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Подтвердить";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // direction
            // 
            this.direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.direction.FormattingEnabled = true;
            this.direction.Items.AddRange(new object[] {
            "Вверх",
            "Вправо",
            "Вниз",
            "Влево"});
            this.direction.Location = new System.Drawing.Point(107, 31);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(121, 21);
            this.direction.TabIndex = 3;
            this.direction.Visible = false;
            // 
            // confirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 90);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.scoreUnlock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "confirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введите значение";
            ((System.ComponentModel.ISupportInitialize)(this.scoreUnlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.NumericUpDown scoreUnlock;
        private System.Windows.Forms.Button confirm;
        public System.Windows.Forms.Label label;
        public System.Windows.Forms.ComboBox direction;
    }
}