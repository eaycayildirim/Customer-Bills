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
        private CustomerType type;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void updateItemsInComboBox()
        {
            Tariffs tariffs = new Tariffs();
            customerTypeComboBox.Items.Clear();
            for (int i = 0; i < tariffs.customer_type.Count; i++)
            {
                customerTypeComboBox.Items.Add(tariffs.customer_type[i]);
            }
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            totalBillLabel.Text = Calculation.compute(Convert.ToDouble(totalMinutesTextbox.Text), Convert.ToDouble(totalTextsTextbox.Text), selectingCustomerType()).ToString() + ("\u00A3");
        }

        private CustomerType selectingCustomerType()
        {
            Tariffs tariffs = new Tariffs();
            return tariffs.customer_type[customerTypeComboBox.SelectedIndex];
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
