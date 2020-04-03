//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class TemperatureConversion
    {
        private readonly string type;
        private double value;

        public TemperatureConversion()
        {
        }

        public TemperatureConversion(string type, double value)
        {
            this.type = type;
            this.value = value;
        }

        public double ConvertToCelsius()
        {
            return this.value;
        }
    }
}