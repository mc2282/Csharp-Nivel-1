namespace Modulo5
{

    class Program
    {
        public static void Main(string[] args)
        {

            //1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.

            /*
        for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla.
            //Solo se debe emitir UN valor por pantalla.

            /*
            double[] diezNumeros = new double [10];
            double mayor = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese los numeros: ");
                diezNumeros[i] = Convert.ToInt32(Console.ReadLine());
                
                if (diezNumeros[i] > mayor)
                {
                    mayor = diezNumeros[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("El mayor numero es: " + mayor);

            */

            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años


            /*
            int[] veinteEdades = new int[20];
            List <int> mayoresDeDieciocho = new List<int>();
            int acumuladorEdadesMayores =0;
            int mayor = 18;

            Console.WriteLine("Ingrese 20 edades: ");
            for (int i = 0; i < veinteEdades.Length; i++)
            {
                
                veinteEdades[i] = Convert.ToInt32(Console.ReadLine());

                if (veinteEdades[i] > mayor)
                {
                    mayoresDeDieciocho.Add(veinteEdades[i]);
                    acumuladorEdadesMayores += veinteEdades[i];

                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Los mayores de 18 son: ");

            foreach (var edad in mayoresDeDieciocho)
            {
                Console.WriteLine(edad);
            }

            double promedioEdadesMayores = acumuladorEdadesMayores/ mayoresDeDieciocho.Count;

            Console.WriteLine("Promedio de los mayores de 18: " + promedioEdadesMayores);
            */

            //4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio
            //si el mismo es primo o no es primo.
            //Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo. 


            /**
            int rta = 1, contCeros = 0;
            List<double> divisores = new List<double>();
            double resto;
            List <double> mods = new List<double>();

            while (rta == 1) 
            { 
            Console.WriteLine("Ingrese UN número para calcular si es primo: ");
            double num = Convert.ToInt32(Console.ReadLine());

                for(int i = 1; i <= 100; i++)
                {
                    // Se guardan los restos de las divisiones numero "num" del 1 al 100 en la lista mods.
                    resto = num % i;
                    
                    mods.Add(resto);

                    // Si el resto es 0 es divisor de num y se agrega a la lista de divisores.
                    if (resto == 0)
                    {
                        divisores.Add(i);
                    }
                }

                // Se calculan cuantos restos igual a 0 se encontraron en las divisiones.
                for (int i = 1; i < mods.Count; i++)
                {
                    if (mods[i] == 0)
                    {
                        contCeros += 1;
                    }
                }
                

                Console.WriteLine(" ");
                // Si hubieron mas de 2 restos iguales a 0 entonces el numero no fue primo.
                if (divisores.Count > 2 )
                {
                    
                    Console.WriteLine("El número NO ES PRIMO. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sus divisores son: " );

                    foreach (var div in divisores)
                    {
                        Console.WriteLine(div);
                    }
                }
                else 
                {
                    Console.WriteLine("El número ES PRIMO. ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Sus divisores son: ");

                    foreach (var div in divisores)
                    {
                        Console.WriteLine(div);
                    }
                }

            Console.WriteLine(" ");

            Console.WriteLine("Volver a ingresar un número? 1 = si, 0 = no ");

            rta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" ");
                mods.Clear();
                divisores.Clear();
            }
            **/

            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo
            //de los números pares y el mínimo de los números impares.
            double num;
            double[] veinteNumeros = new double[20];
            List<double> pares = new List<double>();
            List<double> impares = new List<double>();

            double mayorPares = 0;
            double menorImpares = 999999;

            Console.WriteLine("Ingrese 20 números: ");

            for (int i = 0; i < veinteNumeros.Length; i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                veinteNumeros[i] = num;
                
              if (num % 2 == 0)
                {
                    pares.Add(num);

                }
              else
                {
                    impares.Add(num);
                }
            }
                
            // Se recorre la lista pares. Si el elemento es mayor al anterior se guarda en mayorPares.
            for (int i = 0; i < pares.Count; i++ )
            {
                if (pares[i] > mayorPares)
                {
                    mayorPares = pares[i];
                }
            }
            // Se recorre la lista impares. Si el elemento es menor al anterior se guarda en menorImpares.
            for (int i = 0; i < impares.Count; i++)
            {
                if (impares[i] < menorImpares)                
                {
                    menorImpares = impares[i];
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Todos los pares:");
            foreach (var par in pares)
            {
                Console.WriteLine(par);
            }
            Console.WriteLine("");

            Console.WriteLine("Todos los impares:");
            foreach (var impar in impares)
            {
                Console.WriteLine(impar);
            }
            Console.WriteLine("El MÁXIMO de los números pares es: " + mayorPares);
            Console.WriteLine(" ");
            Console.WriteLine("El MÍNIMO de los números impares: " + menorImpares);
        }
    }
}

