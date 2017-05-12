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
    public partial class frmBuild : Form
    {
        // Declaring public variables and constants
        string background, rockType, eyes, mouth, accessory;

        const int arraySize = 20;
        const char DELIM = ',';

        string[] item = new string[arraySize];
        int[] inventoryAmount = new int[arraySize];

        const string FILENAME = "inventory.txt";
        const string FILENAME2 = "addtocart.txt";

        FileStream inFile1 = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
        FileStream outFile1 = new FileStream(FILENAME2, FileMode.Append, FileAccess.Write);

        public frmBuild()
        {
            InitializeComponent();
        }

        private void formBuild_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(inFile1);

            // Declaring variables for delimitor
            string recordIn;
            string[] fields = new string[2];

            // Initializing count
            int y = 0;

            // Read in first line in file
            recordIn = reader.ReadLine();

            // Loop to store inventory into array
            while(recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                item[y] = fields[0];
                inventoryAmount[y] = Convert.ToInt16(fields[1]);

                ++y; // Increment
                recordIn = reader.ReadLine(); // Read in next line in text file
            }

            // Closing reader and infile
            reader.Close();
            inFile1.Close();


            // Check if item is in-stock.
            // Backgrounds array 0-3
            if (inventoryAmount[0] <= 0)
                radBackground1.Enabled = false;
            else
                radBackground1.Enabled = true;
            if (inventoryAmount[1] <= 0)
                radBackground2.Enabled = false;
            else
                radBackground2.Enabled = true;
            if (inventoryAmount[2] <= 0)
                radBackground3.Enabled = false;
            else
                radBackground3.Enabled = true;
            if (inventoryAmount[3] <= 0)
                radBackground4.Enabled = false;
            else
                radBackground4.Enabled = true;

            // Rock Type array 4-7
            if (inventoryAmount[4] <= 0)
                radRockType1.Enabled = false;
            else
                radRockType1.Enabled = true;
            if (inventoryAmount[5] <= 0)
                radRockType2.Enabled = false;
            else
                radRockType2.Enabled = true;
            if (inventoryAmount[6] <= 0)
                radRockType3.Enabled = false;
            else
                radRockType3.Enabled = true;
            if (inventoryAmount[7] <= 0)
                radRockType4.Enabled = false;
            else
                radRockType4.Enabled = true;

            // Eyes array 8-11
            if (inventoryAmount[8] <= 0)
                radEyes1.Enabled = false;
            else
                radEyes1.Enabled = true;
            if (inventoryAmount[9] <= 0)
                radEyes2.Enabled = false;
            else
                radEyes2.Enabled = true;
            if (inventoryAmount[10] <= 0)
                radEyes3.Enabled = false;
            else
                radEyes3.Enabled = true;
            if (inventoryAmount[11] <= 0)
                radEyes4.Enabled = false;
            else
                radEyes4.Enabled = true;

            // Mouth array 12-15
            if (inventoryAmount[12] <= 0)
                radMouth1.Enabled = false;
            else
                radMouth1.Enabled = true;
            if (inventoryAmount[13] <= 0)
                radMouth2.Enabled = false;
            else
                radMouth2.Enabled = true;
            if (inventoryAmount[14] <= 0)
                radMouth3.Enabled = false;
            else
                radMouth3.Enabled = true;
            if (inventoryAmount[15] <= 0)
                radMouth4.Enabled = false;
            else
                radMouth4.Enabled = true;

            // Accessories array 16-19
            if (inventoryAmount[16] <= 0)
                radAccessories1.Enabled = false;
            else
                radAccessories1.Enabled = true;
            if (inventoryAmount[17] <= 0)
                radAccessories2.Enabled = false;
            else
                radAccessories2.Enabled = true;
            if (inventoryAmount[18] <= 0)
                radAccessories3.Enabled = false;
            else
                radAccessories3.Enabled = true;
            if (inventoryAmount[19] <= 0)
                radAccessories4.Enabled = false;
            else
                radAccessories4.Enabled = true;

        }

        private void radBackground1_CheckedChanged(object sender, EventArgs e)
        {
            background = "Beach";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            background = "BG 2";
        }

        private void radBackground3_CheckedChanged(object sender, EventArgs e)
        {
            background = "BG 3";
        }

        private void radBackground4_CheckedChanged(object sender, EventArgs e)
        {
            background = "BG 4";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            rockType = "RT 1";
        }

        private void radRockType2_CheckedChanged(object sender, EventArgs e)
        {
            rockType = "RT 2";
        }

        private void radRockType3_CheckedChanged(object sender, EventArgs e)
        {
            rockType = "RT 3";
        }

        private void radRockType4_CheckedChanged(object sender, EventArgs e)
        {
            rockType = "RT 4";
        }

        private void radEyes1_CheckedChanged(object sender, EventArgs e)
        {
            eyes = "E 1";
        }

        private void radEyes2_CheckedChanged(object sender, EventArgs e)
        {
            eyes = "E 2";
        }

        private void radEyes3_CheckedChanged(object sender, EventArgs e)
        {
            eyes = "E 3";
        }

        private void radEyes4_CheckedChanged(object sender, EventArgs e)
        {
            eyes = "E 4";
        }

        private void radMouth1_CheckedChanged(object sender, EventArgs e)
        {
            mouth = "M 1";
        }

        private void radMouth2_CheckedChanged(object sender, EventArgs e)
        {
            mouth = "M 2";
        }

        private void radMouth3_CheckedChanged(object sender, EventArgs e)
        {
            mouth = "M 3";
        }

        private void radMouth4_CheckedChanged(object sender, EventArgs e)
        {
            mouth = "M 4";
        }

        private void radAccessories1_CheckedChanged(object sender, EventArgs e)
        {
            accessory = "A 1";
        }

        private void radAccessories2_CheckedChanged(object sender, EventArgs e)
        {
            accessory = "A 2";
        }

        private void radAccessories3_CheckedChanged(object sender, EventArgs e)
        {
            accessory = "A 3";
        }

        private void radAccessories4_CheckedChanged(object sender, EventArgs e)
        {
            accessory = "A 4";
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            bool backgroundCheck = false;
            bool rockTypeCheck = false;
            bool eyesCheck = false;
            bool mouthCheck = false;
            bool accessoryCheck = false;

            StreamWriter writer1 = new StreamWriter(outFile1);

            foreach (RadioButton rdo in grpBackground.Controls.OfType<RadioButton>())
            {
                if(rdo.Checked)
                {
                    backgroundCheck = true;
                    break;
                }
            }

            foreach (RadioButton rdo in grpRockType.Controls.OfType<RadioButton>())
            {
                if(rdo.Checked)
                {
                    rockTypeCheck = true;
                }
            }

            foreach (RadioButton rdo in grpEyes.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    eyesCheck = true;
                }
            }

            foreach (RadioButton rdo in grpMouth.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    mouthCheck = true;
                }
            }

            foreach (RadioButton rdo in grpAccessories.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    accessoryCheck = true;
                }
            }

            if( backgroundCheck == true && rockTypeCheck == true && eyesCheck == true && mouthCheck == true && accessoryCheck == true)
            {
                writer1.WriteLine(background + DELIM + rockType + DELIM + eyes + DELIM + mouth + DELIM + accessory);

                frmCart frm = new frmCart();

                // Code to pass variables to cart form
                //frm.background = background

                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("You must select an option from each group.");
            }

            writer1.Close();
            outFile1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCart frm = new frmCart();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            frm.Show();
            
        }
    }
}
