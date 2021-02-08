using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerBills;
using fixture.CustomerBills;

namespace CalculateBillsUnitTest
{
    [TestClass]
    public class UnitTestForCustomers
    {
        CustomerType type = new FixtureCustomerType();

        [TestMethod]
        public void No_Exceed()
        {
            //Given
            int minutes = FixtureCustomerType.included_mins;
            int texts = FixtureCustomerType.included_texts;
            double expected = FixtureCustomerType.monthly_cost;

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Texts_Exceeded()
        {
            //Given
            int extra_texts = 5;
            int minutes = FixtureCustomerType.included_mins;
            int texts = FixtureCustomerType.included_texts + extra_texts;
            double expected = FixtureCustomerType.monthly_cost + (extra_texts * FixtureCustomerType.text_cost);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier()
        {
            //Given
            int extra_minutes = 100;
            int minutes = FixtureCustomerType.included_mins + extra_minutes;
            int texts = FixtureCustomerType.included_texts;
            double expected = FixtureCustomerType.monthly_cost + (extra_minutes * FixtureCustomerType.first_tier_rate);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier()
        {
            //Given
            int extra_minutes = 100;
            int minutes = FixtureCustomerType.included_mins + FixtureCustomerType.first_tier_mins + extra_minutes;
            int texts = FixtureCustomerType.included_texts;
            double expected = FixtureCustomerType.monthly_cost + FixtureCustomerType.total_first_tier_cost + (extra_minutes * FixtureCustomerType.second_tier_rate);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min()
        {
            //Given
            int extra_mins = 100;
            int minutes = FixtureCustomerType.included_mins + FixtureCustomerType.first_tier_mins + FixtureCustomerType.second_tier_mins + extra_mins;
            int texts = FixtureCustomerType.included_texts;
            double expected = FixtureCustomerType.monthly_cost + FixtureCustomerType.total_first_tier_cost + FixtureCustomerType.total_second_tier_cost + (extra_mins * FixtureCustomerType.rate_per_min);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded()
        {
            //Given
            int extra_mins = 10;
            int extra_texts = 20;
            int minutes = FixtureCustomerType.included_mins + extra_mins;
            int texts = FixtureCustomerType.included_texts + extra_texts;
            double expected = FixtureCustomerType.monthly_cost + (extra_mins * FixtureCustomerType.first_tier_rate) + (extra_texts * FixtureCustomerType.text_cost);

            //When
            double actual = type.calculate(minutes, texts);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
