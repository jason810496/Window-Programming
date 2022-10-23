using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace F74116720_practice_6_2
{

    public partial class Form1 : Form
    {
        Button[] BtnArr = new Button[15];

        const string ON_PHO = "📱";
        const string OFF_PHO = "📵";
        const string Path697 = @"../../audio/697.wav";
        const string Path770 = @"../../audio/770.wav";
        const string Path852 = @"../../audio/852.wav";
        const string Path941 = @"../../audio/941.wav";
        const string Path1209 = @"../../audio/1209.wav";
        const string Path1336 = @"../../audio/1336.wav";
        const string Path1477 = @"../../audio/1477.wav";

        public static List<string> DB = new List<string>();
        public static SoundPlayer MusicPlayer = new SoundPlayer();
        void LoadBtn()
        {
            int init_x = 170;
            int init_y = 80;
            int span_x = 10;
            int span_y = 10;
            int wt = 50;
            int ht = 50;
            for(int i = 0; i < 15; i++)
            {
                BtnArr[i] = new Button();
                BtnArr[i].Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                if (i < 9)
                {
                    BtnArr[i].Text = (i + 1).ToString();
                }
                if( i<12)
                {
                    BtnArr[i].Click += new EventHandler(this.NormalClick);
                }
                BtnArr[i].SetBounds(init_x + (wt+span_x) * (i % 3), init_y + (ht+span_y) * (i / 3) + span_y,wt,ht);
            }
            BtnArr[9].Text = "*";
            BtnArr[10].Text = "0";
            BtnArr[11].Text = "#";
            BtnArr[12].Text = "❌";
            BtnArr[12].Click += new EventHandler(this.DeleteAll);
            BtnArr[13].Text = ON_PHO;
            BtnArr[13].Click += new EventHandler(this.PhoneClick);
            BtnArr[14].Text = "⬅️";
            BtnArr[14].Click += new EventHandler(this.DeleteOne);


            foreach ( Button i in BtnArr)
            {
                TelePage.Controls.Add(i );
            }
        }
        public Form1()
        {
            InitializeComponent();
            LoadBtn();
        }
        // Telephone button click event 
        void DeleteOne(object sender,EventArgs e)
        {
            string str = TeleLabel.Text;
            if (str.Length == 0) return;

            TeleLabel.Text = str.Substring(0,str.Length-1);
        }
        void DeleteAll(object sender, EventArgs e)
        {
            TeleLabel.Text = "";
        }
        void PhoneClick(object sender, EventArgs e)
        {
            if( BtnArr[13].Text == ON_PHO)
            {
                DB.Add(TeleLabel.Text);
                richTextBox1.Text += TeleLabel.Text + "\n";
                BtnArr[13].Text = OFF_PHO;
            }
            else
            {
                TeleLabel.Text = "Telephone";
                BtnArr[13].Text = ON_PHO;
            }
        }
        void NormalClick(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            string res = TeleLabel.Text + str;
            TeleLabel.Text = res;

            if( str=="0")
            {
                PlayAudio(3, 1);
            }
            else if( str=="1")
            {
                PlayAudio(0,0);
            }
            else if(str == "2")
            {
                PlayAudio(0,1);
            }
            else if (str == "3")
            {
                PlayAudio(0,2);
            }
            else if( str =="4")
            {
                PlayAudio(1,0);
            }
            else if( str =="5")
            {
                PlayAudio(1,1);
            }
            else if (str == "6")
            {
                PlayAudio(1,2);
            }
            else if (str == "7")
            {
                PlayAudio(2,0);
            }
            else if (str == "8")
            {
                PlayAudio(2,1);
            }
            else if (str == "9")
            {
                PlayAudio(2,2);
            }
            else if( str == "*")
            {
                PlayAudio(2, 0);
            }
            else if( str == "#")
            {
                PlayAudio(2, 2);
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string path = PathTextBox.Text;
            if( path.Length == 0)
            {
                MessageBox.Show("Empty String", "Error", MessageBoxButtons.OK);
            }
            else
            {
                File.WriteAllText(path, richTextBox1.Text);
                MessageBox.Show("Done\n"+path, "Successful", MessageBoxButtons.OK);
            }
            
        }

        void PlayAudio(int i,int j)
        {
            if( i == 0)
            {
                MusicPlayer.SoundLocation = Path697;
                MusicPlayer.Load();
                MusicPlayer.Play();
                if (j == 0)
                { 
                    MusicPlayer.SoundLocation = Path1209;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 1)
                {
                    MusicPlayer.SoundLocation = Path1336;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if(j ==2)
                {
                    MusicPlayer.SoundLocation = Path1477;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
            }
            else if( i== 1)
            {
                MusicPlayer.SoundLocation = Path770;
                MusicPlayer.Load();
                MusicPlayer.Play();
                if (j == 0)
                {
                    MusicPlayer.SoundLocation = Path1209;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 1)
                {
                    MusicPlayer.SoundLocation = Path1336;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 2)
                {
                    MusicPlayer.SoundLocation = Path1477;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
            }
            else if(i == 2)
            {
                MusicPlayer.SoundLocation = Path852;
                MusicPlayer.Load();
                MusicPlayer.Play();
                if (j == 0)
                {
                    MusicPlayer.SoundLocation = Path1209;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 1)
                {
                    MusicPlayer.SoundLocation = Path1336;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 2)
                {
                    MusicPlayer.SoundLocation = Path1477;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
            }
            else if (i == 3)
            {
                MusicPlayer.SoundLocation = Path941;
                MusicPlayer.Load();
                MusicPlayer.Play();
                if (j == 0)
                {
                    MusicPlayer.SoundLocation = Path1209;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 1)
                {
                    MusicPlayer.SoundLocation = Path1336;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
                else if (j == 2)
                {
                    MusicPlayer.SoundLocation = Path1477;
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                }
            }
        }
        

        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (Tab.SelectedIndex == 1) return;

            if( e.Modifiers == Keys.Shift)
            {
                if( e.KeyCode == Keys.D3)
                {
                    TeleLabel.Text = TeleLabel.Text + "#";
                    PlayAudio(3, 2);
                }
                else if( e.KeyCode == Keys.D8)
                {
                    TeleLabel.Text = TeleLabel.Text + "*";
                    PlayAudio(3, 0);
                }
            }
            else if( e.KeyCode == Keys.Enter)
            {
                if (BtnArr[13].Text == ON_PHO)
                {
                    DB.Add(TeleLabel.Text);
                    richTextBox1.Text += TeleLabel.Text + "\n";
                    BtnArr[13].Text = OFF_PHO;
                }
                else
                {
                    TeleLabel.Text = "Telephone";
                    BtnArr[13].Text = ON_PHO;
                }
            }
            else if( e.KeyCode == Keys.Back)
            {
                string str = TeleLabel.Text;
                if (str.Length != 0)
                {
                    TeleLabel.Text = str.Substring(0, str.Length - 1);
                }
            }
            else if( e.KeyCode>= Keys.D0 && e.KeyCode<=Keys.D9)
            {
                TeleLabel.Text = TeleLabel.Text + ((char)e.KeyCode).ToString();
                if( e.KeyCode == Keys.D0)
                {
                    PlayAudio(3, 1);
                }
                else if (e.KeyCode == Keys.D1)
                {
                    PlayAudio(0,0);
                }
                else if (e.KeyCode == Keys.D2)
                {
                    PlayAudio(0, 1);
                }
                else if (e.KeyCode == Keys.D3)
                {
                    PlayAudio(0, 2);
                }
                else if (e.KeyCode == Keys.D4)
                {
                    PlayAudio(1, 0);
                }
                else if (e.KeyCode == Keys.D5)
                {
                    PlayAudio(1, 1);
                }
                else if (e.KeyCode == Keys.D6)
                {
                    PlayAudio(1, 2);
                }
                else if (e.KeyCode == Keys.D7)
                {
                    PlayAudio(2, 0);
                }
                else if (e.KeyCode == Keys.D8)
                {
                    PlayAudio(2, 1);
                }
                else if (e.KeyCode == Keys.D9)
                {
                    PlayAudio(2, 2);
                }
            }
        }
        
    }
}
