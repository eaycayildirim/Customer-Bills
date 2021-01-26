using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerBills;

namespace CalculateBillsUnitTest
{
    [TestClass]
    public class UnitTestForGoldCustomer
    {
        CustomerType gold_tariff = new Gold();
        private int included_mins_gold = 1000;
        private int included_texts_gold = 800;
        private int price_gold = 30;
        private int first_tier_mins = 500;
        private float price_after_first_tier = 0.08f;
        private int second_tier_mins = 400;
        private float price_after_second_tier = 0.06f;
        private float total_first_tier_cost = 40f;
        private float total_second_tier_cost = 24f;
        private float rate_per_min = 0.05f;
        private float text_message_cost = 0.07f;

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
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            int extra_texts = 5;
            int minutes = included_mins_gold;
            int texts = included_texts_gold + extra_texts;
            double expected = price_gold + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier_For_Gold_Customer()
        {
            //Given
            int extra_minutes = 100;
            int minutes = included_mins_gold + extra_minutes;
            int texts = included_texts_gold;
            double expected = price_gold + (extra_minutes * price_after_first_tier);

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier_For_Gold_Customer()
        {
            //Given
            int extra_minutes = 100;
            int minutes = included_mins_gold + first_tier_mins + extra_minutes;
            int texts = included_texts_gold;
            double expected = price_gold + total_first_tier_cost + (extra_minutes * price_after_second_tier);

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min_For_Gold_Customer()
        {
            //Given
            int extra_mins = 100;
            int minutes = included_mins_gold + first_tier_mins + second_tier_mins + extra_mins;
            int texts = included_texts_gold;
            double expected = price_gold + total_first_tier_cost + total_second_tier_cost + (extra_mins * rate_per_min);

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            int extra_mins = 10;
            int extra_texts = 20;
            int minutes = included_mins_gold + extra_mins;
            int texts = included_texts_gold + extra_texts;
            double expected = price_gold + (extra_mins * price_after_first_tier) + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, gold_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }

    [TestClass]
    public class UnitTestForSilverCustomer
    {
        CustomerType silver_tariff = new Silver();
        private int included_mins_silver = 500;
        private int included_texts_silver = 400;
        private int price_silver = 20;
        private int first_tier_mins = 300;
        private float price_after_first_tier = 0.1f;
        private int second_tier_mins = 150;
        private float price_after_second_tier = 0.08f;
        private float total_first_tier_cost = 30f;
        private float total_second_tier_cost = 12f;
        private float rate_per_min = 0.06f;
        private float text_message_cost = 0.09f;

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
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Texts_Exceeded_For_Silver_Customer()
        {
            //Given
            int extra_texts = 5;
            int minutes = included_mins_silver;
            int texts = included_texts_silver + extra_texts;
            double expected = price_silver + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier_For_Silver_Customer()
        {
            //Given
            int extra_mins = 10;
            int minutes = included_mins_silver + extra_mins;
            int texts = included_texts_silver;
            double expected = price_silver + (extra_mins * price_after_first_tier);

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier_For_Silver_Customer()
        {
            //Given
            int extra_mins = 100;
            int minutes = included_mins_silver + first_tier_mins + extra_mins;
            int texts = included_texts_silver;
            double expected = price_silver + total_first_tier_cost + (extra_mins * price_after_second_tier);

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min_For_Silver_Customer()
        {
            //Given
            int extra_mins = 100;
            int minutes = included_mins_silver + first_tier_mins + second_tier_mins + extra_mins;
            int texts = included_texts_silver;
            double expected = price_silver + total_first_tier_cost + total_second_tier_cost + (extra_mins * rate_per_min);

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded_For_Silver_Customer()
        {
            //Given
            int extra_mins = 10;
            int extra_texts = 10;
            int minutes = included_mins_silver + extra_mins;
            int texts = included_texts_silver + extra_texts;
            double expected = price_silver + (extra_mins * price_after_first_tier) + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, silver_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }

    [TestClass]
    public class UnitTestForBronzeCustomer
    {
        CustomerType bronze_tariff = new Bronze();
        private int included_mins_bronze = 200;
        private int included_texts_bronze = 100;
        private int price_bronze = 10;
        private int first_tier_mins = 150;
        private float price_after_first_tier = 0.12f;
        private int second_tier_mins = 75;
        private float price_after_second_tier = 0.1f;
        private float total_first_tier_cost = 18f;
        private float total_second_tier_cost = 7.5f;
        private float rate_per_min = 0.07f;
        private float text_message_cost = 0.11f;

        [TestMethod]
        public void No_Exceed_For_Bronze_Customer()
        {
            //Given
            int minutes = included_mins_bronze;
            int texts = included_texts_bronze;
            double expected = price_bronze;

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Texts_Exceeded_For_Bronze_Customer()
        {
            //Given
            int extra_texts = 5;
            int minutes = included_mins_bronze;
            int texts = included_texts_bronze + extra_texts;
            double expected = price_bronze + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_First_Tier_For_Bronze_Customer()
        {
            //Given
            int extra_mins = 10;
            int minutes = included_mins_bronze + extra_mins;
            int texts = included_texts_bronze;
            double expected = price_bronze + (extra_mins * price_after_first_tier);

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_In_Second_Tier_For_Bronze_Customer()
        {
            //Given
            int extra_mins = 70;
            int minutes = included_mins_bronze + first_tier_mins + extra_mins;
            int texts = included_texts_bronze;
            double expected = price_bronze + total_first_tier_cost + (extra_mins * price_after_second_tier);

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_Exceeded_Rate_Per_Min_For_Bronze_Customer()
        {
            //Given
            int extra_mins = 100;
            int minutes = included_mins_bronze + first_tier_mins + second_tier_mins + extra_mins;
            int texts = included_texts_bronze;
            double expected = price_bronze + total_first_tier_cost + total_second_tier_cost + (extra_mins * rate_per_min);

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Calls_And_Texts_Exceeded_For_Bronze_Customer()
        {
            //Given
            int extra_mins = 10;
            int extra_texts = 10;
            int minutes = included_mins_bronze + extra_mins;
            int texts = included_texts_bronze + extra_texts;
            double expected = price_bronze + (extra_mins * price_after_first_tier) + (extra_texts * text_message_cost);

            //When
            double actual = Calculation.compute(minutes, texts, bronze_tariff);

            //Then
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}
