namespace WindowsFormsApplication1
{
    partial class LevelChoose
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
            this.background = new System.Windows.Forms.PictureBox();
            this.tame = new System.Windows.Forms.PictureBox();
            this.wild = new System.Windows.Forms.PictureBox();
            this.both = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.both)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = global::WindowsFormsApplication1.Properties.Resources.Background;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(610, 342);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // tame
            // 
            this.tame.BackColor = System.Drawing.Color.Transparent;
            this.tame.Image = global::WindowsFormsApplication1.Properties.Resources.LevelTame;
            this.tame.Location = new System.Drawing.Point(136, 150);
            this.tame.Name = "tame";
            this.tame.Size = new System.Drawing.Size(513, 196);
            this.tame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tame.TabIndex = 1;
            this.tame.TabStop = false;
            this.tame.Click += new System.EventHandler(this.tame_Click);
            // 
            // wild
            // 
            this.wild.BackColor = System.Drawing.Color.Transparent;
            this.wild.Image = global::WindowsFormsApplication1.Properties.Resources.LevelWild;
            this.wild.Location = new System.Drawing.Point(120, 146);
            this.wild.Name = "wild";
            this.wild.Size = new System.Drawing.Size(408, 197);
            this.wild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wild.TabIndex = 2;
            this.wild.TabStop = false;
            this.wild.Click += new System.EventHandler(this.wild_Click);
            // 
            // both
            // 
            this.both.BackColor = System.Drawing.Color.Transparent;
            this.both.Image = global::WindowsFormsApplication1.Properties.Resources.LevelBoth;
            this.both.Location = new System.Drawing.Point(120, 12);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(408, 197);
            this.both.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.both.TabIndex = 3;
            this.both.TabStop = false;
            this.both.Click += new System.EventHandler(this.both_Click);
            // 
            // LevelChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 342);
            this.Controls.Add(this.both);
            this.Controls.Add(this.wild);
            this.Controls.Add(this.tame);
            this.Controls.Add(this.background);
            this.Name = "LevelChoose";
            this.Text = "LevelChoose";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LevelChoose_FormClosed);
            this.Load += new System.EventHandler(this.LevelChoose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.both)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.PictureBox tame;
        private System.Windows.Forms.PictureBox wild;
        private System.Windows.Forms.PictureBox both;
    }
}