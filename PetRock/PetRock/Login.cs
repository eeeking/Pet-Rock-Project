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

namespace PetRock
{
    public partial class Login : Form
    {
        // Declaring public variables and consts
        string[] firstName, lastName, userID, password;
        int[] userNumber, userTotalNumbers;

        int arraySize = 0;

        const string ADMIN = "admin";
        const string ADMINPASSWORD = "password";

        const string FILENAME = "useraccounts.txt";
        const string FILENAME2 = "userLog.txt";
        const int DATATYPES = 6;
        const char DELIM = ',';

        FileStream inFile1 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        FileStream inFile2 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateAccount secondForm = new frmCreateAccount();
            secondForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputuserID, inputPassword;
            bool flag = false;
            int foundSub = 0;
            FileStream outFile = new FileStream(FILENAME2, FileMode.Open, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            inputuserID = txtUserID.Text;
            inputPassword = txtPassword.Text;

            if (inputuserID == ADMIN && inputPassword == ADMINPASSWORD)
            {
                frmAdmin admin = new frmAdmin();
                admin.Show();
                this.Hide();
            }
            else
            {
                for (int y = 0; y < arraySize; ++y)
                {
                    if (inputuserID == userID[y] && inputPassword == password[y])
                    {
                        flag = true;
                        foundSub = y;
                    }
                }

                if (flag)
                {
                    writer.WriteLine(Convert.ToString(userNumber[foundSub]) + DELIM + userID[foundSub]);
                    writer.Close();
                    outFile.Close();
                    frmBuild frm = new frmBuild();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect User ID or Password.  Please try again.");

                    writer.Close();
                    outFile.Close();

                    txtUserID.Text = null;
                    txtPassword.Text = null;

                    txtUserID.Focus();
                }
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            StreamReader reader1 = new StreamReader(inFile1);

            while(reader1.ReadLine() != null)
            {
                ++arraySize;
            }

            reader1.Close();
            inFile1.Close();

            userNumber = new int[arraySize];
            firstName = new string[arraySize];
            lastName = new string[arraySize];
            userID = new string[arraySize];
            password = new string[arraySize];
            userTotalNumbers = new int[arraySize];

            StreamReader reader2 = new StreamReader(inFile2);
            string recordIn;
            string[] fields = new string[arraySize];

            recordIn = reader2.ReadLine();
            int z = 0;
            while(recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                userNumber[z] = Convert.ToInt32(fields[0]);
                firstName[z] = fields[1];
                lastName[z] = fields[2];
                userID[z] = fields[3];
                password[z] = fields[4];
                userTotalNumbers[z] = Convert.ToInt32(fields[5]);
                recordIn = reader2.ReadLine();
                z++;
            }

            reader2.Close();
            inFile2.Close();
        }
    }
}
