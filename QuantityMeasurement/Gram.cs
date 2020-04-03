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

    public class Gram
    {
        private readonly double gram;

        public Gram()
        {
        }

        public Gram(double gram)
        {
            this.gram = gram;
        }

        public double CheckForEqual()
        {
            return this.gram;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj))
                return true;

            return false;
        }
    }
}
