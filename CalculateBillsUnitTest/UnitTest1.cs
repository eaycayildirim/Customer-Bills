using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerBills;

namespace CalculateBillsUnitTest
{
    [TestClass]
    public class UnitTestForGoldCustomer
    {
        CustomerType gold_tariff = new GoldType();
        private int included_mins_gold = 1000;
        private int included_texts_gold = 800;
        private int price_gold = 30;
        private int first_tier_mins = 500;
        private int second_tier_mins = 400;
        private int total_first_tier_cost = 40;
        private int total_second_tier_cost = 24;
        private float price_after_first_tier = 0.08f;

        [TestMethod]
        public void No_Exceed_For_Gold_Customer()
        {
            //Given
            int minutes = included_mins_gold;
            int texts = included_texts_gold;
            double expected = price_gold;

            //When
            double actual = Calculation.compute(minutes,texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            int minutes = included_mins_gold;
            int texts = included_texts_gold + 5;
            double expected = price_gold + 0.35;

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier_For_Gold_Customer() //**
        {
            //Given
            int extra_minutes = 200;
            int minutes = included_mins_gold + extra_minutes;
            int texts = included_texts_gold;
            double expected = price_gold + extra_minutes*price_after_first_tier;

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier_For_Gold_Customer()
        {
            //Given
            int minutes = included_mins_gold + first_tier_mins + 100;
            int texts = included_texts_gold;
            double expected = price_gold + total_first_tier_cost + 6;

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min_For_Gold_Customer()
        {
            //Given
            int minutes = included_mins_gold + first_tier_mins + second_tier_mins + 200;
            int texts = included_texts_gold;
            double expected = price_gold + total_first_tier_cost + total_second_tier_cost + 10;

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            int minutes = included_mins_gold + 200;
            int texts = included_texts_gold + 20;
            double expected = price_gold + 17.4;

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }
    }

    [TestClass]
    public class UnitTestForSilverCustomer
    {
        CustomerType silver_tariff = new SilverType();
        private int included_mins_silver = 500;
        private int included_texts_silver = 400;
        private int price_silver = 20;
        private int first_tier_mins = 300;
        private int second_tier_mins = 150;
        private int total_first_tier_cost = 30;
        private int total_second_tier_cost = 12;

        [TestMethod]
        public void No_Exceed_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver;
            int texts = included_texts_silver;
            double expected = price_silver;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Texts_Exceeded_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver;
            int texts = included_texts_silver + 5;
            double expected = price_silver + 0.45;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver + 10;
            int texts = included_texts_silver;
            double expected = price_silver + 1;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver + first_tier_mins + 100;
            int texts = included_texts_silver;
            double expected = price_silver + total_first_tier_cost + 8;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver + first_tier_mins + second_tier_mins + 100;
            int texts = included_texts_silver;
            double expected = price_silver + total_first_tier_cost + total_second_tier_cost + 6;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded_For_Silver_Customer()
        {
            //Given
            int minutes = included_mins_silver + 10;
            int texts = included_texts_silver + 10;
            double expected = price_silver + 1.9;

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual);
        }



    }
}
