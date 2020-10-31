using System;
using System.Net;

namespace фактариал
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong n;
            ulong i;
         
            double f = 1;
            ulong schet = 0;

            while (!ulong.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Write number corectly");
            }
           
         
            //счетчик
            for ( i = 1; i <= n; i++)
            {
                f *= i;


                while (f >= 1)
                {
                    schet++;
                    f /= 10;
                }

            }
           
            //масив фактариала
            ulong[] arr_fack = new ulong[schet];
            ulong j;
            arr_fack[schet-1] = 1;
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j < schet; j++)
                {
                    arr_fack[j] *= i;
                }
                for (j = 0; j < schet; j++)
                {
                    while (arr_fack[schet - 1-j] >= 10)
                    {
                        arr_fack[schet - 2 - j] += arr_fack[schet - 1 - j] / 10;
                        arr_fack[schet - 1 - j] = arr_fack[schet - 1 - j] % 10;
                    }
                }

            }

           
            Console.WriteLine("Вывод факториала: ");
            for (j = 0; j < schet; j++)
            {
                Console.Write($"{arr_fack[j]} ");
            }


        }
    }
}
