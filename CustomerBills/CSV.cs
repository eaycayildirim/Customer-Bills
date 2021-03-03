using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerBills
{
    class CSV
    {
        public void addTypes()
        {
            string file_path = "CustomersBills.csv";
            StreamReader reader = new StreamReader(File.OpenRead(file_path));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                string[] values = line.Split(';');

                CustomerType.customer_type.Add(new CustomerType(values[0], Convert.ToInt32(values[1]), Convert.ToInt32(values[2]), Convert.ToInt32(values[3]), Convert.ToInt32(values[4]), Convert.ToDouble(values[5]), Convert.ToInt32(values[6]), Convert.ToDouble(values[7]), Convert.ToDouble(values[8]), Convert.ToDouble(values[9])));
            }
            reader.Close();
        }

        public void writeCustomer(string tariff_name, string monthly_cost, string included_mins, string included_texts, string first_tier_mins, string first_tier_rate, string second_tier_mins, string second_tier_rate, string rate_per_min, string text_cost)
        {
            Tariff tariff = new Tariff();

            string file_path = "CustomersBills.csv";
            var lines = File.ReadAllLines(file_path);
            var lines_array = new List<string>(lines);

            string csv = string.Join(";", "\"" + tariff_name + "\"", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            lines_array.Add(csv);
            lines = lines_array.ToArray();

            File.WriteAllLines(file_path, lines);
        }
    }
}
