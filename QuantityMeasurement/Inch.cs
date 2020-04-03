//-----------------------------------------------------------------------
// <copyright file="Inch.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;

    /// <summary>
    /// Class Inch
    /// </summary>
    public class Inch
    {
        private readonly double inch;

        public Inch()
        {
        }

        public Inch(double inch)
        {
            this.inch = inch;
        }

        public double CheckForEqual()
        {
            return this.inch;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj))
                return true;

            return false;
        }
    }
}