//-----------------------------------------------------------------------
// <copyright file="IRepository.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Repository.Interface
{
    using Model;

    /// <summary>
    /// Interface for Repository
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Feet to inch.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal FeetToInch(Conversion value);

        /// <summary>
        /// Inches to feet.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal InchToFeet(Conversion value);

        /// <summary>
        /// Meter to centimeter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal MeterToCentimeter(Conversion value);

        /// <summary>
        /// Centimeter to meter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal CentimeterToMeter(Conversion value);

        /// <summary>
        /// Kilograms to gram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal KilogramToGram(Conversion value);

        /// <summary>
        /// Grams to kilogram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns converted value</returns>
        decimal GramToKilogram(Conversion value);
    }
}