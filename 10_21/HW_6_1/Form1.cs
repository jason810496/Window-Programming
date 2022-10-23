using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace F74116720_practice_6_1
{
    public partial class Form1 : Form
    {
        Button[] BtnArr4 = new Button[4];
        Button[] BtnArr8 = new Button[8];
        public static bool IsStart = false;
        public static int CurBPM = 120;
        public static int CurBEAT = 4;
        public static int PI = 4;
        public static int BtnIdx = 0;
        public static double CurInterval = 1000.0*(1.0/(120.0/60.0));
        public static string DingPath= @"../../6-1/audio/ding.wav";
        public static string DongPath = @"../../6-1/audio/dong.wav";
        public static string DooPath = @"../../6-1/audio/doo.wav";
        public static SoundPlayer MusicPlayer = new SoundPlayer();
            
        void LoadBtnArr4()
        {
            int x_size = 50;
            int y_size = 50;
            int span = 50;
            int init_y = 160;
            int x_mid = Width / 2;
            for(int i = 0; i < 4; i++)
            {
                BtnArr4[i] = new Button();
                BtnArr4[i].SetBounds(x_mid - (2-i) * (x_size+span), init_y, x_size, y_size);
                BtnArr4[i].Visible = false;
                BtnArr4[i].BackColor = Color.White;
                Controls.Add(BtnArr4[i]);
            }
        }
        void BtnArr4Off()
        {
            BtnIdx = 0;
            foreach( Button i in BtnArr4)
            {
                i.BackColor = Color.White;
                i.Visible = false;
            }

        }
        void BtnArr4On()
        {
            foreach (Button i in BtnArr4)
            {
                i.Visible = true;
            }
            BtnArr4[0].BackColor = Color.LightGreen;
        }
        void LoadBtnArr8()
        {
            int x_size = 50;
            int y_size = 50;
            int span = 50;
            int init_y = 160;
            int x_mid = Width / 2;
            for (int i = 0; i < 8; i++)
            {
                BtnArr8[i] = new Button();
                BtnArr8[i].SetBounds(x_mid - (4 - i) * (x_size + span), init_y, x_size, y_size);
                BtnArr8[i].Visible = false;
                BtnArr8[i].BackColor = Color.White;
                Controls.Add(BtnArr8[i]);
            }
        }
        void BtnArr8Off()
        {
            BtnIdx = 0;
            foreach (Button i in BtnArr8)
            {
                i.BackColor = Color.White;
                i.Visible = false;
            }
        }
        void BtnArr8On()
        {
            foreach (Button i in BtnArr8)
            {
                i.Visible = true;
            }
            BtnArr8[0].BackColor = Color.LightGreen;
        }
        void PlayDing()
        {
            MusicPlayer.SoundLocation = DingPath;
            MusicPlayer.Load();
            MusicPlayer.Play();
        }
        void PlayShort()
        {
            MusicPlayer.SoundLocation = DongPath;
            MusicPlayer.Load();
            MusicPlayer.Play();
        }
        void PlayLong()
        {
            MusicPlayer.SoundLocation = DongPath;
            MusicPlayer.LoadAsync();
            MusicPlayer.PlaySync();
            MusicPlayer.SoundLocation = DooPath;
            MusicPlayer.LoadAsync();
            MusicPlayer.PlaySync();
        }
        public Form1()
        {
            InitializeComponent();
            BtnImage1.FlatAppearance.BorderSize = 0;
            BtnImage2.FlatAppearance.BorderSize = 0;

            LoadBtnArr4();
            LoadBtnArr8();
            BtnArr4On();

            timer1.Interval = (int)CurInterval;
            timer1.Start();
        }

        private void Radio1_CheckedChanged(object sender, EventArgs e)
        {
            PI = 4;
        }

        private void Radio2_CheckedChanged(object sender, EventArgs e)
        {
            PI = 8;
            
        }

        private void SwitchButton_Click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            if( IsStart )
            {
                IsStart = false;
                Btn.Text = "start";
            }
            else
            {
                IsStart = true;
                Btn.Text = "stop";
            }
        }

        private void Bar_ValueChanged(object sender, EventArgs e)
        {
            int init_val = 5;
            int init_bpm = 120;
            int span = 12;
            TrackBar Bar = (TrackBar)sender;
            int val = Bar.Value;
            CurBPM = (init_val - val) * -span + init_bpm;

            BPMLabel.Text = CurBPM + " BPM";
            // upd interval 
            CurInterval = 1000.0 * (1.0 / (CurBPM / 60.0));
            // upd timer
            timer1.Stop();
            timer1.Interval = (int)CurInterval;
            timer1.Start();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            Console.WriteLine(c.Text);
            int b = int.Parse(c.Text);
            CurBEAT = b;

            if( CurBEAT == 4)
            {
                BtnArr8Off();
                BtnArr4On();
            }
            else
            {
                BtnArr4Off();
                BtnArr8On();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer t = (Timer)sender;
            if( IsStart)
            {
                
                if ( CurBEAT == 4)
                {
                    
                    BtnArr4[BtnIdx++].BackColor = Color.White;
                    BtnIdx %= CurBEAT;
                    BtnArr4[BtnIdx].BackColor = Color.LightGreen;
                }
                else
                {
                    BtnArr8[BtnIdx++].BackColor = Color.White;
                    BtnIdx %= CurBEAT;
                    BtnArr8[BtnIdx].BackColor = Color.LightGreen;
                    
                }


                if (BtnIdx == 0)
                {
                    PlayDing();
                }
                else
                {
                    if (PI == 4)
                    {

                        PlayShort();
                    }
                    else
                    {
                        PlayLong();
                    }
                }
                
            }
        }
    }
}
