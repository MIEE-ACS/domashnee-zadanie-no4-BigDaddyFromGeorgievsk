using System;

namespace DZ_4._2
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количсевто строк матрицы : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Введите количсевто столбцов матрицы : ");
            int M = int.Parse(Console.ReadLine());


            Random r = new Random();
            int[,] Mas = new int[N, M];
            for (int i = 0; i < Mas.GetLength(0); ++i)
            {
                for (int j = 0; j < Mas.GetLength(1); ++j)
                {
                    Mas[i, j] = r.Next(-20, 100);
                    Console.Write("{0,4:F0}", Mas[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");


            SummMinus(Mas);
            Console.Read();

            
            SearchSedl(Mas);
            Console.Read();
                    

        }
        static void SummMinus(int[,] Mas)
        {
            int sum = 0;
            bool hasminus = false;
            for (int i = 0; i < Mas.GetLength(0); ++i)
            {
                for (int j = 0; j < Mas.GetLength(1); ++j)
                {
                    sum += Mas[i, j];
                    if (Mas[i, j] < 0) hasminus = true;
                }
                if (hasminus) { Console.WriteLine("В строке № {0} сумма элементов {1}", i + 1, sum); hasminus = false; }
            }
            Console.WriteLine("\nНажмите ENTER для дальшнейших действий:");
        }


        static void SearchSedl(int[,] Mas)
        {
            int minInd;
            int maxInd;

            for (int i = 0; i < Mas.GetLength(0); ++i)
            {
                minInd = 0;
                maxInd = 0;
                for (int j = 0; j < Mas.GetLength(1); ++j)
                {
                    if (Mas[i, j] < Mas[i, minInd]) minInd = j;
                }

                for (int k = 0; k < Mas.GetLength(0); ++k)
                {

                    if (Mas[k, minInd] > Mas[maxInd, minInd]) maxInd = k;
                }

                if (maxInd == i) Console.WriteLine("Седловая точка - элемент {0} : {1}", minInd + 1, maxInd + 1);
                else 
                {
                    Console.WriteLine("В строке № {0} Седловых точек нет!", i + 1);
                }

            }
        }
    }
}