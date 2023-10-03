using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Project_Final
{
    public partial class FormEmp : Form
    {
        private DataAccess Da { get; set; }
        
        
        public FormEmp()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql= "select name from Products;" )
        {
           
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvShow.DataSource = ds.Tables[0];
        }



        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sql = "select Name from Products Where Category like'" + this.cmbSearch.Text + "';";
            this.PopulateGridView(sql);
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select Name from Products Where Category like'" + this.txtAutoSearch.Text + "';";
            this.PopulateGridView(sql);
        }
        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.txtName.Text = this.dgvShow.CurrentRow.Cells["Name"].Value.ToString();
           
            this.txtCategory.Text = cmbSearch.Text;

            var sql = "select Price from Products where Name='" + this.txtName.Text + "'";
            var ds = this.Da.ExecuteQuery(sql);
            this.txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();

            this.panel2.Visible = true;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            

            double priceConvert = Convert.ToDouble(this.txtPrice.Text);
            double quantityConvert = Convert.ToDouble(this.numericUpDown1    .Text);
            double TotalPrice = priceConvert* quantityConvert;
            this.txtTotal.Text = TotalPrice.ToString(); 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.Visible = true;
        }
    }
}
