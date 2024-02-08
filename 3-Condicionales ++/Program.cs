using System;

namespace Modulo3
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Hacer un programa que solicite el ingreso de dos números y luego calcular:
            /*
                        La resta si el primero es mayor que el segundo.
                        La suma si son iguales.
                        El producto si el primero es menor.
                        Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            */
            /*
            double num1, num2, resta, suma, producto;
            
            Console.WriteLine("Ingrese dos números: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            resta = num1 - num2;
            suma = num1 + num2;
            producto = num1 * num2;

            if (num1 > num2)
            {
                Console.WriteLine("Resultado: " + resta);
            }else if (num1 < num2)
            {
                Console.WriteLine("Resultado: " + producto);
            } else
            {
                Console.WriteLine("Resultado: " + suma);
            }
          */

            //2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad
            //de litros vendidos, según la siguiente escala:
            /*
                        Si vende menos de 100 litros, no hay descuento.
                        Si vende entre 101 y 300 litros, el descuento es del 10%.
                        Si vende entre 301 y 500 litros, el descuento es del 15%.
                        Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos 
            y calcule y emita el importe con el descuento  aplicado..
            */

            /*
            double importeCDescuento = 0;
            double descuento = 0;
            Console.WriteLine("Ingrese el importe total de la venta: ");
            double importeVenta = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            double cantLtVendidos = Convert.ToInt32(Console.ReadLine());

            if (cantLtVendidos > 500)
            {
                descuento = (importeVenta * 0.25);
                importeCDescuento = importeVenta - descuento;
            } 
            else if (cantLtVendidos > 301 && cantLtVendidos < 500)
            {
                descuento = (importeVenta * 0.15);
                importeCDescuento = importeVenta - descuento;
            }
            else if (cantLtVendidos > 101 && cantLtVendidos < 300)
            {
                descuento = (importeVenta * 0.10);
                importeCDescuento = importeVenta - descuento;
            }
            else
            {
            
            }
            Console.WriteLine("");
            Console.WriteLine("Importe con descuento aplicado: " + importeVenta + " - " + descuento + " = " + importeCDescuento);
            */

            //3.Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            //Para ello existe la siguiente escala de precios:
            /*
                                   i5(1)      i7(2)       i9(3)
                        8 RAM(1)   USD 800    USD 900     USD 1200
                        16 RAM(2)  USD 900    USD 1000    USD 1400
                        32 RAM(3)  USD 1000   USD 1400    USD 2000

            Además, el equipo viene con un disco que permite almacenar 500 GB de información y
            que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo adicional de USD 300.
            
            Hacer un programa que solicite la opción de procesador, la opción de memoria RAM,
            y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita 
            por pantalla el monto de la máquina seleccionada.
            */

            /*
            int costo = 0;
            double importeTotal = 0;
            int extension = 0;

            Console.WriteLine("           i5(1)      i7(2)       i9(3)");
            Console.WriteLine("8 RAM(1)   USD 800    USD 900     USD 1200");
            Console.WriteLine("16 RAM(2)  USD 900    USD 1000    USD 1400");
            Console.WriteLine("32 RAM(3)  USD 1000   USD 1400    USD 2000");

            Console.WriteLine(" ");

            Console.WriteLine("Seleccione el procesador: i5(1), i7(2), i9(3)");
            int procesador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Seleccione la memoria RAM: 8 RAM(1), 16 RAM(2), 32 RAM(3) ");
            int ram = Convert.ToInt32(Console.ReadLine());

            //8GB
            if (procesador == 1 && ram == 1)
            {
                costo = 800;
            }
            else if (procesador == 2 && ram == 1)
            {
                costo = 900;
            }
            else if (procesador == 3 && ram == 1)
            {
                costo = 1200;
            }

            //16GB
            if (procesador == 1 && ram == 2)
            {
                costo = 900;
            }
            else if (procesador == 2 && ram == 2)
            {
                costo = 1000;
            }
            else if (procesador == 3 && ram == 2)
            {
                costo = 1400;
            }
            
            //32GB
            if (procesador == 1 && ram == 3)
            {
                costo = 1000;
            }
            else if (procesador == 2 && ram == 3)
            {
                costo = 1400;
            }
            else if (procesador == 3 && ram == 3)
            {
                costo = 2000;
            }

            Console.WriteLine(" ");

            Console.WriteLine("Extender el disco a 1TB? (Tiene un costo de USD 300) Ingrese 1 = sí; 0 = no.");
            int rta = Convert.ToInt32(Console.ReadLine());

            if (rta == 1)
            {
                extension = 300;
            }
            else
            {
                extension = 0;
            }
            importeTotal = costo + extension;
            Console.WriteLine(" ");
            Console.WriteLine("El importe total es de: " + costo + " + " + extension + " = $" + importeTotal);
            */

            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de
            //los dos primeros es mayor al producto del segundo con el tercero.

            /*
            double[] numeros = new double[3];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número: ");

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }   
            if ((numeros[0] + numeros[1]) > (numeros[1] * numeros[2]))
            {
                Console.WriteLine("La suma de los dos primeros números es MAYOR al producto del segundo con el tercero.");
            }
            else if ((numeros[0] + numeros[1]) < (numeros[1] * numeros[2]))
            {
                Console.WriteLine("La suma de los dos primeros números es MENOR al producto del segundo con el tercero.");
            }
            else
            {
                Console.WriteLine("La suma de los dos primeros números es IGUAL al producto del segundo número con el tercero.");
            }
            */

            //5. Hacer un programa para ingresar 4 números. Luego analizar e informar
            //por pantalla si los mismos se encuentran ordenados de forma decreciente.

            /*
            double[] numeros = new double[4];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número: ");

                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            if ((numeros[0] > numeros[1]) && (numeros[1] > numeros[2]) && (numeros[2] > numeros[3]))
            { 
               Console.WriteLine("Los números se encuentran ordenados de forma decreciente. ");
            }
            else
            {
                Console.WriteLine("Los números NO se encuentran ordenados de forma decreciente. ");
            }
            */
        }
     }
}