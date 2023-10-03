using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Final
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
        }
       


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var query = "select * from UserInfo where Id = '" + this.txtID.Text + "' and Password = '" + this.txtPassword.Text + "';";
                SqlConnection sqlcon = new SqlConnection("Data Source=GIGABYTE;Initial Catalog=Project;User ID=sa;Password=kabirmd");
                sqlcon.Open();
                SqlCommand sqlcom = new SqlCommand(query, sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                string bringStringVar = this.txtID.Text;
                char[] separator = { '-' };
                string[] strlist = bringStringVar.Split(separator);
                string finalString = strlist[0];

                if (ds.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("Login Confirmed");

                    if (finalString is "owner")
                    {
                        new WelcomeOwner().Visible = true;

                    }
                    else if( finalString is "emp")
                    {
                        new FormEmp().Visible = true;
                    }
                 
                }
                else
                    MessageBox.Show("Invalid Information");

                sqlcon.Close();
            }
            catch(Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
            this.Visible = false;



        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtID.Clear();
            this.txtPassword.Clear();
        }

    }
}
