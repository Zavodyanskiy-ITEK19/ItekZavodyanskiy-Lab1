using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write(" Введитечисло А ");
                int k = Int32.Parse(Console.ReadLine());
                if (k % 2 == 0)
                {
                    Console.WriteLine("числочетное\n");
                }
                else
                {
                    Console.WriteLine(" числонечетное\n");
                }
            }
            catch 
            {
                Console.WriteLine("Ошибка")
            }

        }
    }
}
