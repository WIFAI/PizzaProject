using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsForm
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private Single GetSizeSelectedPrice()
        {
            if (rb_SmalSize.Checked)
                return Convert.ToSingle(rb_SmalSize.Tag);

            if (rb_MediumSize.Checked)
                return Convert.ToSingle(rb_MediumSize.Tag);

            return Convert.ToSingle(rb_LargeSize.Tag);
        }

        private Single GetCrustTypePrice()
        {
            return (rb_ThickCrust.Checked) ? Convert.ToSingle(rb_ThickCrust.Tag) : 0;
        }

        private Single GetToppingsPrice()
        {
            float Price = 0;
            Price = (cbx_ExtraCheese.Checked) ? Convert.ToSingle(cbx_ExtraCheese.Tag) : 0;
            Price += (cbx_GreenPaper.Checked) ? Convert.ToSingle(cbx_GreenPaper.Tag) : 0;
            Price += (cbx_Mushrooms.Checked) ? Convert.ToSingle(cbx_Mushrooms.Tag) : 0;
            Price += (cbx_Olives.Checked) ? Convert.ToSingle(cbx_Olives.Tag) : 0;
            Price += (cbx_Onion.Checked) ? Convert.ToSingle(cbx_Onion.Tag) : 0;
            Price += (cbx_Tomatoes.Checked) ? Convert.ToSingle(cbx_Tomatoes.Tag) : 0;

            return Price;


        }

        private Single GetTotalPrice()
        {
            return GetSizeSelectedPrice() + GetCrustTypePrice() + GetToppingsPrice();
        }

        private void UpdateTotalPrice()
        {
            lbl_TotalPriceResult.Text = "$" + GetTotalPrice().ToString();
        }

        private void UpdateSize()
        {
            UpdateTotalPrice();
            if (rb_SmalSize.Checked)
            {
                lbl_SizeResult.Text = "Small";
                return;
            }
            if (rb_MediumSize.Checked)
            {
                lbl_SizeResult.Text = "Medium";
                return;
            }

            lbl_SizeResult.Text = "Large";
        }

        private void UpdateWhereToEat()
        {
            if (rb_EatIn.Checked)
                lbl_WhereToEatResult.Text = "Eat In";
            else
                lbl_WhereToEatResult.Text = "Take Out";

        }

        private void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rb_ThickCrust.Checked)
                lbl_CrustTypeResult.Text = "Thick Crust";
            else
                lbl_CrustTypeResult.Text = "Thin Crust";
        }

        private void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            sToppings = (cbx_ExtraCheese.Checked) ? "Extra Cheese" : "";
            sToppings += (cbx_GreenPaper.Checked) ? ", Green Paper" : "";
            sToppings += (cbx_Mushrooms.Checked) ? ", Mushrooms" : "";
            sToppings += (cbx_Olives.Checked) ? ", Olives" : "";
            sToppings += (cbx_Onion.Checked) ? ", Onion" : "";
            sToppings += (cbx_Tomatoes.Checked) ? ", Tomatoes" : "";

            sToppings = (sToppings.StartsWith(",")) ? sToppings.Substring(1, sToppings.Length - 1) : sToppings;
            lbl_ToppingsResult.Text = (sToppings != "") ? sToppings : "No Toppings";

        }

        private void rb_SmalSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_MediumSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_LargeSize_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rb_ThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rb_Thick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void cbx_ExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbx_Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbx_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbx_Olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbx_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbx_GreenPaper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rb_EatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rb_TakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btn_OrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Pnl_PizzaSize.Enabled = false;
                pnl_CrustType.Enabled = false;
                pnl_Toppings.Enabled = false;
                pnl_WhereToEat.Enabled = false;
                btn_OrderPizza.Enabled = false;

            }
        }

        private void btn_ResetOrder_Click(object sender, EventArgs e)
        {
            Pnl_PizzaSize.Enabled = true;
            pnl_CrustType.Enabled = true;
            pnl_Toppings.Enabled = true;
            pnl_WhereToEat.Enabled = true;
            btn_OrderPizza.Enabled = true;
            rb_MediumSize.Checked = true;
            rb_ThinCrust.Checked = true;
            rb_EatIn.Checked = true;
            cbx_ExtraCheese.Checked = false;
            cbx_GreenPaper.Checked = false;
            cbx_Mushrooms.Checked = false;
            cbx_Olives.Checked = false;
            cbx_Onion.Checked = false;
            cbx_Tomatoes.Checked = false;
        }

        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateWhereToEat();
            UpdateCrustType();
            UpdateToppings();
        }
    }
}
