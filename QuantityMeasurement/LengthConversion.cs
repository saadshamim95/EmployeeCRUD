//-----------------------------------------------------------------------
// <copyright file="LengthConversion.cs" company="BridgeLabz">
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
    /// Class for Converting Length
    /// </summary>
    public class LengthConversion
    {
        private readonly string type;
        private double value;

        public LengthConversion()
        {
        }

        public LengthConversion(string type, double value)
        {
            this.type = type;
            this.value = value;
        }

        public double ConvertToFeet()
        {
            if (this.type == "Feet")
            {
                return this.value;
            }

            return default;
        }

        public double ConvertToInch()
        {
            if (this.type == "Feet")
            {
                return this.value * 12;
            }

            return default;
        }
    }
}