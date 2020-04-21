//-----------------------------------------------------------------------
// <copyright file="RepositoryImpl.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Repository.Product
{
    using Model;
    using Repository.Interface;

    /// <summary>
    /// Class implementing Repository interface 
    /// </summary>
    /// <seealso cref="Repository.Interface.IRepository" />
    public class RepositoryImpl : IRepository
    {
        /// <summary>
        /// Centimeter to meter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal CentimeterToMeter(Conversion value)
        {
            return value.Centimeter / 100;
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
            return value.Feet * 12;
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
            return value.Gram / 1000;
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
            return value.Inch / 12;
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
            return value.KiloGram * 1000;
        }

        /// <summary>
        /// Meter to centimeter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal MeterToCentimeter(Conversion value)
        {
            return value.Meter * 100;
        }
    }
}