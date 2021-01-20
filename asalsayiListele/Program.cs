using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalsayiListele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ilk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            for (int i = sayi1; i <= sayi2; i++)
            {
                bool asal = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j==0)
                    {
                        asal = false;
                        break;
                    }
                }
                if (asal == true)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
