using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerBills;

namespace CalculateBillsUnitTest
{
    [TestClass]
    public class UnitTestForCustomers
    {
        private int included_mins = 1000;
        private int included_texts = 800;
        private int monthly_cost = 30;
        private int first_tier_mins = 500;
        private float first_tier_rate = 0.08f;
        private int second_tier_mins = 400;
        private float second_tier_rate = 0.06f;
        private float rate_per_min = 0.05f;
        private float text_cost = 0.07f;
        
        private float total_first_tier_cost = 40f;
        private float total_second_tier_cost = 24f;

        [TestMethod]
        public void No_Exceed()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int minutes = included_mins;
            int texts = included_texts;
            double expected = monthly_cost;

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Texts_Exceeded()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int extra_texts = 5;
            int minutes = included_mins;
            int texts = included_texts + extra_texts;
            double expected = monthly_cost + (extra_texts * text_cost);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int extra_minutes = 100;
            int minutes = included_mins + extra_minutes;
            int texts = included_texts;
            double expected = monthly_cost + (extra_minutes * first_tier_rate);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int extra_minutes = 100;
            int minutes = included_mins + first_tier_mins + extra_minutes;
            int texts = included_texts;
            double expected = monthly_cost + total_first_tier_cost + (extra_minutes * second_tier_rate);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int extra_mins = 100;
            int minutes = included_mins + first_tier_mins + second_tier_mins + extra_mins;
            int texts = included_texts;
            double expected = monthly_cost + total_first_tier_cost + total_second_tier_cost + (extra_mins * rate_per_min);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded()
        {
            CustomerType type = new CustomerType("Text Type", monthly_cost, included_mins, included_texts, first_tier_mins, first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost);

            //Given
            int extra_mins = 10;
            int extra_texts = 20;
            int minutes = included_mins + extra_mins;
            int texts = included_texts + extra_texts;
            double expected = monthly_cost + (extra_mins * first_tier_rate) + (extra_texts * text_cost);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
