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
    public partial class Menu : Form
    {
        Image onSound;
        Image offSound;
        bool sound = true;
        System.IO.Stream soundStream;
        System.Media.SoundPlayer soundPlayer;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            startButton.Parent = backgroundBox;
            startButton.Left = (this.Width - startButton.Width) / 2;
            startButton.Top = ((this.Height - startButton.Height) / 2) - 120;
            exitButton.Parent = backgroundBox;
            exitButton.Left = (this.Width - exitButton.Width) / 2;
            exitButton.Top = ((this.Height - exitButton.Height) / 2) + 120;
            soundBox.Parent = backgroundBox;
            soundBox.Left = (this.Width - soundBox.Width)-50;
            soundBox.Top = ( soundBox.Height)-75;
            onSound = (Image)Properties.Resources.ResourceManager.GetObject("maxresdefault");
            offSound = (Image)Properties.Resources.ResourceManager.GetObject("maxresdefault2");
            soundBox.Image = onSound;

            soundStream = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject("Soundtrack");
            soundPlayer = new System.Media.SoundPlayer(soundStream);
            soundPlayer.PlayLooping();
        }

        private void soundBox_Click(object sender, EventArgs e)
        {
            sound = !sound;
            soundBox.Image = sound ? onSound : offSound;
            if (sound)
            {
                soundPlayer = new System.Media.SoundPlayer((System.IO.Stream)Properties.Resources.ResourceManager.GetObject("Soundtrack"));
                soundPlayer.PlayLooping();
            }
            else
                soundPlayer.Stop();
        }

        public void startButton_Click(object sender, EventArgs e)
        {
            startGame();
        }

        public void startGame()
        {
            LevelChoose ch = new LevelChoose(this);
            ch.setSound(sound);
            ch.Show();
            this.Hide();
        }

        public void stopSoundtrack()
        {
            soundPlayer.Stop();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
