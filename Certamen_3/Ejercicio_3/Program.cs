using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] usuario = new string[1000, 4];
            int usuarios = 0;
            bool flag = true;

            Console.WriteLine("Bienvenido");

            Console.Write("Cuantos usuarios quiere crear: ");
            usuarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < usuarios; i++)
            {
                Console.Write("Usuario {0} Ingrese su Nombre: ", i + 1);
                usuario[i, 0] = Console.ReadLine();

                Console.Write("Usuario {0} Ingrese su Apellido: ", i + 1);
                usuario[i, 1] = Console.ReadLine();

                while (flag)
                {
                    Console.WriteLine("M = Masculino, F = Femenino  ");
                    Console.Write("Usuario {0} Ingrese su Sexo: ", i + 1);
                    usuario[i, 2] = Console.ReadLine();

                    if (usuario[i, 2] == "m" || usuario[i, 2] == "f" || usuario[i, 2] == "F" || usuario[i, 2] == "M")
                    {
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Intente nuevamente solo se permite M o F");
                    }
                }
                flag = true;

                Console.Write("Usuario {0} Ingrese su Año de Nacimiento: ", i + 1);
                usuario[i, 3] = Console.ReadLine();
            }

            for (int i = 0; i < usuarios; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Usuario:{0} Nombre:{1} Apellido:{2} Sexo:{3} Año de Nacimiento:{4}", i + 1, usuario[i, 0], usuario[i, 1], usuario[i, 2], usuario[i, 3]);
            }
            Console.ReadKey();

        }
    }
}
