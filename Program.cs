namespace CalcApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator APP");

            Console.WriteLine("Enter First Number:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter First Number:");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option:\n1) 1 for addition\n2) 2 for subtraction\n3) 3 for multiplication\n4) 4 for division\n5) 0 for exist");
            int operation = Convert.ToInt32(Console.ReadLine());

            while (operation != 0)
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Result: {n1 + n2}");
                        break;

                    case 2:
                        Console.WriteLine($"Result: {n1 - n2}");
                        break;

                    case 3:
                        Console.WriteLine($"Result: {n1 * n2}");
                        break;

                    case 4:
                        if (n2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine($"Result: {(double)n1 / n2}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("\nChoose Another Option:");
                operation = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
