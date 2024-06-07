using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem currentItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void frmPurchaseDiscountedItem_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = txtItemName.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);

                currentItem = new DiscountedItem(itemName, price, quantity, discount);
                double totalAmount = currentItem.getTotalPrice();
                lblTotalAmount.Text = $"{totalAmount.ToString("C", new CultureInfo("en-PH"))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double amountPaid = Convert.ToDouble(txtAmountPaid.Text);
                currentItem.setPayment(amountPaid);
                double change = currentItem.getChange();
                lblChange.Text = $" {change.ToString("C", new CultureInfo("en-PH"))}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
