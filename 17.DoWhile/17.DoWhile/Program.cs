namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que genera y suma los primeros 5 números enteros 
            int contador = 0;
            int acumulador = 0;
            

            do
            {
                contador++;
                acumulador = acumulador + contador;


            } while (contador < 5);
            Console.WriteLine($"La suma de los primeros 5 números enteros es {acumulador}");

            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1
            //hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            int num = 0;
            int contador2 = 1;
            string respuesta = "";

            do
            {
                Console.WriteLine($"Ingrese el número del cual quiere la tabla de multiplicar");
                num = int.Parse(Console.ReadLine());

                do
                {
                    contador2++;
                    Console.WriteLine($"{num}X{contador2}={num * contador}");

                } while (contador2 < 10);
                contador2 = 1;

                Console.WriteLine($"Desea generar otra tabla de multiplicar?; s:si; n:no");
                respuesta = Console.ReadLine().ToLower();//Para que si el usuario ingresa la respuesta en mayuscula,la consola la convierta a minuscula para poder entenderla.
            } while (respuesta == "s");
           

        }
    }
}
