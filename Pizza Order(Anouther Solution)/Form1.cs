using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_My_Solution_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateCrust();
            UpdateWhereToEat();
        }


        // CalculatePizzaSize 
        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbtnSmallSize.Checked)
                labSizePizza.Text = "Small";
            
            if (rbtnMediumSize.Checked)
                labSizePizza.Text = "Medium";
            
            if (rbtnLargeSize.Checked)           
                labSizePizza.Text = "Large";
        }
        private void rbtnSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbtnMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbtnLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        // Toppings
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "ExtraCheese";
            }

            if (chkMashrooms.Checked)
            {
                sToppings += ", Mashrooms";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if(chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkGreenPappers.Checked)
            {
                sToppings += ", Green Pappers";
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length-1).Trim();
            }


            labToppings.Text = sToppings;
        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        // Crust Type
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbtnThinCrust.Checked)
            {
                labCrustType.Text = "Thin Crust";
            }

            if(rbtnThickCrust.Checked)
            {
                labCrustType.Text = "Thick Crust";
            }
        }
        private void rbtnThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbtnThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        // Where To Eat
        void UpdateWhereToEat()
        {
            if (rbtnEatIn.Checked)
            {
                labWhereToEat.Text = "Eat In";
            }

            if (rbtnTakeOut.Checked)
            {
                labWhereToEat.Text = "Take Out";
            }
        }
        private void rbtnEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        // Order Pizza
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want This Order?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                MessageBox.Show("Your Order Is Succesfully", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //group CalculatePizzaSize
                grbSize.Enabled = false;
                grbToppings.Enabled = false;
                grbCrustType.Enabled = false;
                grbwhereToEat.Enabled = false;

                // button Order Pizza
                btnOrderPizza.Enabled = false;

                Form UserClients = new UserClients();
                UserClients.ShowDialog();
            }
            else
            {
                MessageBox.Show("Update Your Order?", "Update", MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
            }

        }

        // Reset Form
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you Want To Make New Order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {

                //group CalculatePizzaSize
                grbSize.Enabled = true;
                grbToppings.Enabled = true;
                grbCrustType.Enabled = true;
                grbwhereToEat.Enabled = true;

                // button Order Pizza
                btnOrderPizza.Enabled = true;

                // Radio Button Meduim
                rbtnMediumSize.Checked = true;

                // Radio Button Thin Crust
                rbtnThinCrust.Checked = true;

                // Where To Eat
                rbtnEatIn.Checked = true;

                // Button Toppings
                chkExtraCheese.Checked = false;
                chkMashrooms.Checked = false;
                chkTomatoes.Checked = false;
                chkOnion.Checked = false;
                chkOlives.Checked = false;
                chkGreenPappers.Checked = false;
            }
        }

        // Total Price
        float CalculatePizzaSize()
        {
            
            if(rbtnSmallSize.Checked)
                return Convert.ToSingle(rbtnSmallSize.Tag);
            

            if (rbtnMediumSize.Checked)
                return Convert.ToSingle(rbtnMediumSize.Tag);
            
            else 
                return Convert.ToSingle(rbtnLargeSize.Tag);
        }
        float CalculateCrustPizza()
        {
            if (rbtnThinCrust.Checked)
                return Convert.ToSingle(rbtnThinCrust.Tag);

            else
                return Convert.ToSingle(rbtnThickCrust.Tag);
        }
        float CalculateToppings()
        {
            float sTopping = 0;

            if (chkExtraCheese.Checked)
                 sTopping = Convert.ToSingle(chkExtraCheese.Tag);

            if (chkMashrooms.Checked)
                 sTopping += Convert.ToSingle(chkMashrooms.Tag);

            if (chkTomatoes.Checked)
                 sTopping += Convert.ToSingle(chkTomatoes.Tag);

            if (chkOnion.Checked)
                sTopping += Convert.ToSingle(chkOnion.Tag);

            if (chkOlives.Checked)
                sTopping += Convert.ToSingle(chkOlives.Tag);

            if (chkGreenPappers.Checked)
                sTopping += Convert.ToSingle(chkGreenPappers.Tag);


            return sTopping;
        }
        float CalculateTotalPrice()
        {
            return CalculatePizzaSize() + CalculateCrustPizza() + CalculateToppings();
        }
        void UpdateTotalPrice()
        {
            labTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblPizzaEnumerate.Text = numericUpDown1.Value.ToString();
        }

    }
}
