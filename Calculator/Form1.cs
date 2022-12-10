using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_WoundedWarriors1
{
    public partial class Form1 : Form
    {
        double factoriel;
        int operation = 0;
        double number1, number2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        #region Operations
        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = 1;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }
        public void resetResult()
        {
            txtResult.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = 2;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operation = 3;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = 4;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }

        private void btnFactoriel_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            txtResult.Text = calculateFactoriel(number1).ToString();
        }
        private double calculateFactoriel(double number1)
        {
            for (double i = number1; i > 1; i--)
            {
                number1 *= i - 1;
            }
            return number1;
        }

        private void btnDivPercent_Click(object sender, EventArgs e)
        {
            operation = 6;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            operation = 7;
            number1 = double.Parse(txtResult.Text);
            resetResult();
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            number1 = double.Parse(txtResult.Text);
            txtResult.Text = Math.Sqrt(number1).ToString();
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }


        #region Number Buttons

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "1";

        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "2";
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "3";
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "4";
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "5";
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "6";
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "7";
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "8";
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "9";
        }

        private void btnNumber0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += "0";
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";
            txtResult.Text += ",";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();

            DialogResult x = MessageBox.Show("Do you really want to exit the calculator ?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else { MessageBox.Show("Thank you for continuing to use our calculator! :)", "Wounded Warriors's Message", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(txtResult.Text);
            txtResult.Text = calculate().ToString("#,#.00");
        }
        public double calculate()
        {
            double result = 0;
            if (operation == 1)

                result = number1 + number2;

            else if (operation == 2)

                result = number1 - number2;

            else if (operation == 3)

                result = number1 * number2;

            else if (operation == 4)

                result = number1 / number2;
            else if (operation == 6)

                result = number1 % number2;

            else if (operation == 7)
                result = Math.Pow(number1, number2);
            else

                result = 0;
            return result;

        }

        private void labelTeam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BERK OZCAN");
        }
            
        #region Color Change
        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboColor.SelectedIndex == 0)
            {
                this.BackColor = Color.Red;
            }
            else if (comboColor.SelectedIndex == 1)
            {
                this.BackColor = Color.Green;
            }
            else if (comboColor.SelectedIndex == 2)
            {
                this.BackColor = Color.Blue;
            }
            else if (comboColor.SelectedIndex == 3)
            {
                this.BackColor = Color.Yellow;
            }
            else if (comboColor.SelectedIndex == 4)
            {
                this.BackColor = Color.Black;
                labelTeam.BackColor = Color.White;
            }
        }
        #endregion
    }
}
