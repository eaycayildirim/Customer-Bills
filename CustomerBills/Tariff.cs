using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerBills
{
    public partial class Tariff : Form
    {
        public Tariff()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addCustomer();
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.updateItemsInComboBox();
            frm1.Show();
        }

        public void addCustomer()
        {
            CustomerType type = new CustomerType(tariffNameTextbox.Text, Convert.ToInt32(monthlyCostTextbox.Text), Convert.ToInt32(includedMinsTextbox.Text), Convert.ToInt32(includedTextsTextbox.Text),
                Convert.ToInt32(firstTierMinsTextbox.Text), Convert.ToInt32(firstTierRateTextbox.Text), Convert.ToInt32(secondTierMinsTextbox.Text), Convert.ToInt32(secondTierRateTextbox.Text),
                Convert.ToInt32(ratePerMinTextbox.Text), Convert.ToInt32(textMessageCostTextbox.Text));

            CustomerType.customer_type.Add(type);
        }
    }
}
