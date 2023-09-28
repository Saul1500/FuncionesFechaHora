using System;

class EJERCICIO3
{
    static void Main()
    {
        Console.WriteLine("Desea ingresar fecha de cumpleaños (S/N)");
        string cumpleaños = Console.ReadLine();

        Console.WriteLine("");

        if (cumpleaños == "S")
        {
            Console.Write("Ingrese su fecha de cumpleaños (MM/DD/YYYY): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaCumpleaños))
            {
                DateTime fechaActual = DateTime.Now;
                DateTime proximoCumpleaños = new DateTime(fechaActual.Year, fechaCumpleaños.Month, fechaCumpleaños.Day);

                if (proximoCumpleaños < fechaActual)
                {
                    proximoCumpleaños = proximoCumpleaños.AddYears(1);
                }

                TimeSpan Diasrestantes = proximoCumpleaños - fechaActual;
                int diasRestantes = Diasrestantes.Days;

                Console.WriteLine("");

                Console.WriteLine($"Su fecha de cumpleaños es: " + fechaCumpleaños);

                Console.WriteLine("");

                Console.WriteLine($"Días restantes para su próximo cumpleaños: " + diasRestantes);
            }
            else
            {
                Console.WriteLine("");

                Console.WriteLine("Formato de fecha incorrecto.");

                Console.WriteLine("");
            }

        }
        else
        {
            Console.WriteLine("El programa se ha cerrado.");
        }
    }
}

// EJERCICIO 3
// ALUMNO: JOSE SAUL SIBRIAN SERRANO