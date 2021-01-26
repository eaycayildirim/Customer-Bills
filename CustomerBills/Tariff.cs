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
            this.Close();
            Form1 frm1 = new Form1();
            frm1.updateItemsInComboBox();
            frm1.Show();
        }

        public void addCustomer()
        {
            CustomerType type = new CustomerType();

            type.monthly_cost = Convert.ToInt32(monthlyCostTextbox.Text);
            type.included_mins = Convert.ToInt32(includedMinsTextbox.Text);
            type.included_texts = Convert.ToInt32(includedTextsTextbox.Text);
            type.first_tier_mins = Convert.ToInt32(firstTierMinsTextbox.Text);
            type.first_tier_rate = Convert.ToInt32(firstTierRateTextbox.Text);
            type.second_tier_mins = Convert.ToInt32(secondTierMinsTextbox.Text);
            type.second_tier_rate = Convert.ToInt32(secondTierRateTextbox.Text);
            type.rate_per_min = Convert.ToInt32(ratePerMinTextbox.Text);
            type.text_cost = Convert.ToInt32(textMessageCostTextbox.Text);

            Tariffs tariffs = new Tariffs();
            tariffs.addNewTariff(type);
        }
    }
}
