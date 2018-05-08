namespace AntGame
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.goButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelEat = new System.Windows.Forms.Label();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(516, 660);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(138, 29);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Вперед муравей";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 642);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNum.Location = new System.Drawing.Point(12, 664);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(57, 20);
            this.labelNum.TabIndex = 2;
            this.labelNum.Text = "Ход: 0";
            // 
            // labelEat
            // 
            this.labelEat.AutoSize = true;
            this.labelEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEat.Location = new System.Drawing.Point(86, 664);
            this.labelEat.Name = "labelEat";
            this.labelEat.Size = new System.Drawing.Size(140, 20);
            this.labelEat.TabIndex = 3;
            this.labelEat.Text = "Собрано яблок: 0";
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.LargeChange = 100;
            this.trackBarSpeed.Location = new System.Drawing.Point(330, 660);
            this.trackBarSpeed.Maximum = 2000;
            this.trackBarSpeed.Minimum = 50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarSpeed.Size = new System.Drawing.Size(168, 45);
            this.trackBarSpeed.SmallChange = 100;
            this.trackBarSpeed.TabIndex = 4;
            this.trackBarSpeed.TickFrequency = 200;
            this.trackBarSpeed.Value = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(243, 664);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Скорость";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 695);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.labelEat);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.goButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра \"Умный муравей\"";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelEat;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label2;
    }
}

