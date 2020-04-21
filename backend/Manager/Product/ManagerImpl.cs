//-----------------------------------------------------------------------
// <copyright file="ManagerImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Manager.Product
{
    using Manager.Interface;
    using Model;
    using Repository.Interface;

    /// <summary>
    /// Class implementing Manager interface
    /// </summary>
    /// <seealso cref="Manager.Interface.IManager" />
    public class ManagerImpl : IManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagerImpl"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public ManagerImpl(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Centimeters to meter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal CentimeterToMeter(Conversion value)
        {
            return this.repository.CentimeterToMeter(value);
        }

        /// <summary>
        /// Feet to inch.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal FeetToInch(Conversion value)
        {
            return this.repository.FeetToInch(value);
        }

        /// <summary>
        /// Grams to kilogram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal GramToKilogram(Conversion value)
        {
            return this.repository.GramToKilogram(value);
        }

        /// <summary>
        /// Inches to feet.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal InchToFeet(Conversion value)
        {
            return this.repository.InchToFeet(value);
        }

        /// <summary>
        /// Kilograms to gram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal KilogramToGram(Conversion value)
        {
            return this.repository.KilogramToGram(value);
        }

        /// <summary>
        /// Meters to centimeter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal MeterToCentimeter(Conversion value)
        {
            return this.repository.MeterToCentimeter(value);
        }
    }
}