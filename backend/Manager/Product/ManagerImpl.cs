using Manager.Interface;
using Model;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Product
{
    public class ManagerImpl : IManager
    {
        private IRepository repository;
        public ManagerImpl(IRepository repository)
        {
            this.repository = repository;
        }

        public decimal CentimeterToMeter(Conversion value)
        {
            return this.repository.CentimeterToMeter(value);
        }

        public decimal FeetToInch(Conversion value)
        {
            return this.repository.FeetToInch(value);
        }

        public decimal GramToKilogram(Conversion value)
        {
            return this.repository.GramToKilogram(value);
        }

        public decimal InchToFeet(Conversion value)
        {
            return this.repository.InchToFeet(value);
        }

        public decimal KilogramToGram(Conversion value)
        {
            return this.repository.KilogramToGram(value);
        }

        public decimal MeterToCentimeter(Conversion value)
        {
            return this.repository.MeterToCentimeter(value);
        }
    }
}