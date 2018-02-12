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
             
        }
        //public void OnKeyDownHandler(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        label1.Visible = false;
        //    }
        //}

        public event KeyPressEventHandler KeyPress;
        
    }
}
