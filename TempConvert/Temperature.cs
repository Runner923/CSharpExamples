using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Tempeature Class with three fields and two methods */
/* Fields: */
/*    Temp - a temperature value to be converted, input from the console */
/*    TempScaleFactor - scale factor to apply to the input temperature  */
/*    TempScale - string indicating whether input temperature is Fahrenheit or Celsius */
/*  Methods: */
/*    SelectScale - chooses the scale factor based on value of TempScale */
/*    CalcConversion - calculates the new temperature based on input temp, input scale, scale factor */


namespace TempConvert
{
    class Temperature
    {

        public float Temp;
        public float TempScaleFactor;
        public string TempScale;
        public float SelectScale(string TempScaleFactorValue)
        {
            if (TempScaleFactorValue == "F")
            { return (float) 5 / 9; }
            else
            { return (float) 9 / 5; }
        }
        public float CalcConversion(float TempValue, float TempScaleFactor, string TempScaleValue)
        {
            if (TempScaleValue == "F")
            {
                return (float) (TempValue-32) * TempScaleFactor;
            }
            else
            { return (float) TempValue*TempScaleFactor+32; }
        }


/*        public Temperature();*/
    }
}
