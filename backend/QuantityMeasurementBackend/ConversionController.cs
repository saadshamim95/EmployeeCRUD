//-----------------------------------------------------------------------
// <copyright file="ConversionController.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace QuantityMeasurementBackend
{
    using Manager.Interface;
    using Microsoft.AspNetCore.Mvc;
    using Model;
    using QuantityMeasurementBackend.MSMQ;

    /// <summary>
    /// Controller Class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        private IManager manager;

        Messaging messaging = new Messaging();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversionController"/> class.
        /// </summary>
        /// <param name="manager">The manager.</param>
        public ConversionController(IManager manager)
        {
            this.manager = manager;
        }

        /// <summary>
        /// Feet to inch.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInch(Conversion value)
        {
            var result = this.manager.FeetToInch(value);
            if (result >= 0)
            {
                messaging.SendMessage("Inch: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Inches to feet.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(Conversion value)
        {
            var result = this.manager.InchToFeet(value);
            if (result >= 0)
            {
                messaging.SendMessage("Feet: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Meters to centimeter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("MeterToCentimeter")]
        [HttpPost]
        public IActionResult MeterToCentimeter(Conversion value)
        {
            var result = this.manager.MeterToCentimeter(value);
            if (result >= 0)
            {
                messaging.SendMessage("Centimeter: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Centimeters to meter.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("CentimeterToMeter")]
        [HttpPost]
        public IActionResult CentimeterToMeter(Conversion value)
        {
            var result = this.manager.CentimeterToMeter(value);
            if (result >= 0)
            {
                messaging.SendMessage("Meter: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Kilograms to gram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("KgToGm")]
        [HttpPost]
        public IActionResult KilogramToGram(Conversion value)
        {
            var result = this.manager.KilogramToGram(value);
            if (result >= 0)
            {
                messaging.SendMessage("Gram: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }

        /// <summary>
        /// Grams to kilogram.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>It returns Action Result</returns>
        [Route("GmToKg")]
        [HttpPost]
        public IActionResult GramToKilogram(Conversion value)
        {
            var result = this.manager.GramToKilogram(value);
            if (result >= 0)
            {
                messaging.SendMessage("Kilogram: ", result);
                return this.Ok(result);
            }

            return this.BadRequest();
        }
    }
}