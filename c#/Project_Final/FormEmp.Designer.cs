namespace Project_Final
{
    partial class FormEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.dgvShow);
            this.panel1.Controls.Add(this.txtAutoSearch);
            this.panel1.Controls.Add(this.cmbSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(13, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 434);
            this.panel1.TabIndex = 0;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(14, 160);
            this.dgvShow.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.ReadOnly = true;
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(161, 268);
            this.dgvShow.TabIndex = 26;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(14, 122);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(161, 22);
            this.txtAutoSearch.TabIndex = 3;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Limousine",
            "Convertibles",
            "Sports",
            "Micro Car"});
            this.cmbSearch.Location = new System.Drawing.Point(14, 76);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(161, 24);
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightYellow;
            this.panel2.Controls.Add(this.btnTotal);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(210, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 433);
            this.panel2.TabIndex = 1;
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(206, 280);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(109, 34);
            this.btnTotal.TabIndex = 30;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(169, 339);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(200, 22);
            this.txtTotal.TabIndex = 29;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(335, 189);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 22);
            this.txtPrice.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 26;
            this.label3.Text = "Price";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(440, 379);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(109, 34);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "LogOut";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(56, 189);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(335, 113);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(200, 22);
            this.txtCategory.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(56, 113);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // FormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmp";
            this.Text = "FormEmp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}