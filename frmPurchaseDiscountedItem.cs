using ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void computeBtn_Click(object sender, EventArgs e)
        {
            DiscountedItem di = new DiscountedItem(itemTxtBox.Text, Convert.ToDouble(priceTxtbox.Text), 
                Convert.ToInt32(quantityTxtBox.Text), Convert.ToDouble(discountTxtBox.Text));
            amountLbl.Text = di.getTotalPrice().ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DiscountedItem di = new DiscountedItem(itemTxtBox.Text, Convert.ToDouble(priceTxtbox.Text),
                Convert.ToInt32(quantityTxtBox.Text), Convert.ToDouble(discountTxtBox.Text));
            di.setPayment(Convert.ToDouble(paymentTxtBox.Text));
            changeLbl.Text = di.getChange().ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount login = new frmLoginAccount();
            login.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
