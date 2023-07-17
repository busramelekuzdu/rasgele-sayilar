using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rasgele_sayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0, sayac = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int sayi = rnd.Next(1, 100);
                Console.WriteLine(sayi);
                if (sayi > 50)
                {
                    toplam += sayi;
                    sayac++;
                }
            }
            Console.WriteLine("50 den büyük sayıların ortalaması :{0} ", (toplam / sayac));
            Console.ReadKey();
        }
    }
}
