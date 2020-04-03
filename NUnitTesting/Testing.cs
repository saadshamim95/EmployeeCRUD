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

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}