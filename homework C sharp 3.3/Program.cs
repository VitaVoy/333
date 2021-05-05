using System;

namespace homework_C_sharp_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; 
            int n;

            do
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n % 2 != 0)
                    sum += n;
            } while (n != 0);


            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
