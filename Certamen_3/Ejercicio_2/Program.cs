using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cantidad de homrbes y mujeres, mayores y menores de edad
            Console.Write("Cantidad de registros :");
            int registros = int.Parse(Console.ReadLine());
            int[] Valumnos= new int[registros];
            int contadorm = 0,contadorf=0;
            for (int i = 0; i < Valumnos.Length; i++)
            {
                bool bucle = true;
                string sexo;
                while (bucle == true)
                {
                    Console.Write("M = Masculino, F = Femenino  ");
                    Console.Write("Ingrese su sexo: ");
                    sexo = Console.ReadLine();

                    if (sexo == "m" || sexo == "f" || sexo == "F" || sexo == "M")
                    {
                        if (sexo=="m"||sexo=="M")
                        {
                            contadorm++;
                        }
                        if (sexo == "f" || sexo == "F")
                        {
                            contadorf++;
                        }
                        bucle = false;
                    }
                    else
                    {
                        Console.WriteLine("Intente nuevamente solo se permite M o F");
                    }
                }
            }
            Console.WriteLine("{0} hombres hay en el curso",contadorm);
            Console.WriteLine("{0} mujeres hay en el curso",contadorf);
            Console.ReadKey();
        }
    }
}
