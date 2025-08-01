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

namespace Pizza_Order
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }



        private void b_OrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do You Want This Order?", "Inform!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                grSize.Enabled = false;
                grCrustType.Enabled = false;
                grToppings.Enabled = false;
                grWhereToEat.Enabled = false;
                b_OrderPizza.Enabled = false;
             
                MessageBox.Show("Your Order Succesfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Update your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void b_ResetForm_Click(object sender, EventArgs e)
        {
            // Group
            b_OrderPizza.Enabled = true;
            grSize.Enabled = true;
            grCrustType.Enabled = true;
            grToppings.Enabled = true;
            grWhereToEat.Enabled = true;

           
            //reset size
            rbMeduim.Checked = true;


            //reset trust
            rbThinCrust.Checked = true;


            // reset Toppings
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;


            // reset Where to eat
            rbEatIn.Checked = true;
        }


        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbPizzaSize.Text = "Small";
                return;
            }

            if(rbMeduim.Checked)
            {
                lbPizzaSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lbPizzaSize.Text = "Large";
                return;
            }
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }


        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lbCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThickCrust.Checked)
            {
                lbCrustType.Text = "Thick Crust";
                return;
            }
        }
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }



        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", GreenPeppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length-1).Trim();
            }

            if(sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lbToppings.Text = sToppings;

        }
        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
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
        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }


        void UpdateWhereToEat()
        {

            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = "EatIn";
            }

            if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = "TakeOut";
            }
        }
        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }



        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            
            else if(rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);
        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraCheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;

        }
        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThickCrust.Tag);   
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
        void UpdateTotalPrice()
        {
            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

    }
}
