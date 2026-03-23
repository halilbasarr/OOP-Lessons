using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            hesapla(sayi);

            /*int fibonacci(int n)
            {
                if( n <= 1){
                    return n;
                }

                return fibonacci(n-1) + fibonacci(n-2);

            }*/

             void hesapla(int n)
            {
                int x = 0;
                int y = 1;
                int z;
                Console.Write(x + " " + y);
                for (int i = 1; i <= n; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;
                    Console.Write(" " + z);
                }
            }

        }
    }
}