namespace Parcial3FundamentosDeProgramación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa para procesar las notas definitivas de Física de un grupo de 15 estudiantes. Las calificaciones están en un rango de 0.0 a 5.0.
            El programa debe realizar las siguientes tareas:
           Ingresar por teclado la nota final de cada estudiante 
           Calcular el promedio general del grupo.
          Clasificar a cada estudiante según su calificación en una de las siguientes categorías:
          Excelente: nota ≥ 4.8
          Bueno: 4.0 ≤ nota ≤ 4.7
          Regular: 3.0 ≤ nota ≤ 3.9
          Descuidado: nota ≤ 2.9
         Contar y mostrar por pantalla el número total de estudiantes en cada categoría.
         Mostrar en pantalla el promedio del grupo y la cantidad de alumnos clasificados en cada nivel.*/

            float nota = 0.0f;
            float acumuladorGeneral = 0.0f;
            float contadorGeneral = 0;
            float promedioGeneral = 0.0f;
            float promedioExcelente= 0.0f;
            float promedioBueno= 0.0f;
            float promedioRegular= 0.0f;
            float promedioDescuidado= 0.0f;
            int contadorExcelente=0;
            int contadorBueno=0;
            int contadorRegular=0;
            int contadorDescuidado = 0;
            float acumuladorExcelente=0.0f;
            float acumuladorBueno= 0.0f;
            float acumuladorRegular= 0.0f;
            float acumuladorDescuidado=0.0f;

            while (contadorGeneral <= 15)
            {
                Console.WriteLine($"Ingrese su nota final de física");
                nota = float.Parse(Console.ReadLine());
                if(nota>5.0)
                {
                    Console.WriteLine($"La nota ingresada no es válida");

                }
               
               
                contadorGeneral++;
                acumuladorGeneral = nota + acumuladorGeneral;

            }
            promedioGeneral=acumuladorGeneral/contadorGeneral;
            Console.WriteLine($"El promedio general del grupo es {promedioGeneral}");
            do
            {


                if (nota >= 4.8)
                {
                    contadorExcelente++;
                    Console.WriteLine($"Los estudiantes con nota excelente son {contadorExcelente}");
                    acumuladorExcelente = nota + acumuladorExcelente;
                    promedioExcelente = acumuladorExcelente / contadorExcelente;
                    Console.WriteLine($"El promedio del grupo excelente es {promedioExcelente}");
                    Console.WriteLine($"La cantidad de estudiantes con nota excelente son {contadorExcelente}");
                }
                if (nota >= 4.0 || nota <= 4.7)
                {
                    contadorBueno ++;
                    Console.WriteLine($"Los estudiantes con nota buena son {contadorBueno}");
                    acumuladorBueno = nota + acumuladorBueno;
                    promedioBueno = acumuladorBueno / contadorBueno;
                    Console.WriteLine($"El promedio del grupo bueno es {promedioBueno}");
                    Console.WriteLine($"La cantidad de estudiantes con nota buena son {contadorBueno}");

                }
                if (nota >= 3.0 || nota <= 3.9)
                {
                    contadorRegular++;
                    Console.WriteLine($"Los estudiantes con nota regular son {contadorRegular}");
                    acumuladorRegular = nota + acumuladorRegular;
                    promedioRegular = acumuladorRegular / contadorRegular;
                    Console.WriteLine($"El promedio del grupo regular es {promedioRegular}");
                    Console.WriteLine($"La cantidad de estudiantes con nota buena  son {contadorRegular}");
                }
                if (nota <= 2.9)
                {
                   contadorDescuidado ++;
                    Console.WriteLine($"Los estudiantes con nota descuidada son {contadorDescuidado}");
                    acumuladorDescuidado = nota + acumuladorDescuidado;
                    promedioDescuidado=acumuladorDescuidado / contadorDescuidado;
                    Console.WriteLine($"El promedio del grupo descuidado es {promedioDescuidado}");
                    Console.WriteLine($"La cantidad de estudiantes con nota descuidada son {contadorDescuidado}");

                }
                       acumuladorGeneral=contadorExcelente+contadorBueno+contadorRegular+contadorDescuidado;

            } while (acumuladorGeneral<= 15);


        }
    }
}
