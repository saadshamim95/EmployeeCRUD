//-----------------------------------------------------------------------
// <copyright file="Testing.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace NUnitTesting
{
    using NUnit.Framework;

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

        /// <summary>
        /// 
        /// </summary>
        /// Test Case 1
        [Test]
        public void GivenZeroFeet_WhenAnalyze_ReturnEqual()
        {
            Feet feet = new Feet(0);
            double actual = feet.CheckForEqual();
            Assert.AreEqual(0, actual);
        }
    }
}