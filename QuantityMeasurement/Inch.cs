//-----------------------------------------------------------------------
// <copyright file="Inch.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurement
{
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
    }
}