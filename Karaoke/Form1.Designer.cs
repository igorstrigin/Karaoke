namespace Karaoke
{
    partial class Form1
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
            this.btnStopRecord = new System.Windows.Forms.Button();
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnFindSong = new System.Windows.Forms.Button();
            this.tbArtistAndSong = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStopRecord
            // 
            this.btnStopRecord.Location = new System.Drawing.Point(555, 415);
            this.btnStopRecord.Name = "btnStopRecord";
            this.btnStopRecord.Size = new System.Drawing.Size(138, 23);
            this.btnStopRecord.TabIndex = 0;
            this.btnStopRecord.Text = "Остановить запись";
            this.btnStopRecord.UseVisualStyleBackColor = true;
            this.btnStopRecord.Click += new System.EventHandler(this.btnStopRecord_Click);
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(118, 415);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(129, 23);
            this.btnStartRecord.TabIndex = 1;
            this.btnStartRecord.Text = "Начать запись";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(392, 373);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnFindSong
            // 
            this.btnFindSong.Location = new System.Drawing.Point(565, 376);
            this.btnFindSong.Name = "btnFindSong";
            this.btnFindSong.Size = new System.Drawing.Size(223, 23);
            this.btnFindSong.TabIndex = 3;
            this.btnFindSong.Text = "Открыть";
            this.btnFindSong.UseVisualStyleBackColor = true;
            this.btnFindSong.Click += new System.EventHandler(this.btnFindSong_Click);
            // 
            // tbArtistAndSong
            // 
            this.tbArtistAndSong.Location = new System.Drawing.Point(12, 379);
            this.tbArtistAndSong.Name = "tbArtistAndSong";
            this.tbArtistAndSong.Size = new System.Drawing.Size(533, 20);
            this.tbArtistAndSong.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(399, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 370);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbArtistAndSong);
            this.Controls.Add(this.btnFindSong);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnStartRecord);
            this.Controls.Add(this.btnStopRecord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStopRecord;
        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnFindSong;
        private System.Windows.Forms.TextBox tbArtistAndSong;
        private System.Windows.Forms.TextBox textBox1;
    }
}

