using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Speech.Synthesis;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp_tamagotchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Icon = Resource2.meet;
            
            textBox.AutoSize = false;
            textBox.Size = new System.Drawing.Size(745, 60);
            SynthesizeSpeechAsync(label1.Text);
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Length > 0)
            {
                Form2 form= new Form2();
                form.Text="My dear "+textBox.Text;
                form.pets_name= textBox.Text;
                this.Hide();
                form.ShowDialog();

                if (!form.reload) System.Windows.Forms.Application.Exit();
                this.Show();
                textBox.Focus();
                textBox.Text = "";
                SynthesizeSpeechAsync(label1.Text);
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
