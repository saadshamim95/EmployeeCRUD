using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace QuantityMeasurementBackend
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        private IManager manager;

        public ConversionController(IManager manager)
        {
            this.manager = manager;
        }

        [Route("FeetToInch")]
        [HttpPost]
        public IActionResult FeetToInch(Conversion value)
        {
            var result = this.manager.FeetToInch(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }


        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(Conversion value)
        {
            var result = this.manager.InchToFeet(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MeterToCentimeter")]
        [HttpPost]
        public IActionResult MeterToCentimeter(Conversion value)
        {
            var result = this.manager.MeterToCentimeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("CentimeterToMeter")]
        [HttpPost]
        public IActionResult CentimeterToMeter(Conversion value)
        {
            var result = this.manager.CentimeterToMeter(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("KgToGm")]
        [HttpPost]
        public IActionResult KilogramToGram(Conversion value)
        {
            var result = this.manager.KilogramToGram(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("GmToKg")]
        [HttpPost]
        public IActionResult GramToKilogram(Conversion value)
        {
            var result = this.manager.GramToKilogram(value);

            if (result >= 0)
            {
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}