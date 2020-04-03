//-----------------------------------------------------------------------
// <copyright file="WeightConversion.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class WeightConversion
    {
        private readonly string type;
        private double value;

        public WeightConversion()
        {
        }

        public WeightConversion(string type, double value)
        {
            this.type = type;
            this.value = value;
        }

        public double ConvertToGram()
        {
            if (this.type == "Gram")
            {
                return this.value;
            }

            return this.value * 1000;
        }
    }
}
