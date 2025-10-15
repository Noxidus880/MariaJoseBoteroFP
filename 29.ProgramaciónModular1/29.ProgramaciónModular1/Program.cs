namespace _29.ProgramaciónModular1
{
    internal class Program
    {
        //29. Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
        //Un diagrama de módulo no es lo mismo que un diagrama de flujo.
        //Los parámetros son datos que los módulos necesitan para poder funcionar.


        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            BorrarPantalla();
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        //Módulo-Procedimiento que borra lo que hay en la pantalla(consola).
        static void BorrarPantalla()
        {
           Console.Clear();
        }
        //Módulo-Procedimiento que recibe la matriz que se va a mostrar en pantalla.
        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
            for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");

                }
               Console.WriteLine();

            }
        }


        //Módulo -Función que recibe la matriz a llenar y la devuelve con múltiplos de cinco.
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int número = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        BorrarPantalla();
                        Console.WriteLine("Ingrese un número para almacenar en la matriz");
                        número = int.Parse(Console.ReadLine());
                    } while (EsMultiplo5(número) == false);

                    matriz[i, j] = número;
                }

            }
            return matriz;
        }
        //Módulo-Función que comprueba que el número es múltiplo de 5.
        static bool EsMultiplo5(int número)
        {
            if (número % 5 == 0 && número != 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, el número ingresado no es múltiplo de 5");
                return false;
            }

        }

        //Módulo-Función que le pregunta al usuario por el número de filas de la matriz y lo devuelve.
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas para la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }
        //Módulo-Función que le pregunta al usuario por el número de columnas de la matriz y lo devuelve.
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

    }
  }



