using System;

namespace kimlik
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Random rnd = new Random();
            while (a < 10)
            {
                int[] no = new int[11];
                for (int i = 0; i < 11; i++)
                {
                    no[i] = rnd.Next(0, 10);
                }
                int tno = no[0] + no[2] + no[4] + no[6] + no[8];
                int cno = no[1] + no[3] + no[5] + no[7];
                if ((tno * 7 - cno) % 10 == no[9])
                {
                    int t = no[0] + no[1] + no[2] + no[3] + no[4] + no[5] + no[6] + no[7] + no[8] + no[9];
                    if (t % 10 == no[10])
                    {
                        for (int i = 0; i < 11; i++)
                        {
                            Console.Write(no[i]);
                        }
                        Console.WriteLine();
                        a++;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
