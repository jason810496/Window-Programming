using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F74116720_practice_3_1
{
    public partial class Form1 : Form
    {

        public class Account
        {
            public string link, user, pass;
            public Account(string _link, string _user, string _pass)
            {
                link = _link;
                user = _user;
                pass = _pass;
            }
        }

        public static bool SearchMode = true;
        public static List<Account> DB = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }


        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            string str = SearchTextBox.Text;
            string result = "";

            if (str.Length == 0)
            {
                foreach (Account i in DB)
                {
                    result += "Link : " + i.link + "\nUser : " + i.user + "\nPassword : " + i.pass + "\n";
                    result += "###############################\n";
                }
            }
            else
            {
                foreach (Account i in DB)
                {
                    if (i.link.Contains(str))
                    {
                        result += "Link : " + i.link + "\nUser : " + i.user + "\nPassword : " + i.pass + "\n";
                        result += "###############################\n";
                    }
                }
            }

            SearchResultTextBox.Text = result;
        }

        private void SearchOn()
        {

            SearchButton.Visible = true;
            SearchButton.Enabled = true;
            SearchTextBox.Visible = true;
            SearchTextBox.Enabled = true;
            SearchLabel.Visible = true;
            SearchLabel.Enabled = true;
            RiskyAccountButton.Visible = true;
            RiskyAccountButton.Enabled = true;
            SearchResultLabel.Visible = true;
            SearchResultLabel.Enabled = true;
            SearchResultTextBox.Visible = true;
            SearchResultTextBox.Enabled = true;
        }
        private void SearchOff()
        {

            SearchButton.Visible = false;
            SearchButton.Enabled = false;
            SearchTextBox.Visible = false;
            SearchTextBox.Enabled = false;
            SearchLabel.Visible = false;
            SearchLabel.Enabled = false;
            RiskyAccountButton.Visible = false;
            RiskyAccountButton.Enabled = false;
            SearchResultLabel.Visible = false;
            SearchResultLabel.Enabled = false;
            SearchResultTextBox.Visible = false;
            SearchResultTextBox.Enabled = false;
        }
        private void AddDeleteOn()
        {
            AddOrDeleteButton.Text = "Retuen to Menu";
            StatusBar.Visible = true;
            StatusBar.Enabled = true;
            LinkTextBox.Visible = true;
            LinkTextBox.Enabled = true;
            LinkLabel.Visible = true;
            LinkLabel.Enabled = true;
            UserTextBox.Visible = true;
            UserTextBox.Enabled = true;
            UserLabel.Visible = true;
            UserLabel.Enabled = true;
            PassTextBox.Visible = true;
            PassTextBox.Enabled = true;
            PassLabel.Visible = true;
            PassLabel.Enabled = true;
            AddButton.Visible = true;
            AddButton.Enabled = true;
            DeleteButton.Visible = true;
            DeleteButton.Enabled = true;
        }
        private void AddDeleteOff()
        {
            AddOrDeleteButton.Text = "Add or Delete";
            StatusBar.Visible = false;
            StatusBar.Enabled = false;
            LinkTextBox.Visible = false;
            LinkTextBox.Enabled = false;
            LinkLabel.Visible = false;
            LinkLabel.Enabled = false;
            UserTextBox.Visible = false;
            UserTextBox.Enabled = false;
            UserLabel.Visible = false;
            UserLabel.Enabled = false;
            PassTextBox.Visible = false;
            PassTextBox.Enabled = false;
            PassLabel.Visible = false;
            PassLabel.Enabled = false;
            AddButton.Visible = false;
            AddButton.Enabled = false;
            DeleteButton.Visible = false;
            DeleteButton.Enabled = false;
        }
        private void SwitchMode(object sender, EventArgs e)
        {
            if (SearchMode)
            {
                SearchOff();
                AddDeleteOn();
            }
            else
            {
                SearchOn();
                AddDeleteOff();
            }
            SearchMode = !SearchMode;
        }

        public bool UserInDB(string new_link, string new_user)
        {
            foreach (Account i in DB)
            {
                if ((i.user == new_user) && (i.link == new_link)) return true;
            }
            return false;
        }

        public void ClearTextBox()
        {
            LinkTextBox.Text = "";
            UserTextBox.Text = "";
            PassTextBox.Text = "";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string new_link = LinkTextBox.Text;
            string new_user = UserTextBox.Text;
            string new_pass = PassTextBox.Text;
            Account temp = new Account(new_link, new_user, new_pass);

            if (UserInDB(new_link, new_user))
            {
                StatusBar.Text = "Account already exists";
            }
            else
            {
                DB.Add(temp);
                StatusBar.Text = "Add successfully";
                ClearTextBox();
            }
        }

        public int CanDelete(Account temp)
        {
            for (int i = 0; i < DB.Count; i++)
            {
                if (DB[i].link == temp.link && DB[i].user == temp.user && DB[i].pass == temp.pass)
                {
                    return i;
                }
            }

            return -1;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string new_link = LinkTextBox.Text;
            string new_user = UserTextBox.Text;
            string new_pass = PassTextBox.Text;
            Account temp = new Account(new_link, new_user, new_pass);

            int idx = CanDelete(temp);
            if (idx != -1)
            {
                DB.RemoveAt(idx);
                StatusBar.Text = "Deleted successfully";
                ClearTextBox();
            }
            else
            {
                StatusBar.Text = "Account doesn't exist or incorrect password";
            }
        }

        private void RiskyAccountButton_Click(object sender, EventArgs e)
        {
            int n = DB.Count;
            string result = "";

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (DB[i].pass == DB[i].pass)
                    {
                        result += "Link : " + DB[i].link + "\nUser : " + DB[i].user + "\nPassword : " + DB[i].pass + "\n";
                        result += "###############################\n";
                    }
                }
            }

            SearchResultTextBox.Text = result;
        }
    }
}
