using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Animal
    {
        private bool first = true;
        private bool animating;
        private string animalName;
        private Image[] frames;
        private int framesNumber;
        private System.Media.SoundPlayer soundPlayer;

        public Animal(string name, int frame)
        {
            framesNumber = frame;
            frames = new Image[framesNumber];
            for (int i = 0; i < framesNumber; i++)
            {
                frames[i] = (Image)Properties.Resources.ResourceManager.GetObject(name + i);
            }
            animalName = name;
            animating = false;
            System.IO.Stream soundStream = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(name + "Sound");
            soundPlayer = new System.Media.SoundPlayer(soundStream);
        }

        public Animal(Animal a)
        {
            first = false;
            framesNumber = a.framesNumber;
            frames = new Image[framesNumber];
            for(int i = 0; i < framesNumber; i++)
            {
                frames[i] = a.frames[i];
            }
            animalName = a.animalName;
            animating = false;
            System.IO.Stream soundStream = (System.IO.Stream)Properties.Resources.ResourceManager.GetObject(animalName + "Sound");
            soundPlayer = new System.Media.SoundPlayer(soundStream);
        }

        public async void animate(PictureBox p)
        {
            animating = true;
            for (int i = 0; true; i = (i + 1) % framesNumber)
            {
                if (animating == false) break;
                
                p.Image = (Image)frames[i];

                await Task.Delay(30);
            }
        }

        public void stopAnimating()
        {
            animating = false;
        }

        public bool checkAnswer(string ans)
        {
            return ans == animalName;
        }

        public void playSound()
        {
            soundPlayer.Play();
        }

        public bool getFirst()
        {
            return first;
        }

        public void setFirst(bool f)
        {
            first = f;
        }

        public string getName()
        {
            return animalName;
        }
    }
}
