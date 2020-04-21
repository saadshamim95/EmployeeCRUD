using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Product
{
    public class RepositoryImpl : IRepository
    {
        public decimal CentimeterToMeter(Conversion value)
        {
            return value.Centimeter / 100;
        }

        public decimal FeetToInch(Conversion value)
        {
            return value.Feet * 12;
        }

        public decimal GramToKilogram(Conversion value)
        {
            return value.Gram / 1000;
        }

        public decimal InchToFeet(Conversion value)
        {
            return value.Inch / 12;
        }

        public decimal KilogramToGram(Conversion value)
        {
            return value.KiloGram * 1000;
        }

        public decimal MeterToCentimeter(Conversion value)
        {
            return value.Meter * 100;
        }
    }
}