using System.Diagnostics;
using DSA_Lib;
namespace DataStructuresandAlgosC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArraysDemo();
            Test1BasedArray();
            MultiDimensional();
        }
        private static void ArraysDemo()
        {
            //arrays are not dynamic
            Console.WriteLine("ArraysDemo method Below");
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

            int[] a4 = { 1, 7, 3, 9, 7 };

            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write($"{a3[i]} ");
            }
            Console.WriteLine();
            foreach (var item in a4)
            {
                Console.Write($"{item} ");
            }

            Array myArray = new int[5];

            Array myArray2 = Array.CreateInstance(typeof(int), 5);
            //when you set the value 
            myArray2.SetValue(4, 1);


        }
        private static void Test1BasedArray()
        {
            Console.WriteLine("\n\nTest1BasedArray method Below");

            Array myBasedArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });

            myBasedArray.SetValue(2019, 1);
            myBasedArray.SetValue(2020, 2);
            myBasedArray.SetValue(2021, 3);
            myBasedArray.SetValue(2022, 4);


            Console.WriteLine($"Starting Index: {myBasedArray.GetLowerBound(0)}");
            Console.WriteLine($"Starting Index: {myBasedArray.GetUpperBound(0)}");
            //this how to iterate over this type of array
            for (int i = myBasedArray.GetLowerBound(0); i < myBasedArray.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine($"{myBasedArray.GetValue(i)} at index {i}");
            }


        }
        private static void MultiDimensional()
        {
            Console.WriteLine("\nMultiDimensional method Below");

            int[,] r1 = new int[3, 3] {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            int[,] r2 = new int[,] {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for (int i = 0; i < r2.GetLength(0); i++)
            {
                for (int j = 0; j < r2.GetLength(1); j++)
                {
                    Console.Write($"{r2[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}