using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[10];
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write("İsimler listesinin " + (i + 1) + ". elemanını giriniz : ");
                isimler[i] = Console.ReadLine();
            }
            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            Console.ReadKey();
        }
    }
}
