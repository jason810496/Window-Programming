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

namespace F74116720_practice_7_2
{
    public partial class Form1 : Form
    {
        // Ask Form obj
        public static Form AskForm = new Form();
        public static Button AskOkBtn = new Button();
        public static Button AskCancelBtn = new Button();
        public static Label AskLabel = new Label();
        public static TextBox AskTxtBox = new TextBox();
        // other
        public static string NewTask;
        public static string Status;
        public static string fileContent;
        public static string filePath;
        public static string AddOrFinish;
        public static bool ShowCompleted = true;
        public static List<KeyValuePair<bool,string> > DB = new List<KeyValuePair<bool, string> >();


        string Prefix(bool b)
        {
            if ( !b ) return " [ ] ";
            return " [√] ";
        }
        string GetFileTasks()
        {
            string result = "";
            foreach (KeyValuePair<bool, string> P in DB)
            {
                result += (P.Key ? "+":"-") + P.Value + "\n";
            }
            return result;
        }
        string GetShowTasks()
        {
            string result="";
            foreach (KeyValuePair<bool,string> P in DB) {
                if (!ShowCompleted && P.Key) continue;
                result += Prefix(P.Key) + P.Value + "\n";
            }
            return result;
        }
        void ResetCurrentTasks()
        {
            TxtBox.Text = "";
            DB.Clear();
        }
        void SetCurrentTasks(string s)
        {
            string[] arr = s.Split('\n');
            DB.Clear();
            foreach( string str in arr ){
                Console.WriteLine(str);
                if (str.Length == 0) continue;
                DB.Add(new KeyValuePair<bool, string>( (str[0]=='+') , str.Substring(1,str.Length-1) ) );
            }
            
            TxtBox.Text = GetShowTasks();
        }

        public Form1()
        {
            InitializeComponent();
            /* Ask form  */
            // event handler
            AskForm.FormClosing += AskForm_FormClosing;
            AskForm.ClientSize = new System.Drawing.Size(800, 200);

            // obj init
            AskLabel.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            AskLabel.Location = new System.Drawing.Point(50, 50);
            AskLabel.Size = new System.Drawing.Size(100, 50);
            AskLabel.Text = "Event Name";

            AskTxtBox.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            AskTxtBox.Location = new System.Drawing.Point(150, 50);
            AskTxtBox.Size = new System.Drawing.Size(580, 50);

            AskOkBtn.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            AskOkBtn.Location = new System.Drawing.Point(630, 120);
            AskOkBtn.Size = new System.Drawing.Size(100, 35);
            AskOkBtn.Text = "Confirm";
            AskOkBtn.Click += AskOkBtn_Click;

            AskCancelBtn.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            AskCancelBtn.Location = new System.Drawing.Point(520, 120);
            AskCancelBtn.Size = new System.Drawing.Size(100, 35);
            AskCancelBtn.Text = "Cancel";
            AskCancelBtn.Click += AskCalcelBtn_Click;

            AskForm.Controls.Add(AskLabel);
            AskForm.Controls.Add(AskTxtBox);
            AskForm.Controls.Add(AskOkBtn);
            AskForm.Controls.Add(AskCancelBtn);
        }

        private void AskOkBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(AddOrFinish);

            if( AddOrFinish == "AddTaskBtn" || AddOrFinish == "addTaskToolStripMenuItem" )
            {
                NewTask = AskTxtBox.Text;
                if (NewTask.Length == 0)
                {
                    MessageBox.Show("Please fill in the task name", "Error", MessageBoxButtons.OK);
                }
                else
                {

                    AskTxtBox.Text = "";
                    AskForm.Close();
                    DB.Add(new KeyValuePair<bool, string>(false,NewTask));
                    TxtBox.Text = GetShowTasks();
                }
            }
            else if(AddOrFinish == "FinishTaskBtn" || AddOrFinish == "finishTaskToolStripMenuItem" )
            {
                NewTask = AskTxtBox.Text;
                AskTxtBox.Text = "";
                int idx = 0;
                for(;idx< DB.Count; idx++)
                {
                    if( DB[idx].Value == NewTask)
                    {
                        break;
                    }
                }

                if( idx != DB.Count)
                {
                    DB[idx] = new KeyValuePair<bool, string>(true, DB[idx].Value);
                    // update result 
                    TxtBox.Text = GetShowTasks();
                }

                
                AskForm.Close();
            }
            else if(AddOrFinish == "deleteToolStripMenuItem")// delete
            {
                NewTask = AskTxtBox.Text;
                AskTxtBox.Text = "";
                int idx = 0;
                for (; idx < DB.Count; idx++)
                {
                    if (DB[idx].Value == NewTask)
                    {
                        break;
                    }
                }

                if (idx != DB.Count)
                {
                    DB.RemoveAt(idx);
                    // update result 
                    TxtBox.Text = GetShowTasks();
                }

                AskForm.Close();
            }
            else // search
            {
                SearchBtn.Visible = true;
                menuStrip1.Enabled = false;

                NewTask = AskTxtBox.Text;
                AskTxtBox.Text = "";

                string res="";
                
                for(int i = 0; i < DB.Count; i++)
                {
                    if( DB[i].Value.Contains(NewTask) )
                    {
                        if (!ShowCompleted && DB[i].Key) continue;
                        res += Prefix(DB[i].Key) + DB[i].Value + "\n";
                    }
                }

                TxtBox.Text = res;

                AskForm.Close();
            }
           
        }
        private void AskCalcelBtn_Click(object sender, EventArgs e)
        {
            NewTask = "";
            AskTxtBox.Text = "";
            AskForm.Close();
        
        }
        private void AskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Enabled = true;
            AskForm.Hide();
        }


        private void AddTaskBtn_Click(object sender, EventArgs e)
        {

            AddOrFinish = ((Button)sender).Name;
            this.Enabled = false;
            AskForm.Show();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = ((ToolStripMenuItem)sender).Text;
            ResetCurrentTasks();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status = ((ToolStripMenuItem)sender).Text;

            fileContent = string.Empty;
            filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Todo files (*.todo)|*.todo|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            Console.WriteLine("Open : \n" + fileContent);
            SetCurrentTasks(fileContent);
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Status == "New")
            {
                SaveFileAs();
            }
            else
            {
                FileStream fs = File.OpenWrite(filePath);

                byte[] bytes = Encoding.UTF8.GetBytes(GetFileTasks());
                fs.Write(bytes, 0, bytes.Length);
            }
        }

        void SaveFileAs()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Todo files (*.todo)|*.todo|txt files (*.txt)|*.txt";
            saveFileDialog1.Title = "Save Todo List";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {

                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                byte[] bytes = Encoding.UTF8.GetBytes(GetFileTasks());
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1: // todo
                        fs.Write(bytes, 0, bytes.Length);
                        break;

                    case 2: // txt
                        fs.Write(bytes, 0, bytes.Length);
                        break;

                }

                fs.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                TxtBox.Font = f.Font;
            }
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            AddOrFinish = ((Button)sender).Name;
            this.Enabled = false;
            AskForm.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrFinish = ((ToolStripMenuItem)sender).Name;
            this.Enabled = false;
            AskForm.Show();

            AddTaskBtn.Visible = false;
            FinishTaskBtn.Visible = false;
        }

        private void addTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrFinish = ((ToolStripMenuItem)sender).Name;
            this.Enabled = false;
            AskForm.Show();
        }

        private void finishTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrFinish = ((ToolStripMenuItem)sender).Name;
            this.Enabled = false;
            AskForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrFinish = ((ToolStripMenuItem)sender).Name;
            this.Enabled = false;
            AskForm.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visible = false;
            menuStrip1.Enabled = true;

            AddTaskBtn.Visible = true;
            FinishTaskBtn.Visible = true;

            TxtBox.Text = GetShowTasks();
        }

        private void showCompletedTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompleted = true;
            TxtBox.Text = GetShowTasks();
        }

        private void hideCompletedTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCompleted = false;
            TxtBox.Text = GetShowTasks();
        }
    }
}