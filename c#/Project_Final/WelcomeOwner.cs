using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class WelcomeOwner : Form
    {
        public WelcomeOwner()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormOwner f1 = new FormOwner();
            f1.Visible = true;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.Visible = true;

            
        }
    }
}
