namespace Parcial3MatricesYVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolla un programa que permita registrar y analizar las ventas de computadores en una red de
          * cinco almacenes durante los siete días de una semana. Para ello, se utilizará 
          * una matriz bidimensional Ventas[5][7], donde cada fila representa un almacén y cada columna un día de la semana (de lunes a domingo).
          *1. Ingreso de datos con validación:
           Permitir al usuario ingresar las ventas diarias de cada almacén (valores enteros no negativos).
           Validar que los datos ingresados sean numéricos y mayores o iguales a cero. Si el usuario ingresa un valor inválido, solicitar el dato nuevamente.
           2.Visualización de la matriz:
          Mostrar por pantalla la matriz de ventas en forma tabular.
         3. Cálculos estadísticos:
          Calcular y mostrar el promedio semanal de ventas por cada almacén (promedio por fila).
          Calcular y mostrar el promedio de ventas por día, específicamente para:
          Lunes (columna 0)
         Viernes (columna 4)
         Mostrar el valor mínimo y máximo de ventas registrados en toda la matriz, e indicar en qué almacén y qué día ocurrieron.
         3.Calcular los siguientes datos:
         Determinar cuál fue el almacén con mayor promedio de ventas durante la semana.
         Determinar cuál fue el día de la semana con mayores ventas totales entre todos los almacenes.*/

            int[,] ventas = new int[5, 7];
            int dias=0;
            int almacenes=0;
            string nombresDias = "";
            double[] promediosAlmacen = new double[almacenes];
            int minVenta = ventas[0, 0], maxVenta = ventas[0, 0];
            int minAlmacen = 0, minDia = 0, maxAlmacen = 0, maxDia = 0;
            int mejorAlmacen = 0;
            double mejorPromedio = promediosAlmacen[0];
            int mejorDia = 0;
            int mayorTotalDia = 0;





            Console.WriteLine();
           
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese las ventas del almacén {i + 1} para el día {j + 1}: ");
                    string input = Console.ReadLine();
                    int venta;
                    while (!int.TryParse(input, out venta) || venta < 0)
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero no negativo:");
                        input = Console.ReadLine();
                    }
                    ventas[i, j] = venta;
                }
            }

            
            Console.WriteLine("\nMatriz de ventas (Almacenes x Días):");
            Console.Write("Almacén\\Día\t");
            foreach (var dia in nombresDias)
                Console.Write(dia + "\t");
            Console.WriteLine();
            for (int i = 0; i < almacenes; i++)
            {
                Console.Write($"Almacén {i + 1}\t");
                for (int j = 0; j < dias; j++)
                {
                    Console.Write(ventas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPromedio semanal de ventas por almacén:");
           
            for (int i = 0; i < almacenes; i++)
            {
                int suma = 0;
                for (int j = 0; j < dias; j++)
                    suma += ventas[i, j];
                promediosAlmacen[i] = (double)suma / dias;
                Console.WriteLine($"  Almacén {i + 1}: {promediosAlmacen[i]:0.00}");
            }

            Console.WriteLine("\nPromedio de ventas por día:");
            for (int d = 0; d < dias; d++)
            {
                if (d == 0 || d == 4) 
                {
                    int suma = 0;
                    for (int i = 0; i < almacenes; i++)
                        suma += ventas[i, d];
                    double promedio = (double)suma / almacenes;
                    Console.WriteLine($"  {nombresDias[d]}: {promedio:0.00}");
                }
            }

            
            
            for (int i = 0; i < almacenes; i++)
            {
                for (int j = 0; j < dias; j++)
                {
                    if (ventas[i, j] < minVenta)
                    {
                        minVenta = ventas[i, j];
                        minAlmacen = i;
                        minDia = j;
                    }
                    if (ventas[i, j] > maxVenta)
                    {
                        maxVenta = ventas[i, j];
                        maxAlmacen = i;
                        maxDia = j;
                    }
                }
            }
            Console.WriteLine($"\nVenta mínima: {minVenta} (Almacén {minAlmacen + 1}, {nombresDias[minDia]})");
            Console.WriteLine($"Venta máxima: {maxVenta} (Almacén {maxAlmacen + 1}, {nombresDias[maxDia]})");

            
           
            for (int i = 1; i < almacenes; i++)
            {
                if (promediosAlmacen[i] > mejorPromedio)
                {
                    mejorPromedio = promediosAlmacen[i];
                    mejorAlmacen = i;
                }
            }
            Console.WriteLine($"\nAlmacén con mayor promedio semanal: Almacén {mejorAlmacen + 1} ({mejorPromedio:0.00})");

            
           
            for (int d = 0; d < dias; d++)
            {
                int suma = 0;
                for (int i = 0; i < almacenes; i++)
                    suma += ventas[i, d];
                if (suma > mayorTotalDia)
                {
                    mayorTotalDia = suma;
                    mejorDia = d;
                }
            }
            Console.WriteLine($"Día con mayores ventas totales: {nombresDias[mejorDia]} ({mayorTotalDia})");




        }
    }
}
