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
            int sayi;
            string durum = "ASAL";
            Console.Write("Sayıyı girin: ");
            sayi = int.Parse(Console.ReadLine());

            for(int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    durum = "ASAL DEĞİL";
                    break;
                }
            }
            Console.WriteLine(sayi+" sayısı "+durum);
        }
    }
}
