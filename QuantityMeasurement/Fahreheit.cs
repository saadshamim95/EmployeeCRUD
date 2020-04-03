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

    public class Fahreheit
    {
        private readonly double fahrenheit;

        public Fahreheit()
        {
        }

        public Fahreheit(double fahrenheit)
        {
            this.fahrenheit = fahrenheit;
        }

        public double CheckForEqual()
        {
            return this.fahrenheit;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}