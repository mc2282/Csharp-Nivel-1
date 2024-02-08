namespace Modulo7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            //Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función. 

            /*
            //programa 1
            static void producto(int n1, int n2)
            {
                Console.WriteLine("El producto de ambos números es: " + (n1 * n2));
            }
            
            Console.WriteLine("Ingrese dos números enteros: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            producto(num1, num2);
            */

            //programa 2

            /*
            static void producto(double precio, int cant)
            {
                Console.WriteLine("El monto total a pagar es: " + (precio * cant));
            }

            Console.WriteLine("Ingrese el precio del producto: ");
            double precio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            producto(precio, cantidad);

            */

            //2. Hacer una función llamada “par” que reciba un número entero
            //y devuelva 1 si es par o cero si no lo es.
            //
            //Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

            /*
            
            int[] numeros = new int[20];

            static int par(int num)
            {
                if (num % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            Console.WriteLine("Ingrese 20 números: ");

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine("  ");
            Console.WriteLine("Números pares(1): ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Número " + numeros[i] + ": " + par(numeros[i]));
            }
            */

            //3. Hacer una función llamada “primo” que reciba un número entero
            // y devuelva 1 si el número es primo o cero si no lo es. 
            //
            // Hacer un programa para ingresar números.
            // El lote corta cuando se ingresa un número cero. 
            // Informar el promedio teniendo en cuenta sólo los números primos.
            
            double sumaPrimos = 0; int numeros = 0; int num = 1; int rta = 1;

            do
            {
                do
                {
                    Console.WriteLine("Ingrese un número: ");
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num == 0)
                    {
                        break;
                    }
                    //acumula cuantos numeros primos hay en sumaPrimos
                    sumaPrimos += primo(num);
                    /* Console.WriteLine(" ");
                    Console.WriteLine("primo: ");
                    Console.WriteLine(primo(num));*/
                    numeros++;

                } while (num != 0);
                
                Console.WriteLine(" ");
                Console.WriteLine(sumaPrimos);
                Console.WriteLine("El promedio de números primos respecto al total de números es del: " + promedio(sumaPrimos, numeros) +"%");
                Console.WriteLine(" ");
                Console.WriteLine("Volver a realizar? 1 = si, 0 = no");
                rta = Convert.ToInt32(Console.ReadLine());
                numeros = 0;
                sumaPrimos = 0;
            } while (rta != 0);

            static double primo(double num)
            {
                int noEsPrimo = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        noEsPrimo+=1;
                    }
                }

                if (noEsPrimo > 2)// si no es primo retorna 0
                {
                    return 0;
                }
                else 
                {
                    return 1;// si es primo retorna 1
                }
            }

            static double promedio(double num, double total)
            {
                return (num / total)*100;
            }
        }
    }
}
