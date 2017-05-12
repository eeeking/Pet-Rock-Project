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
/* Program: frmCreateAccount
 * Created by: Jeremiah Iacob
 * Created on: 5/6/17*/

namespace PetRock
{
    public partial class frmCreateAccount : Form
    {
        // Declare variables and constants
        const char DELIM = ',';
        const string FILENAME = "useraccounts.txt";
        const string FILENAME2 = "userLog.txt";
        string[] userAccount = new string[6];
        string[] userEmail;
        string first = "";
        string last = "";
        string email = "";
        int userNumber;
        int userTotalOrders = 0;
        string passwordPre = "";
        string passwordCon = "";
        string userPassword;
        string atSign = "@";
        int atIndex = 0;

        // Declare filestream reader
        FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        FileStream inFile2 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private void frmCreateAccount_Load(object sender, EventArgs e)
        {
            // Initializing textbox values
            this.ActiveControl = lblName;
            txtFirstName.Text = "First";
            txtFirstName.ForeColor = Color.Gray;
            txtLastName.Text = "Last";
            txtLastName.ForeColor = Color.Gray;
            txtEmail.Text = "";
            txtPass1.Text = "";
            txtPass2.Text = "";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // Declare bool variables for validating
            bool emailIsValid = false;
            bool passIsValid = false;
            bool firstIsValid = false;
            bool lastIsValid = false;

            // If-else statements to check for empty textboxes
            if (txtFirstName.Text.Equals("First"))
            {
                txtFirstName.Focus();
                lblFirstError.Text = "You can't leave this empty.";
                lblFirstError.Visible = true;
            }
            else if (txtLastName.Text.Equals("Last"))
            {
                txtLastName.Focus();
                lblLastError.Text = "You can't leave this empty.";
                lblLastError.Visible = true;
            }
            else if (txtEmail.Text.Equals(""))
            {
                txtEmail.Focus();
                lblEmailError.Text = "You can't leave this empty.";
                lblEmailError.Visible = true;
            }
            else if (txtPass1.Text.Equals(""))
            {
                txtPass1.Focus();
                lblPassError1.Text = "You can't leave this empty.";
                lblPassError1.Visible = true;
            }
            else if (txtPass2.Text.Equals(""))
            {
                txtPass2.Focus();
                lblPassError2.Text = "You can't leave this empty.";
                lblPassError2.Visible = true;
            }
            else
            {
                StreamReader reader = new StreamReader(inFile);
                string recordIn;
                string[] fields;
                string fieldEmail;
                bool foundEmail = false;
                int numAccounts = 0;

                while (reader.ReadLine() != null)
                    ++numAccounts;  // counting lines in text file

                reader.Close();
                inFile.Close();

                userEmail = new string[numAccounts];

                StreamReader reader2 = new StreamReader(inFile2);
                recordIn = reader2.ReadLine();

                int x = 0;

                // while statement to read delimited text file and store email field in array
                while (recordIn != null)
                {
                    fields = recordIn.Split(DELIM);
                    fieldEmail = fields[3];
                    userEmail[x] = fieldEmail;
                    ++x;
                    recordIn = reader2.ReadLine();
                }

                reader2.Close();
                inFile2.Close();

                firstIsValid = true;
                lastIsValid = true;

                userNumber = numAccounts + 1;
                // Store first and last name in array
                userAccount[0] = Convert.ToString(userNumber);
                userAccount[1] = first;
                userAccount[2] = last;
                userAccount[5] = Convert.ToString(userTotalOrders);

                // If statement to validate email address and store in array
                atIndex = email.IndexOf(atSign);

                if (atIndex > 0)
                {
                    emailIsValid = true;
                    lblEmailError.Visible = false;

                    // for loop to check if email already exists
                    for (int y = 0; y < numAccounts; ++y)
                    {
                        if (email == userEmail[y])
                        {
                            foundEmail = true;
                            txtEmail.Focus();
                            lblEmailError.Text = "Email account already exists. Please use a different email.";
                            lblEmailError.Visible = true;
                        }
                        else
                            userAccount[3] = email;
                    }
                }

                else
                {
                    txtEmail.Focus();
                    lblEmailError.Text = "Invalid email format.";
                    lblEmailError.Visible = true;
                }

                // If statement to validate if passwords match and store in array
                if ((passwordPre.Length < 8) || (passwordCon.Length < 8))
                {
                    txtPass1.Focus();
                    lblPassError2.Text = "Password length too short.";
                    lblPassError2.Visible = true;
                }
                else if (string.Equals(passwordPre, passwordCon))
                {
                    passIsValid = true;
                    userPassword = passwordCon;
                    userAccount[4] = userPassword;
                    lblPassError2.Visible = false;
                }
                else
                {
                    txtPass1.Focus();
                    lblPassError2.Text = "Password did not match.";
                    lblPassError2.Visible = true;
                }
                
                // Declare filestream writer
                FileStream outFile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(outFile);
                
                // If statement to write to file when all of users info is valid
                if (firstIsValid && lastIsValid && emailIsValid && passIsValid && !foundEmail)
                {
                    
                    writer.WriteLine(userAccount[0] + DELIM + userAccount[1] + DELIM + userAccount[2] + DELIM + userAccount[3] + DELIM + userAccount[4] + DELIM + userAccount[5]);

                    // close writer
                    writer.Close();
                    outFile.Close();

                    FileStream outFile2 = new FileStream(FILENAME2, FileMode.Open, FileAccess.Write);
                    StreamWriter writer2 = new StreamWriter(outFile2);
                    writer2.WriteLine(userAccount[0] + DELIM + userAccount[3]);

                    writer2.Close();
                    outFile2.Close();

                    frmBuild secondForm = new frmBuild();
                    secondForm.Show();
                    this.Hide();
                } 
            }
        }

        // Set watermark in first and last name textboxes
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (first.Equals("First"))
            {
                txtFirstName.Text = "";
                txtFirstName.ForeColor = Color.Black;
            }
            else
            {
                txtFirstName.Text = first;
                txtFirstName.ForeColor = Color.Black;
            }
        }

        // Set watermark in first and last name textboxes
        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (last.Equals("Last"))
            {
                txtLastName.Text = "";
                txtLastName.ForeColor = Color.Black;
            }
            else
            {
                txtLastName.Text = last;
                txtLastName.ForeColor = Color.Black;
            }
        }

        // When user clicks outside the textbox leaving it blank, show error
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            first = txtFirstName.Text;
            if (first.Equals("First"))
            {
                txtFirstName.Text = "First";
                txtFirstName.ForeColor = Color.Gray;
            }
            else
            {
                if (first.Equals(""))
                {
                    txtFirstName.Text = "First";
                    txtFirstName.ForeColor = Color.Gray;
                    lblFirstError.Text = "You can't leave this empty.";
                    lblFirstError.Visible = true;
                }
                else
                {
                    txtFirstName.Text = first;
                    txtFirstName.ForeColor = Color.Black;
                }
            }
        }

        // When user clicks outside the textbox leaving it blank, show error
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            last = txtLastName.Text;
            if (last.Equals("Last"))
            {
                txtLastName.Text = "Last";
                txtLastName.ForeColor = Color.Gray;
            }
            else
            {
                if (last.Equals(""))
                {
                    txtLastName.Text = "Last";
                    txtLastName.ForeColor = Color.Gray;
                    lblLastError.Text = "You can't leave this empty.";
                    lblLastError.Visible = true;
                }
                else
                {
                    txtLastName.Text = last;
                    txtLastName.ForeColor = Color.Black;
                }
            }
        }

        // When user clicks outside the textbox leaving it blank, show error
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            if (email.Equals(""))
            {
                lblEmailError.Text = "You can't leave this empty.";
                lblEmailError.Visible = true;
            }
            else
            {
                txtEmail.Text = email;
                txtEmail.ForeColor = Color.Black;
            }
        }

        // When user clicks outside the textbox leaving it blank, show error
        private void txtPass1_Leave(object sender, EventArgs e)
        {
            passwordPre = txtPass1.Text;
            if (passwordPre.Equals(""))
            {
                lblPassError1.Text = "You can't leave this empty.";
                lblPassError1.Visible = true;
            }
            else
            {
                txtPass1.Text = passwordPre;
                txtPass1.ForeColor = Color.Black;
            }
        }

        // When user clicks outside the textbox leaving it blank, show error
        private void txtPass2_Leave(object sender, EventArgs e)
        {
            passwordCon = txtPass2.Text;
            if (passwordCon.Equals(""))
            {
                lblPassError2.Text = "You can't leave this empty.";
                lblPassError2.Visible = true;
            }
            else
            {
                txtPass2.Text = passwordCon;
                txtPass2.ForeColor = Color.Black;
            }
        }

        // Hide error when user types something in textbox
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblFirstError.Visible = false;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblLastError.Visible = false;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblEmailError.Visible = false;
        }

        private void txtPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPassError1.Visible = false;
        }

        private void txtPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPassError2.Visible = false;
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
