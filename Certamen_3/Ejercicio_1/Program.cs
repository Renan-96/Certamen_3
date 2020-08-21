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
            Console.WriteLine("Ejercicio1");
            Console.WriteLine("MATRIZ 1 ");
            matriz1();
            Console.WriteLine();
            Console.WriteLine("MATRIZ 2 ");
            matriz2();
            Console.WriteLine();
            Console.WriteLine("MATRIZ 3 ");
            matriz3();
            Console.WriteLine();
            Console.WriteLine("MATRIZ 4 ");
            matriz4();
            Console.WriteLine("Ejercicio2");
            ejercicio_2();
        }

        static void matriz1()
        {
            int Y = 0, X = 0;
            Console.Write("MATRIZ Y: ");
            X = int.Parse(Console.ReadLine());
            int[] Vector = new int[X];
            Console.Write("MATRIZ X: ");
            Y = int.Parse(Console.ReadLine());
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

        static void matriz2() {
            int Y = 0, X = 0;
            Console.Write("MATRIZ Y: ");
            X = int.Parse(Console.ReadLine());
            Console.Write("MATRIZ X: ");
            Y = int.Parse(Console.ReadLine());


            int[,] vec = new int[X, Y];
            int cantidad = vec.GetLength(1) - 1;

            for (int i = 0; i < vec.GetLength(0); i++)
            {
                for (int j = 0; j < vec.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        vec[i, j] = 1;
                    }
                    else
                    {
                        if (i == cantidad)
                        {
                            vec[i, j] = 1;
                        }
                        else
                        {
                            vec[i, j] = 0;
                        }
                    }
                    Console.Write(vec[i, j]);
                    cantidad--;
                }
                Console.WriteLine("");
                cantidad = vec.GetLength(1) - 1;
            }
            Console.ReadKey();
        }

        static void matriz3()
        {
            int Y = 0, X = 0;
            Console.Write("MATRIZ Y: ");
            X = int.Parse(Console.ReadLine());
            int[] Vector = new int[X];
            Console.Write("MATRIZ X: ");
            Y = int.Parse(Console.ReadLine());
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
            Console.ReadKey();
        }

        static void matriz4()
        {
            int Y = 0, X = 0;
            Console.Write("MATRIZ Y: ");
            X = int.Parse(Console.ReadLine());
            int[] Vector = new int[X];
            Console.Write("MATRIZ X: ");
            Y = int.Parse(Console.ReadLine());
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
            Console.ReadKey();
        }

        static void ejercicio_2()
        {
            int numM = 0;
            Console.Write("Ingrese cantidad de numeros :");
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

        static void salida(){



        }

        static void ejercicio_3()
        {
            //Aqui va la parte de renan
        }


    }
}
