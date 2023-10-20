using System;

namespace Массивы2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов оригинального массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] M4 = new int[n];
            Vvod(M4);
            Vivod(M4, "Оригинальный массив");

            if (n % 2 == 0)
            {
                for (int i = 0, j = n / 2; i < n / 2; i++, j++)
                {
                    int buf = M4[i];
                    M4[i] = M4[j];
                    M4[j] = buf;
                }
            }
            else
            {
                for (int i = 0, j = n / 2; i < n / 2; i++, j++)
                {
                    int buf = M4[i];
                    M4[i] = M4[j];
                    M4[j] = buf;
                }
                int buf_last = M4[n - 1];
                for (int i = n - 1; i >= n / 2; i--)
                {
                    M4[i] = M4[i - 1];
                }
                M4[n / 2] = buf_last;
            }
            Vivod(M4, "Результат");
        }
        static void Vvod(int[] M)
        {
            Random r = new Random();
            //foreach (int el in M)
            //{
            //    el = r.Next(100);
            //}

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = r.Next(100);
            }
        }

        static void Vivod(int[] M, string msg)
        {
            if (M == null)
                return;
            else
            {
                Console.WriteLine(msg + ":");
                foreach (int el in M)
                {
                    Console.Write(el.ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
