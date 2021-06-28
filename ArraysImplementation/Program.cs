using System;

namespace ArraysImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Array1();
            MultiDimenionalArray();
            JaggedArray();
        }

        private static void Array1()
        {
            int[] arrayOne = { 3, 6, 8, 9, 2 };
            foreach(var element in arrayOne)
            {
                Console.WriteLine(element);
            }

            for (int i = 0; i< arrayOne.Length; i++)
            {
                Console.WriteLine(arrayOne[i]);
            }

            
        }

        private static void MultiDimenionalArray()
        {
            string[,] multiDim= { { "a", "b", "c" }, { "c", "d", "e" } };

            for(int i = 0; i<multiDim.GetLength(0); i++)
            {
                for (int j=0; j<multiDim.GetLength(1); j++)
                {
                    Console.WriteLine(multiDim[i, j]);
                }
            }
            
        }

        private static void JaggedArray()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5, 6 };
            jaggedArray[2] = new int[] { 7, 5, 3 };
            jaggedArray[3] = new int[] { 4, 5, 9 };

            for( int i = 0; i< jaggedArray.Length; i++)
            {
                for (int j = 0; j<jaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"{jaggedArray[i][j]}");
                }
            }
            Console.ReadKey();

        }
    }
}
