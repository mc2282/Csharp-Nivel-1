namespace Modulo8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
              4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
                que reciba un número por valor y una variable por referencia.

                Que analice el número y escriba variable recibida por referencia con:
                a. 1 si el número es positivo.
                b. -1 si el número es negativo.
                c. 0 si el número es cero.
            */

            Console.WriteLine("Ingrese un número");

            int num = Convert.ToInt32(Console.ReadLine());

            positivoNegativoCero(ref num);

            Console.WriteLine("El número es: " + num);
        }
            static void positivoNegativoCero(ref int numero)
            {
                if (numero > 0)
                {
                    numero = 1;
                }
                else if (numero < 0)
                {
                    numero = -1;
                }
                else
                {
                   numero = 0;
                }
            }
        }
    }

