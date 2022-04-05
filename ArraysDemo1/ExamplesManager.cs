using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo1
{
    class ExamplesManager
    {
        public void CreateLinearArray()
        {
            Console.WriteLine("\n> Создание одномерных массивов (линейных)");
            int[] A = new int[10];
            foreach (int x in A) // для каждого i в массиве X
                Console.Write($" {A[x]}");
            // 2->
            Console.Write("\n> Сколько у Вас чисел? - ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[N];
            for(int i = 0; i < N; i++)
            {
                Console.Write($" {i + 1} -> ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int x in B) // для каждого i в массиве X
                Console.Write($" {x}");
            Console.Write("\n");
            // 3->
            Random r = new Random();
            Console.Write("\n> Введите размер массива: ");
            int K = Convert.ToInt32(Console.ReadLine());
            int[] C = new int[K];
            for (int i = 0; i < K; i++)
                C[i] = r.Next(10, 99);
            foreach (int x in C) // для каждого i в массиве X
                Console.Write($" {x}");
            Console.Write("\n");
        }
        // ===========
        public void CreateTwoDimArray()
        {
            Console.WriteLine("\n> Создание двумерных массивов (матриц)");
            int rows = 3;
            int cols = 4;
            int[,] M = new int[rows, cols];

            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    M[i, j] = r.Next(10, 99);
                    Console.Write($"{M[i, j], 3}");
                }
                Console.WriteLine("");
            }
            // 3
            Console.WriteLine("");
            int[,] N = new int[,] {
                {10, 20, 30, 40 },
                {50, 60, 70, 80 },
                {100, 200, 300, 400 },
            };
            //DisplayMatrix(N, 3, 4);
            // 4
            Console.WriteLine("");
            int[,] A = new int[3, 3] {
                {11, 12, 13 },
                {14, 15, 16 },
                {17, 18, 19 },
            };
            DisplayMatrix(A, 3, 3);
            Console.WriteLine("\n    +  ");
            int[,] B = new int[3, 3] {
                {21, 22, 23 },
                {24, 25, 26 },
                {27, 28, 29 },
            };
            DisplayMatrix(B, 3, 3);
            Console.WriteLine("\n    =  ");
            // Вывод на экран
            int[,] C = AddMatrix(A, B, 3, 3);
            DisplayMatrix(C, 3, 3);
        }
        public int[,] AddMatrix(int[,] X, int[,] Y, int rows, int cols)
        {
            int[,] C = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    C[i, j] = X[i, j] + Y[i, j];
                }
            }
            return C;
        }
        public void DisplayMatrix(int[,] X, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                    Console.Write($"{X[i, j], 3}");
                Console.WriteLine("");
            }
        }

        // ===========
        public void CreateInlineArray()
        {
            Console.WriteLine("\n> Создание вложенных массивов (зубчатых)");
            int[][] A = new int[5][]
            {
                new int[] {1 },
                new int[] {2, 2 },
                new int[] {3, 3, 3 },
                new int[] {4, 4, 4, 4 },
                new int[] {5, 5, 5, 5, 5}
            };
            DisplayInlineArray(A, 5);
            TriangleMatrix(7); //вывод на экран 
        }
        public void TriangleMatrix(int rows)
        {
            for (int i = rows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i, 2}");
                }
                Console.WriteLine("");
            }
        }
        public void DisplayInlineArray(int[][] X, int rows)
        {
            for( int i = 0; i < rows; i++)
            {
                for(int j = 0; j < X[i].Length; j++)
                {
                    Console.Write($"{X[i][j], 4} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
