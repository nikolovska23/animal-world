namespace WindowsFormsApplication1
{
    partial class Menu
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
            this.backgroundBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.PictureBox();
            this.soundBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundBox
            // 
            this.backgroundBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundBox.Image = global::WindowsFormsApplication1.Properties.Resources.Background;
            this.backgroundBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(767, 470);
            this.backgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundBox.TabIndex = 0;
            this.backgroundBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.Image = global::WindowsFormsApplication1.Properties.Resources.start;
            this.startButton.Location = new System.Drawing.Point(189, 140);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(608, 204);
            this.startButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.startButton.TabIndex = 1;
            this.startButton.TabStop = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Image = global::WindowsFormsApplication1.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(189, 278);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(416, 204);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitButton.TabIndex = 2;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // soundBox
            // 
            this.soundBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.soundBox.BackColor = System.Drawing.Color.Transparent;
            this.soundBox.Image = global::WindowsFormsApplication1.Properties.Resources.maxresdefault;
            this.soundBox.Location = new System.Drawing.Point(105, 259);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(100, 100);
            this.soundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.soundBox.TabIndex = 3;
            this.soundBox.TabStop = false;
            this.soundBox.Click += new System.EventHandler(this.soundBox_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 470);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.backgroundBox);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundBox;
        private System.Windows.Forms.PictureBox startButton;
        private System.Windows.Forms.PictureBox exitButton;
        private System.Windows.Forms.PictureBox soundBox;
    }
}