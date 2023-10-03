using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator11
{
    public partial class Form1 : Form
    {
        Double resultvalue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

            isOperationPerformed = false;
           Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultvalue != 0)
            {
                button26.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultvalue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else
            {

                operationPerformed = button.Text;
                resultvalue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultvalue + " " + operationPerformed;
                isOperationPerformed = true;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    default:
                    break;
            }
            resultvalue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
        }
    }
}
