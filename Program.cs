using System;

namespace CS_Switch_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the name of one of these countries and I will output the name of their currecny.");Console.WriteLine("Input the name of one of these countries and I will output the name of their currecny.");
            Console.WriteLine("United States");
            Console.WriteLine("Canada");
            Console.WriteLine("India");
            Console.WriteLine("Japan");
            Console.WriteLine("Mexico");

            string answer = Console.ReadLine();
            CurrencyID(answer);
        }

        private static int CurrencyID(string answer)
        {
            switch (answer.ToUpper())
            {
                case "UNITED STATES":
                    Console.WriteLine("The United States uses the US Dollar.");
                    break;

                case "CANADA":
                    Console.WriteLine("Canada uses the Canadian Dollar.");
                    break;

                case "INDIA":
                    Console.WriteLine("India uses the Indian Rupee.");
                    break;

                case "JAPAN":
                    Console.WriteLine("Japan uses the Japanese Yen.");
                    break;

                case "MEXICO":
                    Console.WriteLine("Mexico uses the Mecican Peso.");
                    break;
                default:
                    Console.WriteLine("I'm sorry, but I do not know what that countries currency is.");
                    break;
            }

            return 0;
        }


    }
}
