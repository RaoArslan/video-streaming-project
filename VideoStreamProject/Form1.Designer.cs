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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Opentransmition = new System.Windows.Forms.Button();
            this.OpenAd = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Opentransmition
            // 
            this.Opentransmition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Opentransmition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Opentransmition.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Opentransmition.Location = new System.Drawing.Point(12, 12);
            this.Opentransmition.Name = "Opentransmition";
            this.Opentransmition.Size = new System.Drawing.Size(282, 38);
            this.Opentransmition.TabIndex = 1;
            this.Opentransmition.Text = "Open Transmition";
            this.Opentransmition.UseVisualStyleBackColor = false;
            this.Opentransmition.Click += new System.EventHandler(this.button2_Click);
            // 
            // OpenAd
            // 
            this.OpenAd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.Location = new System.Drawing.Point(481, 306);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(123, 32);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(322, 56);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(282, 215);
            this.axWindowsMediaPlayer2.TabIndex = 6;
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
            this.Controls.Add(this.Opentransmition);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.OpenAd);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Stream ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Opentransmition;
        private System.Windows.Forms.Button OpenAd;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.Button Exit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;

    }
}

