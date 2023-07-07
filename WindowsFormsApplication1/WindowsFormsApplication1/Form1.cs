using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WindowsFormsApplication1
{
    public partial class Game : Form
    {
        int levelmode;
        private List<Animal> animals;
        private List<string> wrongAnimals;
        private bool scanning = false;
        private Scanner scanner;
        private int points = 0;
        private int current = -1;
        private bool sound;
        private bool shouldExit = true;
        private Image correct;
        private Image incorrect;
        private Image cText;
        private Image wText;
        private Image happy;
        private Image sad;

        System.Media.SoundPlayer soundPlayer;
        System.Media.SoundPlayer buzzPlayer;
        MediaPlayer soundtrack;

        public Game()
        {
            InitializeComponent();
        }

        public Game(int mode)
        {
            InitializeComponent();
            levelmode = mode;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            animalBox.Parent = backgroundBox;
            frame.Parent = backgroundBox;
            scannerBox.BringToFront();
            scannerBox.Left = 4 * (this.Width - scannerBox.Width) / 5;
            scannerBox.Top = 2 * (this.Height - scannerBox.Height) / 5;
            frame.Left = scannerBox.Left-110;
            frame.Top = scannerBox.Top - 110;
            animalBox.Left = 2*(this.Width - animalBox.Height) / 9;
            animalBox.Top = 4*(this.Height - animalBox.Height) / 5;
            animalBox.MaximumSize = new Size(this.Width / 2, this.Height / 2);
            scannerBox.MaximumSize = new Size(this.Width/2,this.Height /3);
            frame.Height =(int)( scannerBox.Height * 1.75);
            frame.Width = (int)(scannerBox.Width * 1.55);
            feedback.Size = new Size(this.Height / 4, this.Height / 4);
            feedback.Top = 7*(this.Height - feedback.Height)/8 ;
            feedback.Left = 7 * (this.Width - feedback.Width) / 9;
            feedback.Parent = backgroundBox;
            feedback.Hide();
            feedbackText.Left = 3*(this.Width - feedbackText.Width) / 5;
            feedbackText.Top = 7 * (this.Height - feedbackText.Height) / 8;
            feedbackText.Parent = backgroundBox;
            feedbackText.Hide();
            scoreLabel.Font = new Font(scoreLabel.Font.FontFamily, 75);
            scoreLabel.Parent = backgroundBox;
            emoji.Parent = backgroundBox;
            emoji.Left = 200;
            emoji.Top = 20;
            emoji.Hide();

            correct = Properties.Resources.correct;
            incorrect = Properties.Resources.incorrect;
            happy = Properties.Resources.smile;
            sad = Properties.Resources.sad;
            //cText = Properties.Resources.cText;
            //wText = Properties.Resources.wText;


            System.IO.Stream soundStream = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject("claps");
            soundPlayer = new System.Media.SoundPlayer(soundStream);
            System.IO.Stream buzzStream = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject("buzzer2");
            buzzPlayer = new System.Media.SoundPlayer(buzzStream);
            soundtrack = new MediaPlayer();
            string wanted_path = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            System.Uri u = new System.Uri(wanted_path + "\\Sounds\\Soundtrack.wav");
            soundtrack.Volume = 0.5;
            soundtrack.Open(u);
            if(sound)
            {
                soundtrack.MediaEnded += soundTrackLoop;
                soundtrack.Play();
            }
                
            

            animals = new List<Animal>();
            wrongAnimals = new List<string>();
            scannerBox.Image = null;
            scanner = new Scanner(ref scannerBox);
            if(levelmode==1)
            {
                animals.Add(new Animal("Cat_", 30));
                animals.Add(new Animal("Cow_", 30));
                animals.Add(new Animal("Dog_", 30));
                animals.Add(new Animal("Goat_", 30));
                animals.Add(new Animal("Horse_", 30));
            }
            else if(levelmode==2)
            {
                animals.Add(new Animal("Bear_", 30));
                animals.Add(new Animal("Elephant_", 30));
                animals.Add(new Animal("Giraffe_", 30));
                animals.Add(new Animal("Monkey_", 30));
                animals.Add(new Animal("Wolf_", 30));
            }
            else
            {
                animals.Add(new Animal("Cat_", 30));
                animals.Add(new Animal("Cow_", 30));
                animals.Add(new Animal("Dog_", 30));
                animals.Add(new Animal("Goat_", 30));
                animals.Add(new Animal("Horse_", 30));
                animals.Add(new Animal("Bear_", 30));
                animals.Add(new Animal("Elephant_", 30));
                animals.Add(new Animal("Giraffe_", 30));
                animals.Add(new Animal("Monkey_", 30));
                animals.Add(new Animal("Wolf_", 30));
            }

            randomAnimal();
        }

        private void soundTrackLoop(object sender, EventArgs e)
        {
            soundtrack.Stop();
            soundtrack.Play();
        }

        public void setSound(bool sound)
        {
            this.sound = sound;
        }


        private async void randomAnimal()
        {
            await Task.Delay(3000);
            if (animals.Count <= 0)
            {
                current = -1;
                return;
            }
            Random rand = new Random();
            int id = rand.Next(animals.Count);
            animals[id].animate(animalBox);
            if (sound)
                animals[id].playSound();
            current = id;
            //if(!scanning)
            //    startScanning();

            getQR();
        }

        private void startScanning()
        {
            if (scanning)
                return;
            scanning = true;
            getQR();
        }

        private async Task getQR()
        {
            if (scanning)
                return;
            scanning = true;

            string code = await scanner.startScan();
            
            if (!string.IsNullOrEmpty(code))
            {
                Console.WriteLine(code);
                QRRecieved(code);
            }
            scanning = false;
        }

        private void QRRecieved(string code)
        {
            //scanner.stopScan();
            scanning = false;
            animals[current].stopAnimating();
            if (animals[current].checkAnswer(code))
            {
                points++;
                scoreLabel.Text = points.ToString();
                soundPlayer.Play();
                animals.RemoveAt(current);
                scanFeedback(correct,Properties.Resources.cText, happy);
            }
            else
            {
                buzzPlayer.Play();
                scanFeedback(incorrect, Properties.Resources.wText, sad);
                if (animals[current].getFirst())
                {
                    Animal tmp = new Animal(animals[current]);
                    tmp.setFirst(false);
                    animals.RemoveAt(current);
                    animals.Add(tmp);
                }
                else
                {
                    wrongAnimals.Add(animals[current].getName());
                    animals.RemoveAt(current);
                }
            }
            
            if (animals.Count <= 0)
            {
                scanner.stopScan();
                if(sound)
                    soundtrack.Stop();
                EndGame eg = new EndGame(wrongAnimals);
                eg.setScore(points);
                eg.setGameForm(this);
                eg.Show();
                
                shouldExit = false;
                this.Close();
            }
            else
                randomAnimal();
        }


        private async Task scanFeedback(Image img, Image text, Image face)
        {
            emoji.Image = face;
            emoji.Show();
            feedback.Image = img;
            feedback.Show();
            feedbackText.Image = text;
            feedbackText.Show();
            await Task.Delay(2000);
            feedback.Hide();
            feedbackText.Hide();
            emoji.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            animals[current].stopAnimating();
            animalBox.Image = null;
            animals.RemoveAt(current);
            if (animals.Count == 0)
                return;
            randomAnimal();
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'c')
            {
                scanner.stopScan();
            }
            if (e.KeyChar == 'v')
            {
                scanner.stopScan();
                scanning = false;
                scanner = new Scanner(ref scannerBox);
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            scanner.stopScan();
            if(shouldExit)
                Application.Exit();
        }
    }
}
