using _Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculate_Solution
{
    public partial class frmCalculator : Form
    {
        private readonly CalculatorRepo _calculatorRepo;
      
        public frmCalculator()
        {

            InitializeComponent();
            _calculatorRepo = new CalculatorRepo();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
               double results = 0;

            try {

                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);

                if (rbnAdd.Checked == true)
                {
                    results = results = _calculatorRepo.Add(num1, num2); ;

                    txtResults.Text = results.ToString();
                }
                else
                    if (rdnSubtraction.Checked == true)
                {
                    results = _calculatorRepo.Subtract(num1, num2);

                    txtResults.Text = results.ToString();
                }
                else
                    if (rbnMultiply.Checked == true)
                {
                    results = _calculatorRepo.Multiply(num1, num2);

                    txtResults.Text = results.ToString();

                }
                else
                    if (rbnDivide.Checked == true)
                {

                    if (num2 != 0)
                    {
                        results = _calculatorRepo.Divide(num1, num2);

                        txtResults.Text = results.ToString();
                    }
                    else
                    {
                        throw new DivideByZeroException("Cannot divide by zero.");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResults.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNum1.Text))
            {
                int textlengthNum1 = txtNum1.Text.Length;
                if (textlengthNum1 > 0)
                {
                    txtNum1.Text = txtNum1.Text.Substring(0, textlengthNum1 - 1);
                }
                txtNum1.Focus();
                txtNum1.SelectionStart = txtNum1.Text.Length;
                txtNum1.SelectionLength = 0;
            }
            else if (!string.IsNullOrEmpty(txtNum2.Text))
            {
                int textlengthNum2 = txtNum2.Text.Length;
                if (textlengthNum2 > 0)
                {
                    txtNum2.Text = txtNum2.Text.Substring(0, textlengthNum2 - 1);
                }
                txtNum2.Focus();
                txtNum2.SelectionStart = txtNum2.Text.Length;
                txtNum2.SelectionLength = 0;
            }
            else if (!string.IsNullOrEmpty(txtResults.Text))
            {
                int textlength = txtResults.Text.Length;
                if (textlength > 0)
                {
                    txtResults.Text = txtResults.Text.Substring(0, textlength - 1);
                }
                txtResults.Focus();
                txtResults.SelectionStart = txtResults.Text.Length;
                txtResults.SelectionLength = 0;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
