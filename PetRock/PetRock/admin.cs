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
//FORM: ADMIN PAGE
namespace PetRock
{
    public partial class frmAdmin : Form
    {
        const string FILENAME = "orders.txt";
        const int DATATYPES = 8;
        const char DELIM = ',';

        //FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            /*The following constants indicate the quantity of each material that is recommended
             * to have on hand at all times. This will help determine inventory re-ordering amounts */

            //Declare constants
            const int NUM_BACKGROUND1 = 40;
            const int NUM_BACKGROUND2 = 30;
            const int NUM_BACKGROUND3 = 50;
            const int NUM_BACKGROUND4 = 40;


            const int NUM_ROCK1 = 70;
            const int NUM_ROCK2 = 80;
            const int NUM_ROCK3 = 90;
            const int NUM_ROCK4 = 85;

            const int NUM_EYES1 = 100;
            const int NUM_EYES2 = 90;
            const int NUM_EYES3 = 80;
            const int NUM_EYES4 = 100;

            const int NUM_MOUTH1 = 40;
            const int NUM_MOUTH2 = 50;
            const int NUM_MOUTH3 = 30;
            const int NUM_MOUTH4 = 45;

            const int NUM_ACCESSORY1 = 50;
            const int NUM_ACCESSORY2 = 40;
            const int NUM_ACCESSORY3 = 40;
            const int NUM_ACCESSORY4 = 45;

            string recordIn, orderNumber, email, back_choice, rock_choice, eyes_choice, mouth_choice, accessory_choice, total;
            string[] fields;
            recordIn = Console.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                orderNumber = fields[0];
                email = fields[1];
                back_choice = fields[2];
                rock_choice = fields[3];
                eyes_choice = fields[4];
                mouth_choice = fields[5];
                accessory_choice = fields[6];
                total = fields[7];

            }






        }

       
    }
}
