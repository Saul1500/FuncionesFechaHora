Console.WriteLine("Prestamo, ciclo 2-2023 UNAB Chalatenango");
Console.WriteLine("***********************************************");

int prestamo = 3000;
int MontoMes = 0;
int ciclo = 2;
int año = 2023;
int plazo = 6;
string Alumno = "Juan Perez";

Console.WriteLine("");
Console.WriteLine("Calculando el monto por mes");

MontoMes = prestamo / plazo;

Console.WriteLine("");

Console.WriteLine("Su monto de pago por cada mes es: " + MontoMes);
Console.WriteLine();
Console.WriteLine("***********************************************");

Console.WriteLine();
DateTime fechaPrimerCuota = DateTime.Now;

for (int i = 0; i < plazo; i++)
{

    DateTime fechapago = fechaPrimerCuota.AddMonths(i);
    Console.WriteLine($"Fecha de pago es: " + fechapago + " Mes: " + i + " Monto: " + MontoMes);

    Console.WriteLine("");

}

Console.WriteLine("\t\t\t\tTotal Pagado: $" + prestamo );


//EJERCICIO 2
//ALUMNO: JOSE SAUL SIBRIAN SERRANO
