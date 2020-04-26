namespace SnakeGame
{
    partial class controlsSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlsSetting));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.upKey = new System.Windows.Forms.Button();
            this.downKey = new System.Windows.Forms.Button();
            this.leftKey = new System.Windows.Forms.Button();
            this.rightKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клавиша вверх:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клавиша вниз:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клавиша влево:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клавиша вправо:";
            // 
            // upKey
            // 
            this.upKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.upKey.Location = new System.Drawing.Point(158, 3);
            this.upKey.Name = "upKey";
            this.upKey.Size = new System.Drawing.Size(192, 32);
            this.upKey.TabIndex = 4;
            this.upKey.Text = "button1";
            this.upKey.UseVisualStyleBackColor = true;
            this.upKey.Click += new System.EventHandler(this.upKey_Click);
            // 
            // downKey
            // 
            this.downKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.downKey.Location = new System.Drawing.Point(158, 41);
            this.downKey.Name = "downKey";
            this.downKey.Size = new System.Drawing.Size(192, 32);
            this.downKey.TabIndex = 5;
            this.downKey.Text = "button2";
            this.downKey.UseVisualStyleBackColor = true;
            this.downKey.Click += new System.EventHandler(this.downKey_Click);
            // 
            // leftKey
            // 
            this.leftKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftKey.Location = new System.Drawing.Point(158, 79);
            this.leftKey.Name = "leftKey";
            this.leftKey.Size = new System.Drawing.Size(192, 32);
            this.leftKey.TabIndex = 6;
            this.leftKey.Text = "button3";
            this.leftKey.UseVisualStyleBackColor = true;
            this.leftKey.Click += new System.EventHandler(this.leftKey_Click);
            // 
            // rightKey
            // 
            this.rightKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightKey.Location = new System.Drawing.Point(158, 117);
            this.rightKey.Name = "rightKey";
            this.rightKey.Size = new System.Drawing.Size(192, 32);
            this.rightKey.TabIndex = 7;
            this.rightKey.Text = "button4";
            this.rightKey.UseVisualStyleBackColor = true;
            this.rightKey.Click += new System.EventHandler(this.rightKey_Click);
            // 
            // controlsSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 159);
            this.Controls.Add(this.rightKey);
            this.Controls.Add(this.leftKey);
            this.Controls.Add(this.downKey);
            this.Controls.Add(this.upKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "controlsSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка клавиш управления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button upKey;
        private System.Windows.Forms.Button downKey;
        private System.Windows.Forms.Button leftKey;
        private System.Windows.Forms.Button rightKey;
    }
}