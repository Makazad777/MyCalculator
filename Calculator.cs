using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Mak Azad
// P298217
// 18/05/2018
// Version 1.1

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        // Click method for Button One
        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnOne.Text;
        }

        // Click method for Button Two
        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnTwo.Text;
        }

        // Click method for Button Three
        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnThree.Text;
        }

        // Click method for Button Four
        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnFour.Text;
        }

        // Click method for Button Five
        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnFive.Text;
        }

        // Click method for Button Six
        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnSix.Text;
        }

        // Click method for Button Seven
        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnSeven.Text;
        }

        // Click method for Button Eight
        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnEight.Text;
        }

        // Click method for Button Nine
        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnNine.Text;
        }

        // Click method for Button Zero
        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnZero.Text;
        }

        // Click method for Button Point
        private void BtnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + BtnPoint.Text;
        }

        // Click method for Button Clear
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }        
        
        // declare variables
        double total1 = 0; 
        double total2 = 0; 
        double result = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;

        // Click method for Plus Button
        private void BtnPlus_Click(object sender, EventArgs e)
        {
            //Parse the value on display into double and keep adding into total1 as the plus buton is clicked
            total1 += double.Parse(txtDisplay.Text);
            //clear the display
            txtDisplay.Clear();
            //set the plusButtonClicked as true
            plusButtonClicked = true;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
        }

        // Click method for Minus Button
        private void BtnMinus_Click(object sender, EventArgs e)
        {
            //Parse the value on display into double and keep subtracting from the previous value and 
            //assign the value into total1 as the minus buton is clicked
            total1 += double.Parse(txtDisplay.Text);
            //clear the display
            txtDisplay.Clear();
            //set the minusButtonClicked as true
            plusButtonClicked = false;
            minusButtonClicked = true;
            divideButtonClicked = false;
            multiplyButtonClicked = false;
                     
        }

        // Click method for Division Button
        private void BtnDivision_Click(object sender, EventArgs e)
        {
            //Parse the value on display into double and keep dividing from the previous value and 
            //assign the value into total1 as the division buton is clicked
            total1 += double.Parse(txtDisplay.Text);
            //clear the display
            txtDisplay.Clear();
            //set the divideButtonClicked as true
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = true;
            multiplyButtonClicked = false;
        }

        // Click method for Multiplication Button
        private void BtnMulti_Click(object sender, EventArgs e)
        {
            //Parse the value on display into double and keep multiplying from the previous value and 
            //assign the value into total1 as the multiply buton is clicked
            total1 += double.Parse(txtDisplay.Text);
            //clear the display
            txtDisplay.Clear();
            //set the multiplyButtonClicked as true
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multiplyButtonClicked = true;
        }

        // Click method for Equal Button
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            //parse the last display value into double total2
            total2 = double.Parse(txtDisplay.Text);
            //check which buttonclick is true do the calculation
            if (plusButtonClicked == true)
            {                
                result = BasicMath.Arithmetic.Add(total1, total2);
            }
            else if (minusButtonClicked == true)
            {                
                result = BasicMath.Arithmetic.Sub(total1, total2);
            }
            else if (divideButtonClicked == true)
            {                
                result = BasicMath.Arithmetic.Div(total1, total2);
            }
            else if (multiplyButtonClicked == true)
            {                
                result = BasicMath.Arithmetic.Mult(total1, total2);
            }
            //convert the result into string and display
            txtDisplay.Text = result.ToString();
            total1 = 0;
            total2 = 0;
        }

        // Click method for SQRT Button
        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //check whether the number is positive
            if (num >= 0)
            {
                result = InterMath.Algebraic.Sqrt(num);
                txtDisplay.Text = result.ToString();
            }
            //else show error message
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Click method for CubeRT Button
        private void BtnCubeRT_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //if the number is positive do the following
            if (num >= 0)
            {
                result = InterMath.Algebraic.cubeRT(num);
                txtDisplay.Text = result.ToString();
            }
            //if the number is negative do the following
            else
            {
                num = Math.Abs(num);
                result = InterMath.Algebraic.cubeRT(num);
                txtDisplay.Text = "-" + result.ToString();                
            }
        }

        // Click method for Inverse Button
        private void BtnInv_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //do the calculation
            result = InterMath.Algebraic.Inv(num);
            txtDisplay.Text = result.ToString();
        }

        // Click method for Tan Button
        private void BtnTan_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //check whether the number is within 0 to 360 and do the following calculation
            if (num >= 0 && num <= 360)
            {
                //check whether the number is 90 or 270
                if (num == 90 || num == 270)
                {
                    txtDisplay.Text = "Invalid";
                }
                //else do the following calculation
                else
                {
                    result = AdvancedMath.Trigonometric.Tan(num);
                    txtDisplay.Text = result.ToString();
                }                
            }
            //check if the number is over 360 
            else if (num > 360)
            {
                //if the value is over 360, just deduct 360 from the number.
                num = num - 360;
                //keep deducting 360 till the number is over 360 
                while (num > 360)
                {
                    num = num - 360;
                }
                //check whether the number is 90 or 270
                if (num == 90 || num == 270)
                {
                    txtDisplay.Text = "Invalid";
                }
                //else do the following calculation
                else
                {
                    result = AdvancedMath.Trigonometric.Tan(num);
                    txtDisplay.Text = result.ToString();
                }
            }

            //if the number is negative or not a number
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Click method for Sin Button
        private void BtnSin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //check if the number is 0 or positive
            if (num >= 0)
            {
                result = AdvancedMath.Trigonometric.Sin(num);
                txtDisplay.Text = result.ToString();
            }
            //else show the message
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Click method for Cos Button
        private void BtnCos_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            //check if the number is 0 or positive
            if (num >= 0)
            {
                result = AdvancedMath.Trigonometric.Cos(num);
                txtDisplay.Text = result.ToString();
            }
            //else show the message
            else
            {
                MessageBox.Show("Number must be positive", "Error Message");
                txtDisplay.Text = "0";
            }
        }

        // Click method for Negative/Positive sign Button
        private void BtnNegative_Click(object sender, EventArgs e)
        {
            //if there is not a negative sign on the display show a negative sign
            if (!txtDisplay.Text.Contains("-"))
            {
                String temp = txtDisplay.Text;
                temp = "-" + temp;
                txtDisplay.Text = temp;
            }
            //if there is already a negative sign on the display then erase that negative sign
            else
            {
                txtDisplay.Text = txtDisplay.Text.TrimStart('-');
            }         
        }

        // Click method for Quit Menu Button
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ask to confirm about quitting
            if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

    } // end of Calculator Form
} // end of Namespace
