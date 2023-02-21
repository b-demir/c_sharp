using System;

namespace T_C_dogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("T.C. kimlik numarasını giriniz : ");
            string no = Console.ReadLine();
            int[] tc = new int[11];
            for (int i = 0; i < tc.Length; i++)
            {
                tc[i] = Convert.ToInt32(char.GetNumericValue(no[i]));
                Console.WriteLine(tc[i]);
            }
            int toplam = 0, tsayac = 0, csayac = 0, cttoplam = 0;
            foreach (int say in tc)
            {
                toplam += say;
            }
            toplam -= tc[10];
            for (int i = 0; i < tc.Length-2; i++)
            {
                if (i%2==0)
                {
                    tsayac += tc[i];
                }
                else
                {
                    csayac += tc[i];
                }
            }
            cttoplam = (tsayac * 7) - csayac;
            if (tc.Length==11 && tc[0]!=0 && tc[10]%2==0 && tc[10] == toplam % 10 && tc[9] == cttoplam % 10)
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
