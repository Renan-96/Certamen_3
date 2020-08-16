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
            int Y=0,X=0;
            Console.Write("MATRIZ X: ");
            X=int.Parse(Console.ReadLine());
            int[] Vector = new int[X];

            Console.Write("MATRIZ Y: ");
            Y = int.Parse(Console.ReadLine());         
            int[] Vector2 = new int[Y];

            for (int i = 1; i <=Vector.Length; i++)//Y
            {
                if (i==Vector.Length)
                {
                    for (int k =0; k < Vector.Length; k++)
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
            Console.ReadKey();
        }
       
    }
}
