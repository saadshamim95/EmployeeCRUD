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
        RedisCache redisCache = new RedisCache();

        /// <summary>
        /// Centimeter to meter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// It returns converted value
        /// </returns>
        public decimal CentimeterToMeter(Conversion value)
        {
            decimal result = value.Centimeter / 100;
            redisCache.RedisConnection($"Centimeter", result.ToString());
            return result;
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
            decimal result = value.Feet * 12;
            redisCache.RedisConnection($"Feet", result.ToString());
            return result;
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
            decimal result = value.Gram / 1000;
            redisCache.RedisConnection($"Gram", result.ToString());
            return result;
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
            decimal result = value.Inch / 12;
            redisCache.RedisConnection($"Inch", result.ToString());
            return result;
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
            decimal result = value.KiloGram * 1000;
            redisCache.RedisConnection($"KiloGram", result.ToString());
            return result;
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
            decimal result = value.Meter * 100;
            redisCache.RedisConnection($"Meter", result.ToString());
            return result;
        }
    }
}