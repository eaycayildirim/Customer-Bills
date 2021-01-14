using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomerBills;

namespace CalculateBillsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void When_No_Exceed_For_Gold_Customer()
        {
            //Given
            double expected = 30;
            int minutes = 1000;
            int texts = 800;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes,texts,type);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Only_Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            double expected = 30.35;
            int minutes = 1000;
            int texts = 805;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes, texts, type);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Only_Calls_Exceeded_In_First_Tier_For_Gold_Customer()
        {
            //Given
            double expected = 46;
            int minutes = 1200;
            int texts = 800;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes, texts, type);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Only_Calls_Exceeded_In_Second_Tier_For_Gold_Customer()
        {
            //Given
            double expected = 76;
            int minutes = 1600;
            int texts = 800;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes, texts, type);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Only_Calls_Exceeded_Rate_Per_Min_For_Gold_Customer()
        {
            //Given
            double expected = 104;
            int minutes = 2100;
            int texts = 800;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes, texts, type);

            //Then
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_Calls_And_Texts_Exceeded_For_Gold_Customer()
        {
            //Given
            double expected = 47.4;
            int minutes = 1200;
            int texts = 820;
            CustomerType type = new GoldType();

            //When
            double actual = Calculation.Compute(minutes, texts, type);

            //Then
            Assert.AreEqual(expected, actual);
        }

    }
}
