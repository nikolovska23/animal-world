namespace WindowsFormsApplication1
{
    partial class Game
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
            this.button1 = new System.Windows.Forms.Button();
            this.scannerBox = new System.Windows.Forms.PictureBox();
            this.animalBox = new System.Windows.Forms.PictureBox();
            this.backgroundBox = new System.Windows.Forms.PictureBox();
            this.frame = new System.Windows.Forms.PictureBox();
            this.feedback = new System.Windows.Forms.PictureBox();
            this.feedbackText = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.emoji = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scannerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scannerBox
            // 
            this.scannerBox.BackColor = System.Drawing.Color.Transparent;
            this.scannerBox.Location = new System.Drawing.Point(880, 150);
            this.scannerBox.Name = "scannerBox";
            this.scannerBox.Size = new System.Drawing.Size(350, 275);
            this.scannerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scannerBox.TabIndex = 1;
            this.scannerBox.TabStop = false;
            // 
            // animalBox
            // 
            this.animalBox.BackColor = System.Drawing.Color.Transparent;
            this.animalBox.Location = new System.Drawing.Point(117, 173);
            this.animalBox.MaximumSize = new System.Drawing.Size(450, 450);
            this.animalBox.Name = "animalBox";
            this.animalBox.Size = new System.Drawing.Size(450, 450);
            this.animalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.animalBox.TabIndex = 0;
            this.animalBox.TabStop = false;
            // 
            // backgroundBox
            // 
            this.backgroundBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundBox.Image = global::WindowsFormsApplication1.Properties.Resources.Background;
            this.backgroundBox.Location = new System.Drawing.Point(0, 0);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(981, 593);
            this.backgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundBox.TabIndex = 3;
            this.backgroundBox.TabStop = false;
            // 
            // frame
            // 
            this.frame.BackColor = System.Drawing.Color.Transparent;
            this.frame.Image = global::WindowsFormsApplication1.Properties.Resources.Frame_Wood_Leaves_1;
            this.frame.Location = new System.Drawing.Point(0, 0);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(540, 460);
            this.frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frame.TabIndex = 4;
            this.frame.TabStop = false;
            // 
            // feedback
            // 
            this.feedback.BackColor = System.Drawing.Color.Transparent;
            this.feedback.Location = new System.Drawing.Point(596, 150);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(100, 50);
            this.feedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedback.TabIndex = 5;
            this.feedback.TabStop = false;
            // 
            // feedbackText
            // 
            this.feedbackText.BackColor = System.Drawing.Color.Transparent;
            this.feedbackText.Location = new System.Drawing.Point(596, 219);
            this.feedbackText.Name = "feedbackText";
            this.feedbackText.Size = new System.Drawing.Size(210, 100);
            this.feedbackText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.feedbackText.TabIndex = 7;
            this.feedbackText.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(13, 14);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "0";
            // 
            // emoji
            // 
            this.emoji.BackColor = System.Drawing.Color.Transparent;
            this.emoji.Location = new System.Drawing.Point(643, 56);
            this.emoji.Name = "emoji";
            this.emoji.Size = new System.Drawing.Size(100, 100);
            this.emoji.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emoji.TabIndex = 9;
            this.emoji.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 593);
            this.Controls.Add(this.emoji);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.feedbackText);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.frame);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scannerBox);
            this.Controls.Add(this.animalBox);
            this.Controls.Add(this.backgroundBox);
            this.Name = "Game";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.scannerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emoji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox animalBox;
        private System.Windows.Forms.PictureBox scannerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox backgroundBox;
        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.PictureBox feedback;
        private System.Windows.Forms.PictureBox feedbackText;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox emoji;
    }
}

