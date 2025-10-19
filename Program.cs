using System;

namespace _25
{
    class Program
    {
        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;

            }
            return true;
        }


        static int BinaryToDecimal(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        static string DecimalToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        //Addition
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a* b;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter first binary number:");
            string binary1 = Console.ReadLine().Trim();
            if (!IsBinary(binary1))
            {
                Console.WriteLine("Error: Invalid binary number.");
                return;
            }

            Console.Write("Enter second binary number:");
            string binary2 = Console.ReadLine().Trim();
            if (!IsBinary(binary2))
            {
                Console.WriteLine("Error: Invalid binary number.");
                return;
            }


            //Choose operation
            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1) Addition (+)");
            Console.WriteLine("2) Subtraction (-)");
            Console.WriteLine("3) Multiplication (*)");
            Console.Write("Enter choice (1/2/3) or  (+/-/*): ");
            string choice = Console.ReadLine().Trim();

            int num1 = BinaryToDecimal(binary1);
            int num2 = BinaryToDecimal(binary2);
            int result = 0;
            bool validChoice = true;

            switch (choice)
            {
                case "1":
                case "+":
                    result = Add(num1, num2);
                    break;
                case "2":
                case "-":
                    result = Subtract(num1, num2);
                    break;
                case "3":
                case "*":
                    result = Multiply(num1, num2);
                    break;
                default:
                    validChoice = false;
                    break;
            }
            Console.WriteLine("\n--------------------------");

            if (!validChoice)
            {
                Console.WriteLine("Error: Invalid choice.");
            }
            else
            {
                Console.WriteLine($"Result in (decimal): {result}");
                Console.WriteLine($"Result in (binary): {DecimalToBinary(result)}");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }   
    }
}
