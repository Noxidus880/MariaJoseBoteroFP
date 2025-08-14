namespace _3.Condicionaless
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Condicional simple 
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine(); // Todo lo que lea la consola va a
                                         // llegar como string
            Console.WriteLine(nombre);
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            { 
                Console.WriteLine($"La persona {nombre} debe abonar impuestos");

            }
                                          

        }
    }
}
