using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        private readonly double feet;

        public Feet()
        {
        }

        public Feet(double feet)
        {
            this.feet = feet;
        }

        public double CheckForEqual()
        {
            return this.feet;
        }
    }
}
