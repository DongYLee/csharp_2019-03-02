using System;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //가변배열, 처음방에는 1,2 두번째방에는 1,2,3 세번째방에는 1,2,3,4
            int[][] a = { new int[] { 1, 2 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 } };

            //3행 2열, 이차원배열 1행은 (1,2), 2행은 (3,4), 3행은 (5,6)
            int[,] b = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //가변배열 출력
            foreach (int[] i in a)
            {
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
            }
            Console.WriteLine("\n---------------\n");
            foreach (int i in b)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n---------------\n");


            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i=0; i < twoDim.GetLength(0); i++)
            {
                for (int j=0; j < twoDim.GetLength(1); j++)
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach (int i in twoDim)
            {
                Console.Write(i);
            }


            Console.WriteLine(string.Join(" ", Method()));



            string[] arr = new string[]
                {"가", "나", "다", "라" };
            Console.WriteLine(arr[arr.Length - 1]);
            Console.WriteLine(arr[arr.GetLength(0) - 1]);
        }

        static string[] Method()
        {
            string[] array = new string[2];
            array[0] = "대한민국";
            array[1] = "서울";
            return array;
        }
          
    }
}
