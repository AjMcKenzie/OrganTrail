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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void txtChoice_TextChanged(object sender, EventArgs e)
        {
            string choice;
            choice = txtChoice.Text;

            if (choice == "1")
            {
                label6.Visible = false;
                label7.Visible = true;
                txtChoice.Focus();
            } 
            else if (choice == "2")
            {
                label6.Visible = true;
                label7.Visible = false;
                txtChoice.Focus();
            }
            else if (choice == "3")
            {
                this.Close();
            }
        }
       
        
    }
}
