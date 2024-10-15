using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _233536_visual_prog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];


            //for (int i = 0; i < arr.Length; i++)

            //{
            //    Console.WriteLine("enter value at the indes : " + i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(" \n your enter values are " + " \n");
            //foreach (int item in arr)
            //{

            //    Console.WriteLine(item);

            //}
            //Console.ReadLine();


            //{

            //}
            //int[][] arr = new int[4][];
            //int a;
            //arr[0] = new int[2] { 1, 2 };
            //arr[1] = new int[4] {1,1, 1, 2 };
            //arr[2] = new int[6] {2,4,4,2, 1, 2 };
            //arr[3] = new int[3] { 0,1, 2 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Elements : ");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j]+ "\t" );

            //    }
            //    Console.Write("\n");


            //}
            //Console.ReadLine();

            int[,] array = new int[3,3];
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j< 3; j++)
                {
                    Console.Write("\n enter the value at row " + i + "and coloumn " + j + " : ");

                    array[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\n the value at row "+i +"and coloumn "+ j+ " : ");
                    Console.Write(array[i,j]);
                    
                }
                Console.Write("\n");

            }
            Console.ReadLine    ();
        }
    }
}
