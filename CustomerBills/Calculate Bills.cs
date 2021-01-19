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

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (areTextboxesIntegers() && areTextboxesBiggerThanZero())
            {
                label5.Text = (Calculation.compute(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), selectingCustomerType())).ToString() + ("\u00A3");
            }
                
            else
                MessageBox.Show("Please provide valid numbers only.", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool areTextboxesIntegers()
        {
            if (int.TryParse(textBox1.Text, out _) && int.TryParse(textBox1.Text, out _))
                return true;
            else
                return false;
        }
        private bool areTextboxesBiggerThanZero()
        {
            try
            {
                int minutes_converted_to_int = Convert.ToInt32(textBox1.Text);
                int texts_converted_to_int = Convert.ToInt32(textBox2.Text);
                if (minutes_converted_to_int > 0 && texts_converted_to_int > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private CustomerType selectingCustomerType()
        {
            if (comboBox1.Text == "Gold")
            {
                return new GoldType();
            }
            else if (comboBox1.Text == "Silver")
            {
                return new SilverType();
            }
            else if (comboBox1.Text == "Bronze")
            {
                return new BronzeType();
            }
            else
            {
                Tariff tariff = new Tariff();
                tariff.addCustomerType();
            }

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "-";
        }

        private void addTariffButton_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff();
            tariff.Show();
        }
    }
}
