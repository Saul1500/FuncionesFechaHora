using System;

namespace Biciesto

{
    class EJERCICIO1
    {
        static void Main()
        {
            int[] years = { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

            foreach (int year in years)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("============================================");

                    Console.WriteLine($"{year} Si es un año bisiesto");

                    Console.WriteLine("============================================");
                }
                else
                {
                    Console.WriteLine($"{year} No es un año bisiesto.");
                }
            }
        }
    }
}

//EJERCICIO 1
//ALUMNO: JOSE SAUL SIBRIAN SERRANO