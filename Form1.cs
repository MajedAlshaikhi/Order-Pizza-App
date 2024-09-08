
using System;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            if(rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if(chkExtraCheeze.Checked)
            {
                sToppings = "Extra Cheese";
            }

            if(chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if(chkMushrooms.Checked) 
            {
                sToppings += ", Mushrooms";
            }

            if(chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if(chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if(chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if(sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblToppings.Text = sToppings;
        }

        void UpdateCrust()
        {
             UpdateTotalPrice();

            if (rbThin.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThick.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            if(rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }
        }

        float GetSelectedSizePrice()
        {
            if(rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            
            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float GetToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if(chkExtraCheeze.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
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

        float GetSelectedCrutPrice()
        {
            if(rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }

        void UpdateTotalPrice()
        {
            //numericUpDown1.Value: shows how many pizza a customer wish to order

            lblTotalPrice.Text = "$" + (Convert.ToSingle(numericUpDown1.Value) * CalculateTotalPrice()).ToString();            
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetToppingsPrice() + GetSelectedCrutPrice();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraCheeze_CheckedChanged(object sender, EventArgs e)
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

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateCrust();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void OrderPizza()
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("Order is Confirmed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
            else
            {
                MessageBox.Show("Update Your Order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void ResetForm()
        {
            //reset Groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            //reset Size
            rbMedium.Checked = true;

            //reset Toppings.
            chkExtraCheeze.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;

            //reset CrustType
            rbThin.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btnOrderPizza.Enabled = true;
            numericUpDown1.Value = 1; // return pizza number to 1
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            OrderPizza();   
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
