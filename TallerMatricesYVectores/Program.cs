namespace TallerMatricesYVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna*/
            int[,] numeros= new int [10,20];//El rango va a ser de 200 posiciones.
            Random rnd= new Random();
            int suma = 0;
            
            
            int num = rnd.Next(10, 35);
            for (int i = 0; i< 10 ; i++)
            {
                for(int j = 0; j<20 ; j++)
                {
                    numeros[i, j] = rnd.Next(0, 10);
                    Console.Write(numeros[i, j] + " ");

                }
                Console.WriteLine();

            }

            for(int j=0; j<20; j++)
            {
                suma = 0;
                for (int i = 0;i< 10; i++)
                {
                    suma = numeros[i, j] + suma;
                   
                }
                Console.WriteLine( suma );
                
            }
           
          

            
        }

        


        
    }
}
