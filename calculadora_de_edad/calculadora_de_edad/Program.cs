using System;

namespace calculadora_de_edad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su fecha de nacimiento");
            Console.Write("\nDía: ");
            int dia = int.Parse(Console.ReadLine());
            if (dia >= 1 && dia <= 31)
            {
                Console.Write("Mes: ");
                int mes = int.Parse(Console.ReadLine());
                if (mes >= 1 && mes <= 12)
                {
                    Console.Write("Año: ");
                    int year = int.Parse(Console.ReadLine());
                    if (year >= 1000 && year <= 9999)
                    {
                        DateTime ahora = DateTime.Today;
                        int yearActual = ahora.Year;
                        int diaActual = ahora.Day;
                        int mesActual = ahora.Month;

                        if (mes <= mesActual && dia <= diaActual)
                        {
                            int edad = yearActual - year;
                            Console.WriteLine("\nUsted tiene {0} años", edad);
                        }
                        else
                        {
                            int edad = yearActual - year;
                            Console.WriteLine("\nUsted va a cumplir {0} años", edad);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Año no valido");
                    }
                }
                else
                {
                    Console.WriteLine("Mes no valido");
                }
            }
            else
            {
                Console.WriteLine("Dia no valido");
            }
        }
    }
}
