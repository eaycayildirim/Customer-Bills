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
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addCustomerType();
        }

        public CustomerType addCustomerType()
        {
            CustomerType type = new CustomerType();

            type.monthly_cost = Convert.ToInt32(textBox2.Text);
            type.included_mins = Convert.ToInt32(textBox3.Text);
            type.included_texts = Convert.ToInt32(textBox4.Text);
            type.first_tier_mins = Convert.ToInt32(textBox5.Text);
            type.first_tier_rate = Convert.ToInt32(textBox6.Text);
            type.second_tier_mins = Convert.ToInt32(textBox7.Text);
            type.second_tier_rate = Convert.ToInt32(textBox8.Text);
            type.rate_per_min = Convert.ToInt32(textBox9.Text);
            type.text_cost = Convert.ToInt32(textBox10.Text);

            return type;
        }
    }
}
