using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74116720_practice_5_1
{
    public partial class Form1 : Form
    {
        string Word;
        int WordSize = 0;
        int CountMiss = 0;
        int CURRENT = 0;
        bool GAME_START = false;
        Button[] BtnArr = new Button[26];
        Label[] LabelArr;

        public void InitButtonArr()
        {
            int width = 40;
            int height = 60;
            int posX = 50;
            int posY = 20;
            int span = 15;
            for(int i = 0; i < 26; i++)
            {
                BtnArr[i] = new Button();
                string s = ((char)(65 + i)).ToString();
                BtnArr[i].Text = s;
                BtnArr[i].SetBounds(posX + (i%13) * width + span, posY + height + span + (i / 13) * height , width, height);
                BtnArr[i].Visible = false;
                Controls.Add(BtnArr[i]);
            }
        }

        public void LoadButtonArr()
        {
            for(int i = 0; i < 26; i++)
            {
                BtnArr[i].Visible = true;
            }
        }
        public void RemoveButtonArr()
        {
            foreach(Button btn in BtnArr)
            {
                btn.BackColor = Color.White;
                btn.Visible = false;
            }
        }
        public void LoadLetter()
        {
            int posY = 300;
            int ht = 60;
            int wt = 20;
            int posX = Width / 2 - wt * WordSize /2   ;
            
            LabelArr = new Label[WordSize];
            for(int i = 0; i < WordSize; i++)
            {
                LabelArr[i] = new Label();
                LabelArr[i].Text = new String('_', 1);
                LabelArr[i].Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                LabelArr[i].SetBounds(posX + wt * i, posY, wt, ht );

                Controls.Add(LabelArr[i]);
            }
        }
        public void ResetGame()
        {
            Console.Write("RESET");
            Console.WriteLine(StartTextBox.Text);
            StartTextBox.Text = "";
            Word = "";
            WordSize = 0;
            CountMiss = 0;
            GAME_START = false;
            CURRENT = 0;
            timer1.Stop();
            TimeLabel.Text = "Time : ";
            MissLabel.Text = "Miss : ";

            // menu obj 
            StartButton.Visible = true;
            StartButton.Enabled = true;
            StartLabel.Visible = true;
            StartLabel.Enabled = true;
            //StartTextBox.Visible = false;
            //StartTextBox.Enabled = false;
            StartTextBox.Left += 1000;
            // game obj
            TimeLabel.Visible = false;
            MissLabel.Visible = false;

            RemoveButtonArr();
            foreach(Label l in LabelArr)
            {
                l.Text = "_";
                l.Visible = false;
            }
        }
        public void GameStart()
        {
            Word = StartTextBox.Text;
            Word = Word.ToUpper();
            WordSize = Word.Length;
            GAME_START = true;
            timer1.Start();

            LoadButtonArr();

            // menu obj 
            StartButton.Visible = false;
            StartButton.Enabled = false;
            StartLabel.Visible = false;
            StartLabel.Enabled = false;
            //StartTextBox.Visible = false;
            //StartTextBox.Enabled = false;
            StartTextBox.Left -= 1000;
            // game obj
            TimeLabel.Visible = true;
            MissLabel.Visible = true;

            // load letter 
            LoadLetter();
            // add keypress event 
        }
        public Form1()
        {
            InitializeComponent();
            InitButtonArr();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameStart();
        }

        private void StartTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            Console.WriteLine(c);

            bool done = false;

            if ( ! ('a' <= c && c <= 'z' || 'A' <= c && c <= 'Z') ) 
            {
                e.Handled = true;
            }
            else
            {
                if( GAME_START )
                {
                    StartTextBox.Text = "";
                    string cur = new string(c, 1);
                    cur = cur.ToUpper();
                    
                    if( Word.Contains(cur))
                    {
                        for(int i = 0; i < WordSize; i++)
                        {
                            
                            if( Word[i] == cur[0] )
                            {
                                LabelArr[i].Text = cur;
                                BtnArr[cur[0] - 'A'].BackColor = Color.LightGreen;
                                
                            }
                            
                        }
                    }
                    else if (BtnArr[cur[0] - 'A'].Visible)
                    {
                        BtnArr[cur[0] - 'A'].Visible = false;
                        CountMiss++;
                        // upd count miss label 
                        MissLabel.Text = "Miss : " + CountMiss;
                    }

                     // lose
                    if( CountMiss >= 6)
                    {
                        timer1.Stop();
                        DialogResult opt = MessageBox.Show("You lose !", "OAO", MessageBoxButtons.OK);
                        if( opt == DialogResult.OK ) ResetGame();

                        done = true;
                    }

                    // check all label status
                    bool flag = true;
                    foreach(Label l in LabelArr)
                    {
                        if( l.Text == "_")
                        {
                            flag = false;
                            break;
                        }
                    }

                    // win 
                    if( flag)
                    {
                        StartTextBox.Text = "";
                        timer1.Stop();
                        DialogResult opt = MessageBox.Show("Total Time : "+CURRENT+"\nMiss : "+CountMiss, "OuO", MessageBoxButtons.OK);
                        if (opt == DialogResult.OK) ResetGame();

                        done = true;
                    }
                }
            }

            if (done) e.Handled = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.Write("Timer");
            CURRENT++;
            TimeLabel.Text = "Time : " + CURRENT;
        }
    }
}
