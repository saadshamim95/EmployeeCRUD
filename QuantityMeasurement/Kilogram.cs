//-----------------------------------------------------------------------
// <copyright file="Gram.cs" company="BridgeLabz">
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
    /// Class Kilogram
    /// </summary>
    public class Kilogram
    {
        private readonly double kilogram;

        public Kilogram()
        {
        }

        public Kilogram(double kilogram)
        {
            this.kilogram = kilogram;
        }

        public double CheckForEqual()
        {
            return this.kilogram;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}