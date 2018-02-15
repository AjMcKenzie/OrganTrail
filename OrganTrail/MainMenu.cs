using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganTrail
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

        }

        private void txtChoice_TextChanged(object sender, EventArgs e)
        {
            string choice;
            choice = txtChoice.Text;


            if (choice == "1")
            {
                gbPerson.Visible = true;
                gbMenu.Visible = false;
                txtChoice.Visible= false;
                txtPerson.Visible = true;
                txtChoice.Enabled = false;
            } 
            else if (choice == "2")
            {
                txtChoice.Focus();
                Form mapForm = new map();
                mapForm.Show();
            }
            else if (choice == "3")
            {
                this.Close();
            }

        }

        private void txtPerson_TextChanged(object sender, EventArgs e)
        {
            string person;
            person = txtPerson.Text;

            if (person == "1")
            {
                Form bankerForm = new Form();
                bankerForm.Show();
            }
            else if (person == "2")
            {
                Form carpenterForm = new Form();
                carpenterForm.Show();
            }
            else if (person == "3")
            {
                Form farmerForm = new Form();
                farmerForm.Show();
            }
            
        }

        private void btnStartTheHunt_Click(object sender, EventArgs e)
        {
            Form HuntingGame  = new Form();
            HuntingGame.Show();
        }
    }
}
