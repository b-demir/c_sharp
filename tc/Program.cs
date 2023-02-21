using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T.C. KİMLİK NUMARASINI GİRİN : ");
            string no = Console.ReadLine();
            int[] tc = new int[11];
            for (int i = 0; i < tc.Length-1; i++)
            {
                tc[i] = Convert.ToInt32(char.GetNumericValue(no[i]));
            }
            if (tc.Length==11)
            {
                if (tc[0]!=0)
                {
                    int toplam = 0;
                    for (int i = 0; i < tc.Length - 1; i++)
                    {
                        toplam += Convert.ToInt32(tc[i]);
                    }
                    if (toplam%10==tc[10])
                    {
                        int tek = 0, cift = 0;
                        for (int i = 0; i < tc.Length-2; i+=2)
                        {
                            tek += tc[i];
                        }
                        for (int i = 1; i < tc.Length-2; i+=2)
                        {
                            cift += tc[i];
                        }
                        int kontrol = ((tek * 7) - cift) % 10;
                        if (kontrol==tc[9])
                        {
                            Console.WriteLine("T.C. kimlik numarası doğru!");
                        }
                        else
                        {
                            Console.WriteLine("T.C. kimlik numarası yanlış!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("T.C. kimlik numarası yanlış!");
                    }
                }
                else
                {
                    Console.WriteLine("İlk rakam 0 olamaz!");
                }
            }
            else
            {
                Console.WriteLine("T.C. kimlik no 11 haneli olmalı!");
            }
            Console.ReadKey();
        }
    }
}
