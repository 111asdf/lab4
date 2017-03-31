using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace lab4
{
    class Arrs
    {
        private static Random rnd = new Random();

        public static void CreateOneDimAr(int[] mas)
        {
            for (int i = 0; i < mas.Length; ++i)
            {
                mas[i] = rnd.Next() % 100;
            }
        }

        public static void PrintArr(string name, int[] arr)
        {
            Console.Write(name + " : {");
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine("}");
        }

        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i, Console.WriteLine())
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
        }

        public static void CreateArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = rnd.Next() % 100;
                }
            }
        }

        public static void PrintArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; ++i, Console.WriteLine())
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write(arr[i][j] + " ");
                }
            }
        }

        public static void CreateArr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    arr[i][j] = rnd.Next() % 100;
                }
            }
        }
        //////////////////////////////////////////////////
        public static void PrintAnyArr(Array arr)//Лаб.4 Зад.1
        {
            switch (arr.Rank)
            {
                case 1:
                    for (int i = 0; i < arr.GetLength(0); ++i)
                    {
                        if (arr.GetValue(i).GetType() == typeof(Array)) PrintAnyArr((Array)arr.GetValue(i));
                        else Console.Write(arr.GetValue(i) + " ");
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    for (int i = 0; i < arr.GetLength(0); ++i, Console.WriteLine())
                    {
                        for (int j = 0; j < arr.GetLength(1); ++j)
                        {
                            if (arr.GetValue(i, j).GetType() == typeof(Array)) PrintAnyArr((Array)arr.GetValue(i, j));
                            else Console.Write(arr.GetValue(i, j) + " ");
                        }
                    }
                    break;
            }
        }

        public static void PrintAnyArr2(Array arr) //Лаб.4 Зад.1
        {
            foreach (var element in arr)
            {
                Console.Write(element + " ");
            }
        }

        public static void TestAllMethods(Array arr)//Лаб.4 Зад.2
        {
            Array b = null;
            Array.Copy(arr, b, arr.GetLength(0));
            arr.CopyTo(b, 0);
            int first0 = Array.IndexOf(arr, 0);
            int last0 = Array.LastIndexOf(arr, 0);
            Array.Reverse(b);
            Array.Sort(b);
            Array.BinarySearch(b, 33);
        }

        public static void PrintArr(Object arr)//Лаб.4 Зад.3
        {
            if (arr.GetType() == typeof(Array))
            {
                foreach (var element in (Array)arr)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine(arr);
        }

        public static void PrintArObj(string name, object[] A)//Лаб.4 Зад.5
        {
            Console.Write(name + " : { ");
            foreach (object item in A)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }

    }
}
