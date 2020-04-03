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

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj))
                return true;

            return false;
        }
    }
}
