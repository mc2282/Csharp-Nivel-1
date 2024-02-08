using System;

namespace Modulo2
{
    class Program
    {    
        static void Main(string[] args)
        {

            //1. Hacer un programa para ingresar un número y luego se emita por pantalla un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            /*
            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 10){
                Console.WriteLine("Es mayor a 10");
            }
            else
            {
                Console.WriteLine("No es mayor a 10"); 
            }
            */
            //2. Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo” si el número es mayor
            //a cero, “Negativo” si el número es menor a cero o “Cero” si el número es igual a cero.

            /*
            Console.WriteLine("Ingrese un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (num1 < 0)
                {
                Console.WriteLine("Negativo");
            }else
            {
                Console.WriteLine("Cero");
            }
            */

            //3.Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10 %.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18 %.

            /*
            double descuento = 0; 
            double importeTotal = 0;
            Console.WriteLine("Ingrese el importe de la compra: ");
            double importeCompra = Convert.ToInt32(Console.ReadLine());

            if (importeCompra > 5000)
            {
                Console.WriteLine("Se aplica descuento del 18%.");
                descuento = 0.18;
                importeTotal = importeCompra - (importeCompra * descuento);

            }
            else if (importeCompra < 5000 && importeCompra >1000)
            {
                Console.WriteLine("Se aplica descuento del 10%.");
                descuento = 0.10;
                importeTotal = importeCompra - ( importeCompra * descuento);
            }
            else
            {
                Console.WriteLine("No se aplica descuento.");
                importeTotal = importeCompra;
            }
            Console.WriteLine("Descuento: " + importeCompra + " - " + "(" + importeCompra + " * " + descuento + ") = $" + importeTotal);

            */

            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
            /*
            double[] numeros = new double[4];
            double menor = 9999;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i+1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if ( numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }
            Console.WriteLine("El menor numero es: " + menor);
            */
            //5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            /*
            double[] nums = new double[4];
            double limite = 100;
            List<double> mayores = new List<double>();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + ") : ");
                nums[i] = Convert.ToInt32(Console.ReadLine());

                if (nums[i] > limite)
                {
                    mayores.Add(nums[i]);
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Todos los numeros ingresados: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los numeros mayores a 100 son: ");
            for (int i = 0; i < mayores.Count; i++)
            {
                Console.WriteLine(mayores[i]);
            }
            */
        }
    }
}