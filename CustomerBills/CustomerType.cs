using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBills
{
    public class CustomerType
    {
        public CustomerType(string tariff_name, int monthly_cost, int included_mins, int included_texts, int first_tier_mins, double first_tier_rate, int second_tier_mins, double second_tier_rate, double rate_per_min, double text_cost)
        {
            this.tariff_name = tariff_name;
            this.monthly_cost = monthly_cost;
            this.included_mins = included_mins;
            this.included_texts = included_texts;
            this.first_tier_mins = first_tier_mins;
            this.first_tier_rate = first_tier_rate;
            this.second_tier_mins = second_tier_mins;
            this.second_tier_rate = second_tier_rate;
            this.rate_per_min = rate_per_min;
            this.text_cost = text_cost;
        }

        #region Fields
        private string tariff_name;
        private int monthly_cost;
        private int included_mins;
        private int included_texts;
        private int first_tier_mins;
        private double first_tier_rate;
        private int second_tier_mins;
        private double second_tier_rate;
        private double rate_per_min;
        private double text_cost;
        #endregion

        static public List<CustomerType> customer_type = new List<CustomerType>() { new CustomerType("Gold", 30, 1000, 800, 500, 0.08, 400, 0.06, 0.05, 0.07), new CustomerType("Silver", 20, 500, 400, 300, 0.1, 150, 0.08, 0.06, 0.09), new CustomerType("Bronze", 10, 200, 100, 150, 0.12, 75, 0.1, 0.07, 0.11) };
        public string getName()
        {
            return this.tariff_name;
        }

        private double tariffPrice()
        {
            return monthly_cost;
        }

        private double textsOverIncludedTexts(int texts)
        {
            double cost = 0;
            if (texts - included_texts > 0)
            {
                cost = (texts - included_texts) * text_cost;
            }
            return cost;
        }

        private double minutesInFirstTier(double minutes)
        {
            double cost = 0;
            double mins_difference = minutes - included_mins;
            if (mins_difference > 0 && mins_difference <= first_tier_mins)
                cost = mins_difference * first_tier_rate;

            else if(mins_difference > 0 && mins_difference > first_tier_mins)
                cost = first_tier_mins * first_tier_rate;

            return cost;
        }

        private double minutesInSecondTier(double minutes)
        {
            double cost = 0;
            double mins_difference = minutes - included_mins;
            if (mins_difference > first_tier_mins && mins_difference - first_tier_mins <= second_tier_mins)
                cost = (mins_difference - first_tier_mins) * second_tier_rate;

            else if (mins_difference > first_tier_mins && mins_difference - first_tier_mins > second_tier_mins)
                cost = second_tier_mins * second_tier_rate;

            return cost;
        }

        private double minutesOverTiers(double minutes)
        {
            double cost = 0;
            double mins_difference = minutes - included_mins;
            if (mins_difference - first_tier_mins > second_tier_mins)
                cost = (mins_difference - first_tier_mins - second_tier_mins) * rate_per_min;
            return cost;
        }

        public double calculate(double minutes, int texts)
        {
            return tariffPrice() + textsOverIncludedTexts(texts) + minutesInFirstTier(minutes) + minutesInSecondTier(minutes) + minutesOverTiers(minutes);
        }
    }

    public class Calculation
    {
        static public double compute(double minutes, int texts, CustomerType type)
        {
            return type.calculate(minutes, texts);
        }
    }
}
