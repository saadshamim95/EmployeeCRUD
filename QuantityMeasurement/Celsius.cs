//-----------------------------------------------------------------------
// <copyright file="Celsius.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class Celsius
    /// </summary>
    public class Celsius
    {
        private readonly double celsius;

        public Celsius()
        {
        }

        public Celsius(double celsius)
        {
            this.celsius = celsius;
        }

        public double CheckForEqual()
        {
            return this.celsius;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return true;

            return false;
        }
    }
}