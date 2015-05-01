using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_Log_v1._1
{
    public partial class frmMain : Form
    {
        StreamReader inFile;
        StreamWriter outFile;
        List<Login> myList = new List<Login>();
        List<Client> myClients = new List<Client>();
        Client myClient;
        //List<mainaccount>
        //List<tempaccount>
        Login myUser;
        private int myUserInt = 0;
        private int userIDInt, userAccountInt;
        private string[] login = new string[2];
        private string myString;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.TextLength > 0 && txtPassword.TextLength > 0)
            {
                int myInt = 0;
                for (int i = 0; i < myList.Count; i++)
                {
                    if (txtUser.Text == myList[i].UserName)
                    {
                        if (txtPassword.Text == myList[i].Password)
                        {
                            myUserInt = 1;
                            myClient = myClients[i];
                            myInt++;
                            break;
                        }

                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                            myInt++;
                            break;
                        }
                    }
                    myUserInt++;
                }
                if (myInt == 0)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                myInt = 0;
            }

            else
            {
                MessageBox.Show("Make sure you have entered a username and password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
