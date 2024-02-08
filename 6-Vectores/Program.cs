
using System.Numerics;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            /*
            int[] numeros = new int[10];
            int maximo = 0;
            int posicion = 0;
            
            Console.WriteLine("Ingrese 10 numeros enteros: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    posicion = i;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("El valor máximo es: " + maximo); 
            Console.WriteLine("Su posición dentro del vector es: " + posicion);
            
            */


            //2. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio.
            //Mostrar por pantalla los valores que son mayores al promedio.

            /*
            int[] numeros = new int[10];
            int acumulador = 0;

            Console.WriteLine("Ingrese 10 números enteros: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                acumulador += numeros[i];
            }

            double promedio = acumulador / numeros.Length;
            Console.WriteLine("  ");
            
            Console.WriteLine("Promedio: "+ promedio);
            Console.WriteLine("Los números mayores al promedio son: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > promedio) 
                {
                    Console.WriteLine(numeros[i]);
                }
            }
            Console.WriteLine(" ");
            */

            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"  

            /*
            string cadena;
            char caract1;
            char caract2;

            Console.WriteLine("Ingrese una cadena de caracteres: ");
            cadena = Console.ReadLine();

            Console.WriteLine("  ");
            Console.WriteLine("Ingrese un caracter a reemplazar: ");
            caract1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("  ");
            Console.WriteLine("Ingrese otro caracter para reemplazarlo: ");
            caract2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("  ");
            char[] caractCadena = cadena.ToCharArray();

            for(int i = 0; i < caractCadena.Length; i++)
            {
                if (caractCadena[i] == caract1)
                {
                    caractCadena[i] = caract2;
                }
            }
            Console.WriteLine("CADENA FUENTE: '" + cadena + "' ");
            Console.WriteLine("CARÁCTER 1: '" + caract1 + "’ CARÁCTER 2: '"+ caract2 +"' ");
            Console.WriteLine("CADENA RESULTADO: ");

            foreach(char c in caractCadena)
            {
                Console.Write(c);
            }
            Console.WriteLine("  ");
            */

            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            //-Número de Artículo(1 a 15)
            //-Cantidad Vendida
            //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            //
            //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.

            /*
            int items = 15;
            double[,] nroArticulo = new double[items,items];

          
            for (int i = 0; i < items; i++)
            {
                Console.WriteLine("Número de Artículo(1 a 15):  ");
                double num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                nroArticulo[0,i] = num;

                Console.WriteLine("Cantidad vendida:  ");
                nroArticulo[1,i] = Convert.ToInt32(Console.ReadLine());
            }
           
            double cant = 0;
            double artMayorCantidad = 0 ;
            for (int i = 0; i < items; i++)
            {
                if (nroArticulo[1,i] > cant)
                {
                    cant = nroArticulo[1,i];
                    artMayorCantidad = nroArticulo[0,i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Número del artículo que más se vendió en total: "+ artMayorCantidad);
            Console.WriteLine(" ");
            Console.WriteLine("Números de artículos que no registraron ventas:  ");
            for (int i = 0; i < items; i++)
            {
                if (nroArticulo[1,i] == 0) 
                {
                    Console.WriteLine(nroArticulo[0,i]);
                }
            }
            Console.WriteLine("  ");
            Console.WriteLine("Unidades vendidas del Art. 10: " + nroArticulo[1,9]);

            */
        }
    }
}