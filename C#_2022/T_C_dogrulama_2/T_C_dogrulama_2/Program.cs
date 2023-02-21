using System;

namespace T_C_dogrulama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T.C. kimlik numaranızı giriniz : ");
            string no = Console.ReadLine();
            int[] tc = new int[11];
            int toplam = 0, tsayac = 0, csayac = 0, cttoplam = 0;
            for (int i = 0; i < tc.Length; i++)
            {
                tc[i] = Convert.ToInt32(char.GetNumericValue(no[i]));
                Console.WriteLine(tc[i]);
            }
            foreach (int say in tc)
            {
                toplam += say;
            }
            toplam -= tc[10];
            Console.WriteLine(toplam);
            for (int i = 0; i < tc.Length - 2; i++)
            {
                if (i % 2 == 0)
                {
                    tsayac += tc[i];
                }
                else
                {
                    csayac += tc[i];
                }
            }
            cttoplam = (tsayac * 7) - csayac;
            Console.WriteLine(tsayac);
            Console.WriteLine(csayac);
            Console.WriteLine(cttoplam);
            if (tc.Length == 11 && tc[0] != 0 && tc[10] == toplam % 10 && tc[9] == cttoplam % 10 && tc[10] % 2 == 0)
            {
                Console.WriteLine("T.C. kimlik numarası doğru!");
            }
            else
            {
                Console.WriteLine("T.C. kimlik numarası yanlış!");
            }
        }
    }
}
