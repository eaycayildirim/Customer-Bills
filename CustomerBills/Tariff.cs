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
            string file_path = "CustomersBills.csv";
            var lines = File.ReadAllLines(file_path);
            var lines_array = new List<string>(lines);

            string csv = string.Join(";", "\"" + tariffNameTextbox.Text + "\"", monthlyCostTextbox.Text, includedMinsTextbox.Text, includedTextsTextbox.Text, firstTierMinsTextbox.Text, firstTierRateTextbox.Text, secondTierMinsTextbox.Text, secondTierRateTextbox.Text, ratePerMinTextbox.Text, textMessageCostTextbox.Text);

            lines_array.Add(csv);
            lines = lines_array.ToArray();

            File.WriteAllLines(file_path, lines);
        }

        private void deleteCustomerList()
        {
            CustomerType.customer_type.Clear();
        }

    }
}
