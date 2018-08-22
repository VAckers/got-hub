using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + button2.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            /*plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;*/

            txtDisplay.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        double total1 = 0;
        /*
        double total2 = 0;
        */
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "+";
            txtDisplay.Clear();
            /*
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
            */
        }
        string theOperator;

        

        /*private void button1_Click(object sender, EventArgs e)
        {
            bool buttonClicked = false;

            if (buttonClicked ==  true)
            {
                MessageBox.Show("buttonClicked has a value of true");
            }
            else
            {
                MessageBox.Show("buttonClicked has a value of false");
            }
        }*/

        /*bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;*/

        private void btnMinus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "-";
            txtDisplay.Clear();
            /*
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;*/
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "*";
            txtDisplay.Clear();
            /*
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;*/
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            theOperator = "/";
            txtDisplay.Clear();
            /*
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;*/
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double answer;
            double total2 = 0;
            total2 = double.Parse(txtDisplay.Text);
            switch (theOperator)
            {
                case "+":
                    answer = total1 + total2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "-":
                    answer = total1 - total2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "*":
                    answer = total1 * total2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                case "/":
                    answer = total1 / total2;
                    txtDisplay.Text = answer.ToString();
                    total1 = 0;
                    break;
                default:
                    total1 = 0;
                    break;
            }
            /*if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            txtDisplay.Text = total2.ToString();
            total1 = 0;*/
        }
    }
}
