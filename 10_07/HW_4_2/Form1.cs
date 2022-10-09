using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74116720_practice_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Card
        {
            public string Path { get; set; }
            public bool Back { get; set; }
            public bool End { get; set; }
            public int i { get; set; }
            public int j { get; set; }
            public Card()
            {
                Path = "";
                Back = true;
                End = false;
            }
            public Card(string str, bool back, bool end, int I, int J)
            {
                Path = str;
                Back = back;
                End = end;
                i = I;
                j = J;
            }
        }

        public class CardButton : Button
        {
            public Card Infor { get; set; }
        }

        public static string CardBackPath = @"../../images/card.jpg";
        public static Card[,] CardArr = new Card[4, 4];
        public static List<KeyValuePair<int, int>> UserEvent = new List<KeyValuePair<int, int>>();
        public static bool GameStart = false;
        public static CardButton[,] ButtonObjectArr = new CardButton[4, 4];
        public static int CountLast = 8;
        public static int Score = 100;
        public static int MINUS = 5;
        public static int PLUS = 10;
        public static int RUNTIME = 0;
        public static List<KeyValuePair<string, int>> DB = new List<KeyValuePair<string, int>>();

        public void CardsPermutation()
        {
            // construct image path 
            string[] ImagePathArray = new string[8];
            for (int i = 1; i <= 8; i++)
            {
                ImagePathArray[i - 1] = @"../../images/0" + i + ".jpg";
            }

            int[] IdxArr = new int[16];
            for (int i = 0; i < 16; i++)
            {
                IdxArr[i] = i % 8;
            }
            // shuffle idx array
            Random random = new Random();
            IdxArr = IdxArr.OrderBy(x => random.Next()).ToArray();
            /*Console.WriteLine("new per: ");
            foreach( int i in IdxArr)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine(IdxArr);*/

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if( RUNTIME == 1)
                    {
                        CardArr[i, j] = new Card(ImagePathArray[IdxArr[i * 4 + j]], true, false, i, j);

                    }
                    else
                    {
                        CardArr[i, j].Path = ImagePathArray[IdxArr[i * 4 + j]];
                    }
                }
            }
        }


        public void CheckStatus()
        {
            if (UserEvent.Count < 2) return;

            int i1 = UserEvent[0].Key;
            int j1 = UserEvent[0].Value;
            int i2 = UserEvent[1].Key;
            int j2 = UserEvent[1].Value;

            Console.WriteLine("Bug : ");
            foreach( KeyValuePair<int,int> i in UserEvent)
            {
                Console.Write("("+i.Key + ", " + i.Value + ") ");
            }
            Console.WriteLine();

            if (CardArr[i1, j1].Path == CardArr[i2, j2].Path)
            {
                ButtonObjectArr[i1, j1].Enabled = false;
                ButtonObjectArr[i2, j2].Enabled = false;
                UserEvent.Clear();
                CountLast--;
                Score += PLUS ;
            }
            else
            {
                Score -= MINUS;
            }

            // update score status
            UpdateScoreLabel();

            ContinueButton.Enabled = true;

            if (CountLast == 0)
            {

                // add to history
                DB.Add(new KeyValuePair<string, int>(UserTextBox.Text, Score));
                // add to history page
                HistoryTestBox.Text += UserTextBox.Text + " scored : " + Score + "\n\n";

                var UserOpt  =  MessageBox.Show("Score : " + Score , "Game End" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Information );
                if( UserOpt == DialogResult.Retry)
                {
                    // restart game 
                    ResetGame();
                }
                else // cancel : Only close message box 
                {

                }
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            CardButton btn = (CardButton)sender;
            UserEvent.Add(new KeyValuePair<int, int>(btn.Infor.i, btn.Infor.j));
            if (btn.Infor.Back)
            {
                btn.Image = Image.FromFile(btn.Infor.Path);
            }
            else
            {
                btn.Image = Image.FromFile(CardBackPath);
            }
            btn.Infor.Back = !btn.Infor.Back;

            CheckStatus();
        }
        public void ResetButton(ref CardButton btn)
        {
            btn.Image = Image.FromFile(CardBackPath);
            if (RUNTIME == 1)
            {
                btn.Click += Card_Click;
            }
            btn.Infor.Back = true;
            btn.Infor.End = false;
            btn.Enabled = true;
        }

        public void LoadButtonsArray()
        {
            int N = 4, M = 4;
            int posX = 80, posY = 60;
            int sizeX = 60, sizeY = 80;
            int spanX = sizeX + 5, spanY = sizeY + 5;

            // new permutation 
            CardsPermutation();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if( RUNTIME == 1)
                    {
                        ButtonObjectArr[i, j] = new CardButton();
                        ButtonObjectArr[i, j].SetBounds(posX + i * spanX, posY + j * spanY, sizeX, sizeY);//(starting point X, starting point Y, width, heighth)
                                                                                                          //ButtonObjectArr[i,j].Text = i + "," + j ;
                        ButtonObjectArr[i, j].Infor = CardArr[i, j];
                        ResetButton(ref ButtonObjectArr[i, j]);

                        GameAreaTab.Controls.Add(ButtonObjectArr[i, j]);
                    }
                    else
                    {
                        ButtonObjectArr[i, j].Infor = CardArr[i, j];
                        ResetButton(ref ButtonObjectArr[i, j]);
                    }
                   
                }

            }
        }

        public void UpdateScoreLabel()
        {
            ScoreLabel.Text = "Score : " + Score.ToString();
        }

        public void ResetGame()
        {
            RUNTIME++;
            UserEvent.Clear();
            LoadButtonsArray();
            Score = 100;
            CountLast = 8;
            GameStart = false;
            UpdateScoreLabel();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            String str = UserTextBox.Text;
            if( str.Length == 0)
            {
                MessageBox.Show("Username should not be blank" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
            else if( str.Length < 3 || str.Length > 10)
            {
                MessageBox.Show("Incorrect username format\n( >= 3 && <= 10 )", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                ResetGame();
                GameStart = !GameStart;
                Button btn = (Button)sender;
                btn.Enabled = false;
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {

            ContinueButton.Enabled = false;

            foreach (KeyValuePair<int, int> v in UserEvent)
            {
                ButtonObjectArr[v.Key, v.Value].Image = Image.FromFile(CardBackPath);
                ButtonObjectArr[v.Key, v.Value].Infor.Back = true;
            }
            UserEvent.Clear();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            var UserOpt = MessageBox.Show("Are you sure you want to quit the game ?" , "Quit Game" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
            if( UserOpt == DialogResult.Yes)
            {
                Application.Exit();
            }

            
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
