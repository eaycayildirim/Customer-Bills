using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBills
{
    public abstract class CustomerType    //i had to change this to public for test
    {
        public int monthly_cost;
        public int included_mins;
        public int included_texts;
        public int first_tier_mins;
        public double first_tier_rate;
        public int second_tier_mins;
        public double second_tier_rate;
        public double rate_per_min;
        public double text_cost;
        public double Calculate(int minutes, int texts)
        {
            double cost = 0;

            if (minutes > included_mins + first_tier_mins + second_tier_mins)
            {
                if (texts > included_texts)
                {
                    cost = ((texts - included_texts) * text_cost);
                }
                cost += monthly_cost + ((first_tier_mins * first_tier_rate) + (second_tier_mins * second_tier_rate) + ((minutes - (included_mins + first_tier_mins + second_tier_mins)) * rate_per_min));
                return cost;
            }
            else if (minutes > included_mins + first_tier_mins && minutes <= included_mins + first_tier_mins + second_tier_mins)
            {
                if (texts > included_texts)
                {
                    cost = ((texts - included_texts) * text_cost);
                }
                cost += monthly_cost + ((first_tier_mins * first_tier_rate) + ((minutes - (included_mins + first_tier_mins)) * second_tier_rate));
                return cost;
            }
            else if (minutes > included_mins && minutes <= included_mins + first_tier_mins)
            {
                if (texts > included_texts)
                {
                    cost = ((texts - included_texts) * text_cost);
                }
                cost += monthly_cost + (minutes - included_mins) * first_tier_rate;
                return cost;
            }
            else if (texts > included_texts)
            {
                cost += monthly_cost + ((texts - included_texts) * text_cost);
                return cost;
            }
            else
                return monthly_cost;
        }
    }

    public class GoldType : CustomerType
    {
        public GoldType()
        {
            this.monthly_cost = 30;
            this.included_mins = 1000;
            this.included_texts = 800;
            this.first_tier_mins = 500;
            this.first_tier_rate = 0.08;
            this.second_tier_mins = 400;
            this.second_tier_rate = 0.06;
            this.rate_per_min = 0.05;
            this.text_cost = 0.07;
        }
    }     //i had to change this to public for test
    class SilverType : CustomerType
    {
        public SilverType()
        {
            this.monthly_cost = 20;
            this.included_mins = 500;
            this.included_texts = 400;
            this.first_tier_mins = 300;
            this.first_tier_rate = 0.1;
            this.second_tier_mins = 150;
            this.second_tier_rate = 0.08;
            this.rate_per_min = 0.06;
            this.text_cost = 0.09;
        }
    }
    class BronzeType : CustomerType
    {
        public BronzeType()
        {
            this.monthly_cost = 10;
            this.included_mins = 200;
            this.included_texts = 100;
            this.first_tier_mins = 150;
            this.first_tier_rate = 0.12;
            this.second_tier_mins = 75;
            this.second_tier_rate = 0.1;
            this.rate_per_min = 0.07;
            this.text_cost = 0.11;
        }
    }

    public class Calculation    //i had to change this to public for test
    {
        static public double Compute(int minutes, int texts, CustomerType type)
        {
            return type.Calculate(minutes, texts);
        }
    }
}
