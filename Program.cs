using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生亂數物件
            Random rand = new Random();

            // 紀錄產生次數
            int count = 0;

            // 
            while(count < 10)
        { 
                // 產生六個亂數
                int A = rand.Next(1, 43);
                int B = rand.Next(1, 43);
                int C = rand.Next(1, 43);
                int D = rand.Next(1, 43);
                int E = rand.Next(1, 43);
                int F = rand.Next(1, 43);

                //印出

                Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", A, B, C, D, E, F);

                // 次數+1
                count = count + 1;
            }
            // 暫停螢幕
            Console.ReadLine();
        }
    }
}

