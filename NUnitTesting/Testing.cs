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
    }
}