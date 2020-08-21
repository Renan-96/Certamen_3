﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio_1");
            Console.WriteLine();
            ejerciocio_1();
            Console.WriteLine();
            Console.WriteLine("Ejercicio_2");
            Console.WriteLine();
            ejercicio_2();
            Console.WriteLine();
            Console.WriteLine("Ejerciocio_3");
            Console.WriteLine();
            ejercicio_3();
            Console.ReadKey();
        }

        static void matriz1(int Y,int X)
        {           
            int[] Vector = new int[X];
            int[] Vector2 = new int[Y];
            for (int i = 1; i <= Vector.Length; i++)//Y
            {
                if (i == Vector.Length)
                {
                    for (int k = 0; k < Vector2.Length; k++)
                    {
                        Console.Write("1");
                    }
                }
                else
                {
                    Console.Write("1");
                    for (int j = 2; j < Vector2.Length; j++)//X
                    {
                        if (i == 1)
                        {
                            Console.Write("1");
                        }
                        else
                        {
                            Console.Write("0");
                        }
                    }
                    Console.Write("1");
                    Console.WriteLine("");
                }
            }
            Console.WriteLine();
        }

        static void matriz2(int Y, int X) {

            int[,] num = new int[X, Y];
            int veces = num.GetLength(1) - 1;
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        num[i, j] = 1;
                    }
                    else
                    {
                        if (i == veces)
                        {
                            num[i, j] = 1;
                        }
                        else
                        {
                            num[i, j] = 0;
                        }
                    }
                    Console.Write(num[i, j]);
                    veces=veces-1;
                }
                Console.WriteLine();
                veces = num.GetLength(1) - 1;
            }
        }

        static void matriz3(int Y,int X)
        {
            int[] Vector = new int[X];
            int[] Vector2 = new int[Y];
            for (int i = 1; i <= Vector.Length; i++)
            {
                for (int j = 1; j <= Vector2.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }

        static void matriz4(int Y, int X)
        {
            int[] Vector = new int[X];
            int[] Vector2 = new int[Y];
            for (int i = 1; i <= Vector.Length; i++)
            {
                for (int j = 1; j <= Vector2.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }

        static void ejerciocio_1()
        {
            int Y = 0, X = 0;

            bool bucle = true;
            bool bucle2 = true;
            while (bucle2==true)
            {
                string NY;
                try
                {
                    while (bucle == true)
                    {
                        try
                        {
                            Console.Write("MATRIZ Y: ");
                            X = int.Parse(Console.ReadLine());
                            int[] Vector = new int[X];
                            Console.Write("MATRIZ X: ");
                            Y = int.Parse(Console.ReadLine());
                            int[] Vector2 = new int[Y];
                            if (X > 0 && Y > 0)
                            {
                                bucle = false;
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error, Solo ingresar numeros enteros");

                        }
                    }
                    matriz1(Y, X);
                    Console.WriteLine();
                    matriz2(Y, X);
                    Console.WriteLine();
                    matriz3(Y, X);
                    Console.WriteLine();
                    matriz4(Y, X);
                    Console.WriteLine();

                    Console.WriteLine("Quiere intentar otra matriz? No=N Si=S");
                    NY = Console.ReadLine();
                    if (NY=="N"||NY=="n")
                    {
                        bucle2 = false;
                    }
                    else if (NY=="S"||NY=="s")
                    {
                        Console.WriteLine("Ok");
                        bucle = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo ingresar N o S"); 
                }
            }            
        }

        static void ejercicio_2()
        {
            int numM = 0;
            Console.Write("Cuantos numeros quiere ingresar: ");
            numM = int.Parse(Console.ReadLine());
            int[] Vector = new int[numM];
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.Write("Numero de la posicion {0}: ", (i + 1));
                Vector[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < Vector.Length; j++)
            {
                if (j == 0)
                {
                    Console.WriteLine("El numero menor es: {0}", Vector[j]);
                }
                if (j == (Vector.Length - 1))
                {
                    Console.WriteLine("el numero mayor es: {0}", Vector[j]);
                }
            }
            Console.ReadKey();
        }

       

        static void ejercicio_3()
        {
            string[,] usuario = new string[1000, 4];
            int usuarios = 0;
            bool flag = true;
            int contadorf = 0;
            int contadorm = 0;
            int mayor = 0;
            int menor = 0;


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
            for (int i = 0; i < usuarios; i++)
            {
                Console.WriteLine();

                if (usuario[i, 2] == "f" || usuario[i, 2] == "F")
                {
                    contadorf++;
                }
                else
                {
                    contadorm++;
                }
            }
            for (int i = 0; i < usuarios; i++)
            {


                if (int.Parse(usuario[i, 3]) <= 2002)
                {
                    mayor++;
                }
                else
                {
                    menor++;
                }
            }
            Console.WriteLine("Los usuarios Femeninos ingresados son: " + contadorf);
            Console.WriteLine("Los usuarios Masculinos ingresados son: " + contadorm);
            Console.WriteLine();
            Console.WriteLine("Los usuarios Mayores de edad ingresados son: " + mayor);
            Console.WriteLine("Los usuarios Menores de edad ingresados son: " + menor);
            Console.ReadKey();
        }


    }
}
