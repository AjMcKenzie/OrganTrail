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
                txtChoice.Focus();
            } 
            else if (choice == "2")
            {
                txtChoice.Focus();
                txtChoice.Clear();
                Form mapForm = new map();
                mapForm.Show();
                
            }
            else if (choice == "3")
            {
                this.Close();
            }
        }
       
        
    }
}
