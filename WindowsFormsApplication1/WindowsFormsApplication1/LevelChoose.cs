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
    public partial class LevelChoose : Form
    {
        bool sound = false;
        Menu menu;

        public LevelChoose(Menu m)
        {
            InitializeComponent();
            menu = m;
        }


        private void LevelChoose_Load(object sender, EventArgs e)
        {
            tame.Left = (this.Width - tame.Width) / 2;
            tame.Top = (this.Height - tame.Height) / 6;
            tame.Parent = background;
            wild.Left = (this.Width - wild.Width) / 2;
            wild.Top = 2*(this.Height - wild.Height) / 4;
            wild.Parent = background;
            both.Left = (this.Width - both.Width) / 2;
            both.Top = 4 * (this.Height - both.Height) / 5;
            both.Parent = background;

        }

        public void init(bool s)
        {
            sound = s;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tame_Click(object sender, EventArgs e)
        {
            if (menu != null)
                menu.stopSoundtrack();
            Game game = new Game(1);
            game.setSound(sound);
            game.Show();
            this.Hide();
        }

        private void wild_Click(object sender, EventArgs e)
        {
            if(menu != null)
                menu.stopSoundtrack();
            Game game = new Game(2);
            game.setSound(sound);
            game.Show();
            this.Hide();
        }

        private void both_Click(object sender, EventArgs e)
        {
            if (menu != null)
                menu.stopSoundtrack();
            Game game = new Game(3);
            game.setSound(sound);
            game.Show();
            this.Hide();
        }

        public void setSound(bool s)
        {
            sound = s;
        }

        private void LevelChoose_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
