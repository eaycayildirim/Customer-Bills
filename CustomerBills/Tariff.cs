using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            writeNewCustomer();
            deleteCustomerList();
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void writeNewCustomer()
        {
            //CSV csv = new CSV();
            //csv.writeCustomer(tariffNameTextbox.Text, monthlyCostTextbox.Text, includedMinsTextbox.Text, includedTextsTextbox.Text, firstTierMinsTextbox.Text, firstTierRateTextbox.Text, secondTierMinsTextbox.Text, secondTierRateTextbox.Text, ratePerMinTextbox.Text, textMessageCostTextbox.Text);

            XML xml = new XML();
            xml.writeCustomer(tariffNameTextbox.Text, monthlyCostTextbox.Text, includedMinsTextbox.Text, includedTextsTextbox.Text, firstTierMinsTextbox.Text, firstTierRateTextbox.Text, secondTierMinsTextbox.Text, secondTierRateTextbox.Text, ratePerMinTextbox.Text, textMessageCostTextbox.Text);
        }

        private void deleteCustomerList()
        {
            CustomerType.customer_type.Clear();
        }

    }
}
