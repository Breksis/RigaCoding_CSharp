using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double num1;
        private double num2;
        private double result;
        private String darbiba;

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "1";
            }
            else OutputField.Text = OutputField.Text + "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "2";
            }
            else OutputField.Text = OutputField.Text + "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "3";
            }
            else OutputField.Text = OutputField.Text + "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "4";
            }
            else OutputField.Text = OutputField.Text + "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "5";
            }
            else OutputField.Text = OutputField.Text + "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "6";
            }
            else OutputField.Text = OutputField.Text + "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "7";
            }
            else OutputField.Text = OutputField.Text + "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "8";
            }
            else OutputField.Text = OutputField.Text + "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (OutputField.Text == "0")
            {
                OutputField.Text = "9";
            }
            else OutputField.Text = OutputField.Text + "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            OutputField.Text = OutputField.Text + "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            OutputField.Text = OutputField.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            OutputField.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "0";
            darbiba = "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "0";
            darbiba = "-";
        }

        private void btnReizinat_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "0";
            darbiba = "*";
        }

        private void btnDalit_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "0";
            darbiba = "/";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(OutputField.Text);

            switch (darbiba)
            {
                case "+":
                    result = num1 + num2;
                    OutputField.Text = Convert.ToString(result);
                    break;

                case "-":
                    result = num1 - num2;
                    OutputField.Text = Convert.ToString(result);
                    break;

                case "*":
                    result = num1 * num2;
                    OutputField.Text = Convert.ToString(result);
                    break;

                case "/":
                    if(num1 == 0 || num2 == 0)
                    {
                        OutputField.Text = "Ar 0 dalit nedrikst!";
                    }
                    else
                    {
                        result = num1 / num2;
                        OutputField.Text = Convert.ToString(result);
                    }
                    break;
            }
        }
    }
}
