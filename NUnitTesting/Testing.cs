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
    }
}