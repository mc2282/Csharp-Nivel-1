using System;
using System.Threading.Tasks;

namespace Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.

            /*
            double numero1, numero2, suma;

            Console.WriteLine("Ingrese dos números: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            numero2 = Convert.ToInt32(Console.ReadLine());

            suma = numero1 + numero2;

            Console.WriteLine("La suma es: " + suma);

            */

            //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            /*
            double num, cubo;

            Console.WriteLine("Ingrese un número: ");
            num = Convert.ToInt32(Console.ReadLine());

            cubo = Math.Pow(num,3);

            Console.WriteLine("El cubo de " + num + " es: " + cubo);
            */

            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
            //y la velocidad promedio de un vehículo.
            //Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro
            //teniendo en cuenta los datos ingresados.

            /*
            double km, tiempoAprox, velocidad;

            Console.WriteLine("Ingrese los kilómetros existentes entre dos ciudades: ");
            km = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la velocidad promedio del vehículo: ");
            velocidad = Convert.ToInt32(Console.ReadLine());

            tiempoAprox = km / velocidad; 

            Console.WriteLine("El tiempo aprox. que demandará llegar de un punto a otro es de: " + tiempoAprox);
            */

            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada 
            //empleado. Hacer un programa para ingresar el total facturado por un empleado y
            //que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.

            /*
           
            int sueldoFijo = 15000;
            double tasa = 0.05;
            double totalFacturado, sueldoTotal, comision;

            Console.WriteLine("Ingrese el total facturado por el empleado: ");
            totalFacturado = Convert.ToInt32(Console.ReadLine());
            comision =  totalFacturado * tasa;
            sueldoTotal = sueldoFijo + comision;

            Console.WriteLine("Comisión del 5% sobre "+ totalFacturado + ": " + comision + ".");
            Console.WriteLine("Sueldo total a cobrar por el empleado: " + sueldoFijo + " + " + comision + " = $" + sueldoTotal + " pesos.");
            
             */

            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
            //y luego calcule y emita por pantalla el promedio final.
            
            /*
            string resp = "S";

            while (resp.ToUpper() == "S")
            {
                int cantNotas = 3;
                double sumaNotas = 0;
                double[] notas = new double[3];
                Array.Clear(notas);
              
                for (int i = 0; i < cantNotas; i++)
                {
                    Console.WriteLine("Ingrese las notas del alumno: ");
                    notas[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 0; i < notas.Length; i++)
                {
                    sumaNotas += notas[i];
                }

                double promedioFinal = sumaNotas / cantNotas;
                Console.WriteLine("Promedio Final: " + sumaNotas + " / " + cantNotas + " = " + promedioFinal + ".");

                Console.WriteLine(" ");

                Console.WriteLine("Volver a calcular el promedio? S/N ");
                resp = Console.ReadLine();
                Console.WriteLine(" ");
            }
            */
        }
    }
}