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
    public partial class FormOwner : Form
    {
        private DataAccess Da { get; set; }
        public FormOwner()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            this.PopulateGridView();
        }
        private void PopulateGridView(string sql = "select * from EmployeeInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private void btnShowIn_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnSearching_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from EmployeeInfo where Name = '" + this.txtSearching.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }

        private void txtAutoSearching_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from Employee where Salary like '" + this.txtEmployeeSalary.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSaveIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from EmployeeInfo where Id = '" + this.txtEmployeeId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update EmployeeInfo
                                EmployeeName = '" + this.txtEmployeeName.Text + @"',
                                EmployeeSalary = " + this.txtEmployeeSalary.Text + @", 
                                WorkingExperience = " + this.txtWorkingExperience.Text + @",
                                JoiningDate = '" + this.dtpJoiningDate.Text + @"',
                                Gender = '" + this.cmbGender.Text + @"'
                                where Id = '" + this.txtEmployeeId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into EmployeeInfo values('" + this.txtEmployeeId.Text + "','" + this.txtEmployeeName.Text + "'," + this.txtEmployeeSalary.Text + "," + this.txtWorkingExperience.Text + ",'" + this.dtpJoiningDate.Text + "','" + this.cmbGender.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtEmployeeId.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) ||
                String.IsNullOrEmpty(this.txtEmployeeSalary.Text) || String.IsNullOrEmpty(this.txtWorkingExperience.Text) ||
                String.IsNullOrEmpty(this.cmbGender.Text) || String.IsNullOrWhiteSpace(this.txtEmployeeId.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnClearIn_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnDeleteIn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from EmployeeInfo where Id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
        private void dgvEmployee_DoubleClick(object sender, EventArgs e)
        {
            this.txtEmployeeId.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeId"].Value.ToString();
            this.txtEmployeeName.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeName"].Value.ToString();
            this.txtEmployeeSalary.Text = this.dgvEmployee.CurrentRow.Cells["EmployeeSalary"].Value.ToString();
            this.txtWorkingExperience.Text = this.dgvEmployee.CurrentRow.Cells["WorkingExperirence"].Value.ToString();
            this.dtpJoiningDate.Text = this.dgvEmployee.CurrentRow.Cells["JoiningDate"].Value.ToString();
            this.cmbGender.Text = this.dgvEmployee.CurrentRow.Cells["Gender"].Value.ToString();
        }
        private void RefreshContent()
        {
            this.txtEmployeeId.Clear();
            this.txtEmployeeName.Clear();
            this.txtEmployeeSalary.Clear();
            this.txtWorkingExperience.Clear();
            this.dtpJoiningDate.Text = "";
            this.cmbGender.SelectedIndex = -1;

            this.txtSearching.Clear();
            this.txtAutoSearching.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WelcomeOwner Wo = new WelcomeOwner();
            Wo.Visible = true;
        }
    }

}
