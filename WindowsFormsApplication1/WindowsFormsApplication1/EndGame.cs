using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EndGame : Form
    {
        int score = 0;
        Game gameForm;
        bool shouldClose = true;
        List<string> wrong;

        public EndGame(List<string> wr)
        {
            InitializeComponent();
            wrong = wr;
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            scoreLabel.Anchor = AnchorStyles.Top;
            scoreLabel.Left = 3*(this.Width - scoreLabel.Width) /7;
            scoreLabel.Top = (this.Height - scoreLabel.Height) / 10;
            scoreLabel.Font = new Font(scoreLabel.Font.FontFamily, 150);
            scoreLabel.Parent = background;
            start.Left = (this.Width - start.Width) / 2 - 150;
            start.Top = (this.Height - start.Height) / 2 + 130;
            start.Parent = background;
            exit.Left = (this.Width - exit.Width) / 2 + 150;
            exit.Top = (this.Height - exit.Height) / 2 + 130;
            exit.Parent = background;
            wrongLabel.Font = new Font(wrongLabel.Font.FontFamily, 25);
            wrongLabel.Top = scoreLabel.Top + scoreLabel.Height + 50;
            wrongLabel.Left = this.Width / 4;
            wrongLabel.Parent = background;
            wrongLabel.Text = "Wrong answers: ";
            for(int i = 0; i < wrong.Count; i++)
            {
                wrongLabel.Text = wrongLabel.Text + wrong[i].Substring(0,wrong[i].Length-1);
                if (i != wrong.Count - 1)
                    wrongLabel.Text = wrongLabel.Text + ", ";
            }
        }

        public void setGameForm(Game gameForm)
        {
            this.gameForm = gameForm;
        }

        public void setScore(int score)
        {
            this.score = score;
            scoreLabel.Text = score.ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void EndGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(shouldClose)
                Application.Exit();
        }

        private void EndGame_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
