using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74116720_practice_4_1
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
            public Card(string str , bool back , bool end ,int I,int J)
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

        public void CardsPermutation()
        {
            // construct image path 
            string[] ImagePathArray = new string[8];
            for (int i = 1; i <= 8; i++)
            {
                ImagePathArray[i - 1] = @"../../images/0" + i + ".jpg";
            }

            int[] IdxArr = new int[16];
            for(int i = 0; i < 16; i++)
            {
                IdxArr[i] = i % 8;
            }
            // shuffle idx array
            Random random = new Random();
            IdxArr = IdxArr.OrderBy(x => random.Next()).ToArray();

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    CardArr[i, j] = new Card(ImagePathArray[IdxArr[i * 4 + j]],true,false,i,j);
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

            if ( CardArr[i1,j1].Path == CardArr[i2,j2].Path )
            {
                ButtonObjectArr[i1, j1].Enabled = false;
                ButtonObjectArr[i2, j2].Enabled = false;
                UserEvent.Clear();
                CountLast--;
            }

            ContinueButton.Enabled = true;

            if( CountLast == 0){
                MessageBox.Show("You Won!");
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
            else {
                btn.Image = Image.FromFile(CardBackPath);
            }
            btn.Infor.Back = !btn.Infor.Back;

            CheckStatus();
        }
        public void ResetButton( ref CardButton btn)
        {
            btn.Image = Image.FromFile(CardBackPath);
            btn.Click += Card_Click;
            btn.Enabled = false;
        }
       
        private void LoadButtonsArray(object sender, EventArgs e)
        {
            int N = 4, M = 4;
            int posX = 80, posY = 60;
            int sizeX = 60, sizeY = 80;
            int spanX = sizeX+5 , spanY = sizeY + 5 ;
           

            CardsPermutation();

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < M; j++)
                {
                    ButtonObjectArr[i,j] = new CardButton();
                    ButtonObjectArr[i,j].SetBounds( posX + i*spanX ,  posY + j*spanY , sizeX, sizeY);//(starting point X, starting point Y, width, heighth)
                    //ButtonObjectArr[i,j].Text = i + "," + j ;
                    ButtonObjectArr[i, j].Infor = CardArr[i, j];
                    ResetButton(ref ButtonObjectArr[i, j] );

                    Controls.Add(ButtonObjectArr[i, j]);
                }
                
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            foreach (CardButton i in ButtonObjectArr)
            {
                i.Enabled = true;
            }
            GameStart = !GameStart;
            Button btn = (Button)sender;
            btn.Enabled = false;
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            
            ContinueButton.Enabled = false;

            foreach(KeyValuePair<int,int> v in UserEvent)
            {
                ButtonObjectArr[v.Key, v.Value].Image = Image.FromFile(CardBackPath);
                ButtonObjectArr[v.Key, v.Value].Infor.Back = true;
            }
            UserEvent.Clear();
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
