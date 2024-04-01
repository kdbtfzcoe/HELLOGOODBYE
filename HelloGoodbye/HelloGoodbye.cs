
namespace HelloGoodbye
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                for (int num1_100 = 1; num1_100 <= 100; num1_100++)
                {
                    if (num1_100 % 3 == 0 & num1_100 % 5 == 0)
                    {
                        Console.WriteLine("Hello Goodbye");
                    }
                    if (num1_100 % 5 == 0)
                    {
                        Console.WriteLine("Goodbye");
                    }
                    if (num1_100 % 3 == 0)
                    {
                        Console.WriteLine("Hello");
                    }
                    else
                    {
                        Console.WriteLine(num1_100);
                    }


                }
            }
        }
    }

    
