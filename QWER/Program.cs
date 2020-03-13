using System;

namespace QWER
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
            int a = 100;
            while (true) 
            {
                if (a<=0)
                {
                    Console.WriteLine("QQ");
                    break;
                }
                string input = Console.ReadLine();
                int attack = int.Parse(input);
                a = a - attack;

                           
            }



            Console.ReadLine();
        }
    }
}
