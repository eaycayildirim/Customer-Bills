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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void updateItemsInComboBox()
        {
            customerTypeComboBox.Items.Clear();
            for (int i = 0; i < CustomerType.customer_type.Count; i++)
            {
                customerTypeComboBox.Items.Add(CustomerType.customer_type[i].getName());
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var minutes = Convert.ToDouble(totalMinutesTextbox.Text);
            var texts = Convert.ToInt32(totalTextsTextbox.Text);
            totalBillLabel.Text = selectingCustomerType().calculate(minutes, texts).ToString()+ ("\u00A3");
        }

        private CustomerType selectingCustomerType()
        {
            return CustomerType.customer_type[customerTypeComboBox.SelectedIndex];
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            totalMinutesTextbox.Clear();
            totalTextsTextbox.Clear();
            totalBillLabel.Text = "-";
        }

        private void addTariffButton_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff();
            tariff.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateItemsInComboBox();
        }
    }
}
