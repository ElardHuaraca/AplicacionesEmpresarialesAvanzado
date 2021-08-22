using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de 2 numeros");
                Console.WriteLine("[2] Raiz cuadrada de los 10 primeros numeros enteros");
                Console.WriteLine("[3] Multiplicacion,Division y resta de 2 numeros");
                Console.WriteLine("[4] 10 primeros numeros primos");
                Console.WriteLine("[5] Transformar temperatura a Fº");
                Console.WriteLine("[6] Transformar temperatura a Cº");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opcion y presione enter");
                opcion = Console.ReadLine();
                int b;
                double a;
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;

                    case "2":
                        Console.WriteLine("Calculando ...");
                        Raiz();
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", a, b, Multiplicacion(a, b));
                        Console.WriteLine("La division de {0} y {1} es {2}", a, b, Division(a, b));
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;

                    case "4":
                        Console.WriteLine("Obteniendo ...");
                        Primos();
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;

                    case "5":
                        Console.WriteLine("Ingrese la temperatura en Cº");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La temperatura de {0} Cº en fahrenheit es {1}", a, transforToFahrenheit(a));
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;

                    case "6":
                        Console.WriteLine("Ingrese la temperatura en Fº");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La temperatura de {0} Fº en celsius es {1}", a, transforToCelsius(a));
                        Console.WriteLine("Presione cualquier tecla para volver al menu");
                        Console.ReadKey(true);
                        break;
                }
            } while (!opcion.Equals("0"));
        }

        static double Suma(double a, int b)
        {
            return a + b;
        }

        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        static double Resta(double a, int b)
        {
            return a - b;
        }

        static double Division(double a, int b)
        {
            return a / (double)b;
        }

        static double Multiplicacion(double a, int b)
        {
            return a * b;
        }

        static void Primos()
        {
            double[] numeros = new double[10];
            int count = 0;
            double a = 1;
            bool primo = false;
            while (count < 10)
            {
                while (primo == false)
                {
                    if ((a % 2 == 0 || a % 3 == 0 || a % 5 == 0) && (a != 2 && a != 3 && a != 5)) { primo = false; }
                    else if (a != 1) { primo = true; numeros[count] = a; }
                    a++;
                }
                primo = false;
                count++;
            }
            Console.WriteLine("Los 10 primero numero primos son: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}"
                , numeros[0], numeros[1], numeros[2], numeros[3], numeros[4], numeros[5], numeros[6]
                , numeros[7], numeros[8], numeros[9]);
        }

        static double transforToCelsius(double a)
        {
            return 5 * (a - 32) / 9;
        }

        static double transforToFahrenheit(double a)
        {
            return (9*a/5)+32;
        }
    }
}
