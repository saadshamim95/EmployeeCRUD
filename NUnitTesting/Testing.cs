//-----------------------------------------------------------------------
// <copyright file="Testing.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace NUnitTesting
{
    using NUnit.Framework;
    using QuantityMeasurement;

    /// <summary>
    /// Class for Testing
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Setups this instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenZeroFeet_WhenAnalyze_ReturnEqual()
        {
            Feet feet = new Feet(0);
            double actual = feet.CheckForEqual();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Testing_FeetFor_NullCheck()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_FeetFor_ReferenceCheck()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_FeetFor_TypeCheck()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroInch_WhenAnalyze_ReturnEqual()
        {
            Inch inch = new Inch(0);
            double actual = inch.CheckForEqual();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Testing_InchFor_NullCheck()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_InchFor_ReferenceCheck()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_InchFor_TypeCheck()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(new Inch());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenOneFeet_WhenCompare_WithOneFeet_ReturnEqual()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 1);
            double actual = lengthConversion.ConvertToFeet();
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GivenOneFeet_WhenCompare_WithTwelveInch_ReturnEqual()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 1);
            double actual = lengthConversion.ConvertToInch();
            Assert.AreEqual(12, actual);
        }

        [Test]
        public void GivenOneFeet_WhenCompare_WithTwoFeet_ReturnNotEqual()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 1);
            double actual = lengthConversion.ConvertToFeet();
            Assert.AreNotEqual(2, actual);
        }

        [Test]
        public void GivenOneFeet_WhenCompare_WithTwentyFourInch_ReturnNotEqual()
        {
            LengthConversion lengthConversion = new LengthConversion("Feet", 1);
            double actual = lengthConversion.ConvertToInch();
            Assert.AreNotEqual(24, actual);
        }

        [Test]
        public void GivenZeroGram_WhenAnalyze_ReturnEqual()
        {
            Gram gram = new Gram(0);
            double actual = gram.CheckForEqual();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Testing_GramFor_NullCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_GramFor_ReferenceCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(gram);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_GramFor_TypeCheck()
        {
            Gram gram = new Gram();
            bool result = gram.Equals(new Gram());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenZeroKilogram_WhenAnalyze_ReturnEqual()
        {
            Kilogram kilogram = new Kilogram(0);
            double actual = kilogram.CheckForEqual();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Testing_KilogramFor_NullCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_KilogramFor_ReferenceCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(kilogram);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_KilogramFor_TypeCheck()
        {
            Kilogram kilogram = new Kilogram();
            bool result = kilogram.Equals(new Kilogram());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenOneGram_WhenCompare_WithOneGram_ReturnEqual()
        {
            WeightConversion weightConversion = new WeightConversion("Gram", 1);
            double actual = weightConversion.ConvertToGram();
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void GivenOneKilogram_WhenCompare_WithThousandGram_ReturnEqual()
        {
            WeightConversion weightConversion = new WeightConversion("Kilogram", 1);
            double actual = weightConversion.ConvertToGram();
            Assert.AreEqual(1000, actual);
        }

        [Test]
        public void GivenOneGram_WhenCompare_WithTwoGram_ReturnNotEqual()
        {
            WeightConversion weightConversion = new WeightConversion("Gram", 1);
            double actual = weightConversion.ConvertToGram();
            Assert.AreNotEqual(2, actual);
        }

        [Test]
        public void GivenOneKilogram_WhenCompare_WithTwoThousandGram_ReturnNotEqual()
        {
            WeightConversion weightConversion = new WeightConversion("Kilogram", 1);
            double actual = weightConversion.ConvertToGram();
            Assert.AreNotEqual(2000, actual);
        }

        [Test]
        public void GivenZeroCelsius_WhenAnalyze_ReturnEqual()
        {
            Celsius celsius = new Celsius(0);
            double actual = celsius.CheckForEqual();
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Testing_CelsiusFor_NullCheck()
        {
            Celsius celsius = new Celsius();
            bool result = celsius.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_CelsiusFor_ReferenceCheck()
        {
            Celsius celsius = new Celsius();
            bool result = celsius.Equals(celsius);
            Assert.IsTrue(result);
        }

        [Test]
        public void Testing_CelsiusFor_TypeCheck()
        {
            Celsius celsius = new Celsius();
            bool result = celsius.Equals(new Celsius());
            Assert.IsTrue(result);
        }
    }
}