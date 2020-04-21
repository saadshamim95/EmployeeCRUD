using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Interface
{
    public interface IManager
    {
        decimal FeetToInch(Conversion value);
        decimal InchToFeet(Conversion value);
        decimal MeterToCentimeter(Conversion value);
        decimal CentimeterToMeter(Conversion value);
        decimal KilogramToGram(Conversion value);
        decimal GramToKilogram(Conversion value);
    }
}