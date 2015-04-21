namespace VideoStreamProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OpenStream = new System.Windows.Forms.Button();
            this.OpenAd = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenStream
            // 
            this.OpenStream.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenStream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenStream.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OpenStream.Location = new System.Drawing.Point(12, 12);
            this.OpenStream.Name = "OpenStream";
            this.OpenStream.Size = new System.Drawing.Size(282, 38);
            this.OpenStream.TabIndex = 1;
            this.OpenStream.Text = "Open Stream";
            this.OpenStream.UseVisualStyleBackColor = false;
            this.OpenStream.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenAd
            // 
            this.OpenAd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenAd.Location = new System.Drawing.Point(322, 12);
            this.OpenAd.Name = "OpenAd";
            this.OpenAd.Size = new System.Drawing.Size(282, 38);
            this.OpenAd.TabIndex = 2;
            this.OpenAd.Text = "Open Advertisement";
            this.OpenAd.UseVisualStyleBackColor = false;
            this.OpenAd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Scan
            // 
            this.Scan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Scan.Location = new System.Drawing.Point(12, 306);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(282, 32);
            this.Scan.TabIndex = 3;
            this.Scan.Text = "Start Scan";
            this.Scan.UseVisualStyleBackColor = false;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.Location = new System.Drawing.Point(481, 306);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 32);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 56);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(282, 215);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(322, 56);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(282, 215);
            this.axWindowsMediaPlayer2.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 350);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.OpenStream);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.OpenAd);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Stream ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenStream;
        private System.Windows.Forms.Button OpenAd;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Exit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;

    }
}

