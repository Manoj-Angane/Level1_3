using System;

namespace Level1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number : ");
            string input = Console.ReadLine();
            try
            {
                int a = int.Parse(input);
                if(a<=0)
                {
                    Console.WriteLine("Number entered is niether Odd nor Even : " + input);
                }
                else if (a / 2 == 1)
                {
                    Console.WriteLine("Number entered is Odd : " + input);
                }
                else
                {
                    Console.WriteLine("Number entered is Even : " + input);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Thank You!!..Hit any key to exit");
            Console.ReadKey(true);
        }
    }
}
