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

namespace F74116720_practice_7_1
{
    public partial class Form1 : Form
    {
        // Ask Form obj
        public static Form AskForm = new Form();
        public static Button AskOkBtn = new Button();
        public static Button AskCancelBtn = new Button();
        public static Label AskLabel = new Label();
        public static TextBox AskTxtBox= new TextBox();
        // other
        public static string NewTask;
        public static string Status;
        public static string fileContent;
        public static string filePath;


       string GetCurrentTasks()
        {
            return TxtBox.Text;
        }
        void ResetCurrentTasks()
        {
            TxtBox.Text = "";
        }
        void SetCurrentTasks(string str)
        {
            TxtBox.Text = str;
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
            NewTask = AskTxtBox.Text;
            if( NewTask.Length == 0)
            {
                MessageBox.Show("Please fill in the task name", "Error", MessageBoxButtons.OK);
            }
            else
            {
                AskTxtBox.Text = "";
                AskForm.Close();
                TxtBox.Text += NewTask + "\n";
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

            SetCurrentTasks(fileContent);
            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( Status == "New")
            {
                SaveFileAs();
            }
            else
            {
                FileStream fs = File.OpenWrite(filePath);
                
                byte[] bytes = Encoding.UTF8.GetBytes( GetCurrentTasks() );
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
                byte[] bytes = Encoding.UTF8.GetBytes(GetCurrentTasks());
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
    }
}
