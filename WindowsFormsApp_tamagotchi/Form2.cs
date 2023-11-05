using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace WindowsFormsApp_tamagotchi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            a.Start();
            this.Icon = Resource2.meet;
            skins[0]= Resource2.dirty; 
            skins[1]= Resource2.hungry;
            skins[2]= Resource2.walk;
            skins[3]= Resource2.play;
            skins[4]= Resource2.sick;
            skins[5]= Resource2.sleep;
            skins[6]= Resource2._happy;
            skins[7]= Resource2._died;

            pictures[0] = pictureBox_dirty;
            pictures[1] = pictureBox_hungry;
            pictures[2] = pictureBox_walk;
            pictures[3] = pictureBox_play;
            pictures[4] = pictureBox_sick;
            pictures[5] = pictureBox_sleep;

            buttons[0] = button_wash;
            buttons[1] = button_feed;
            buttons[2] = button_walk;
            buttons[3] = button_play;
            buttons[4] = button_heal;
            buttons[5] = button_sleep;

            foreach (PictureBox picture in pictures)
            {
                picture.Visible= false;
            }

                       
            a.Interval = 15000;
            a.Tick += new EventHandler(TimerEventProcessor);

            SynthesizeSpeechAsync(label_name.Text);
            SkinChange();

        }
        private void SkinChange()
        {
            
            if (needs[4])
            {
                pictureBox_hero.Image = skins[4];
                return;
            }
            if (needs[5])
            {
                pictureBox_hero.Image = skins[5];
                return;
            }
            if (needs[2])
            {
                pictureBox_hero.Image = skins[2];
                return;
            }
            if (needs[5])
            {
                pictureBox_hero.Image = skins[5];
                return;
            }
            if (needs[1])
            {
                pictureBox_hero.Image = skins[1];
                return;
            }
            if (needs[0])
            {
                pictureBox_hero.Image = skins[0];
                return;
            }
            if (needs[3])
            {
                pictureBox_hero.Image = skins[3];
                return;
            }
            pictureBox_hero.Image = skins[6];

        }

        public Timer a = new Timer();
        private void TimerEventProcessor(Object sender, EventArgs e)
        {
            //перевірка на смерть
            if (needs[4])
            {
                a.Stop();
                foreach (Button button in buttons)
                {
                    button.Enabled = false;
                }
                foreach (PictureBox pic in pictures)
                {
                    pic.Visible = false;
                }
                pictureBox_hero.Image = skins[7];
                label_name.Text = "Our condolences for your loss.....";
                SynthesizeSpeechAsync(pets_name+" is dead. Our condolences for your loss.....");
                return;
            }
            int count = 0;
            foreach (bool need in needs)
            {
                if (need) count++;
            }
            if (count > 2)
            {
                needs[4] = true;
                pictureBox_hero.Image = skins[4];
                pictures[4].Visible= true;
                SynthesizeSpeechAsync(sounds[4]);
                
                return;
            }

            Random random= new Random();
            int ind = -1;
            int i;
            while (ind < 0)
            {
                i = random.Next() % 6;
                if (needs[i]) continue;
                ind = i;
                break;
            }
            needs[ind]=true;
            pictureBox_hero.Image = skins[ind];
            pictures[ind].Visible = true;
            SynthesizeSpeechAsync(sounds[ind]);
        }
        private async Task SynthesizeSpeechAsync(string text)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            foreach (InstalledVoice voice in synthesizer.GetInstalledVoices())
            {
                //Console.WriteLine(voice.VoiceInfo.Culture.Name);
                if (voice.VoiceInfo.Culture.Name == "en-US")
                {
                    synthesizer.SelectVoice(voice.VoiceInfo.Name);
                    //Console.WriteLine("us-Us");
                    break;

                }
            }
            await Task.Run(() => synthesizer.Speak(text));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            reload = true;
            Close();

        }

        private void button_wash_Click(object sender, EventArgs e)
        {
            pictures[0].Visible= false;
            needs[0] = false;
            //зміна вигляду
            SkinChange();
        }

        private void button_feed_Click(object sender, EventArgs e)
        {
            pictures[1].Visible = false;
            needs[1] = false;
            //зміна вигляду
            SkinChange();
        }

        private void button_walk_Click(object sender, EventArgs e)
        {
            pictures[2].Visible = false;
            needs[2] = false;
            //зміна вигляду
            SkinChange();
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            pictures[3].Visible = false;
            needs[3] = false;
            //зміна вигляду
            SkinChange();
        }

        private void button_heal_Click(object sender, EventArgs e)
        {
            pictures[4].Visible = false;
            needs[4] = false;
            //зміна вигляду
            SkinChange();
        }

        private void button_sleep_Click(object sender, EventArgs e)
        {
            pictures[5].Visible = false;
            needs[5] = false;
            //зміна вигляду
            SkinChange();
        }
    }
}
