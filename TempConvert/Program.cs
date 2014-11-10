using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Simple Fahrenheit to Celsius (or vice versa) conversion program */
/* Charles Howard 18-Sep-2014 */
namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Starting...");
            Temperature temp = new Temperature();
             Console.WriteLine("Enter Temperature Scale");
             string answ = Console.ReadLine();
             answ = answ.ToUpper();
             if (answ != "F")
              { temp.TempScale = "C";}
              else
              { temp.TempScale = "F";}
            //Note: Any value that is not explicitly "F" is assumed to be "C"
            Console.WriteLine(temp.TempScale);
            temp.TempScaleFactor = temp.SelectScale(temp.TempScale);
            Console.WriteLine(" Input a temperature ");
            temp.Temp = System.Single.Parse(Console.ReadLine()); 
            Console.WriteLine(" Temperature to Convert " + temp.Temp);
            Console.WriteLine(" Scale Factor used " + temp.TempScaleFactor);
            Console.WriteLine(" temp.TempScale value used " + temp.TempScale);
            float newtemp = temp.CalcConversion(temp.Temp, temp.TempScaleFactor, temp.TempScale);
            Console.WriteLine(" Converted Temp is " + newtemp);
            Console.ReadLine();
        }
    }
}
