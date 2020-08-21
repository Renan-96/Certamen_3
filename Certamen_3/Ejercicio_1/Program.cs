using System;
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
            //Aqui va la parte de renan
        }


    }
}
