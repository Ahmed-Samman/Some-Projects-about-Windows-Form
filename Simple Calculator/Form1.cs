using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string Calculate()
        {

            //string Operator = txtCalculatorScreen.Text;
            string sResult = "";


            if (txtCalculatorScreen.Text.StartsWith("/") || txtCalculatorScreen.Text.StartsWith("*"))
            {
                sResult = "Error";
                return sResult;
            }


            var vresult = new DataTable().Compute(txtCalculatorScreen.Text, null);
            sResult = vresult.ToString();

            return sResult;
        }


        // Screen
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnZero.Tag.ToString();
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {

            if (txtCalculatorScreen.Text == "")
            {
                txtCalculatorScreen.Text += '.';
                return;
            }

            char[] LastOp = { '+', '-', '*', '/' };
            int Operator = txtCalculatorScreen.Text.LastIndexOfAny(LastOp);

            string CurrentText = txtCalculatorScreen.Text;

            string LastNum = (Operator == -1) ? CurrentText //If Operator == (-1) that Mean not find any Opearator.
                : txtCalculatorScreen.Text.Substring(Operator + 1);


            if (LastNum.Contains("."))
                return;
            

            txtCalculatorScreen.Text += '.';

        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnOne.Tag.ToString();
        }
        private void btmTwo_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnTwo.Tag.ToString();
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnThree.Tag.ToString();
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnFour.Tag.ToString();
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
             txtCalculatorScreen.Text += btnFive.Tag.ToString();
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnSix.Tag.ToString();
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnSeven.Tag.ToString();
        }
        private void btnEigth_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnEigth.Tag.ToString();
        }
        private void btnNine_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text += btnNine.Tag.ToString();
        }



        // Button Equal
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text = Calculate();
        }


        // Buttons Operator
        bool UpdateOperators()
        {

            if (string.IsNullOrEmpty(txtCalculatorScreen.Text))
                return false;
            

            char Operator = txtCalculatorScreen.Text.Last();

            switch (Operator)
            {
                case '+':
                case '-':
                case '*': 
                case '/':
                    return true;
                 
                default:
                    return false;
            }  
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!UpdateOperators())
                txtCalculatorScreen.Text += "+";

            else
                txtCalculatorScreen.Text
                 = txtCalculatorScreen.Text.Substring(0, txtCalculatorScreen.Text.Length - 1) + '+';       
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!UpdateOperators())
                txtCalculatorScreen.Text += "-";

            else
                txtCalculatorScreen.Text
                        = txtCalculatorScreen.Text.Substring(0, txtCalculatorScreen.Text.Length - 1) + '-';
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            if (!UpdateOperators())
                txtCalculatorScreen.Text += "*";

            else
                txtCalculatorScreen.Text
                        = txtCalculatorScreen.Text.Substring(0, txtCalculatorScreen.Text.Length - 1) + '*';
        }
        private void btnDivin_Click(object sender, EventArgs e)
        {
            if (!UpdateOperators())
                txtCalculatorScreen.Text += "/";

            else
                txtCalculatorScreen.Text
                        = txtCalculatorScreen.Text.Substring(0, txtCalculatorScreen.Text.Length - 1) + '/';
        }


        // Button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCalculatorScreen.Text = "";
        }

        // Button x
        private void btnx_Click(object sender, EventArgs e)
        {
           
            if (txtCalculatorScreen.Text != "")
            {
                txtCalculatorScreen.Text = txtCalculatorScreen.Text.Remove(txtCalculatorScreen.Text.Length-1);
            }
        }


        // Button Theme
        private void btnThemeBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        private void btnThemeGray_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Gray;
        }


    }
}
