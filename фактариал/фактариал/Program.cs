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
            double fack = 1;
            ulong schet = 0;

            while (!ulong.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Write number correctly");
            }
            //счетчик
            for ( i = 1; i <= n; i++)
            {
                fack *= i;
                while (fack >= 1)
                {
                    schet++;
                    fack /= 10;
                }
            }
            //масив фактариала
            ulong[] arrFack = new ulong[schet];
            ulong j;
            arrFack[schet-1] = 1;
            for (i = 1; i <= n; i++)
            {
                for (j = 0; j < schet; j++)
                {
                    arrFack[j] *= i;
                }
                for (j = 0; j < schet; j++)
                {
                    while (arrFack[schet - 1-j] >= 10)
                    {
                        arrFack[schet - 2 - j] += arrFack[schet - 1 - j] / 10;
                        arrFack[schet - 1 - j] = arrFack[schet - 1 - j] % 10;
                    }
                }
            }           
            Console.WriteLine("Вывод факториала: ");
            for (j = 0; j < schet; j++)
            {
                Console.Write($"{arrFack[j]} ");
            }
        }
    }
}
