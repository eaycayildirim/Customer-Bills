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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Are_Textboxes_Integers() && Are_Textboxes_Bigger_Than_Zero())
            {
                label5.Text = (Calculation.Compute(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), RadioButtonChecked())).ToString() + ("\u00A3");
            }
                
            else
                MessageBox.Show("Please provide valid numbers only.", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private bool Are_Textboxes_Integers()
        {
            int minutes_converted_to_int;
            int texts_converted_to_int;
            if (int.TryParse(textBox1.Text, out minutes_converted_to_int) && int.TryParse(textBox1.Text, out texts_converted_to_int))
                return true;
            else
                return false;
        }
        private bool Are_Textboxes_Bigger_Than_Zero()
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

        private CustomerType RadioButtonChecked()
        {
            if (radioButton1.Checked)
            {
                CustomerType type = new GoldType();
                return type;
            }
            else if (radioButton2.Checked)
            {
                CustomerType type = new SilverType();
                return type;
            }
            else
            {
                CustomerType type = new BronzeType();
                return type;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "-";
        }
    }
}
