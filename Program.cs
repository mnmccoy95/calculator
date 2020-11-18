using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculatron 3000!");
            Play();
        }
        static void Play()
        {
            Console.WriteLine(@"
        1) Add two numbers
        2) Subtract two numbers
        3) Multiply two numbers
        4) Divide two numbers
        0) Exit");
            Console.Write("Choose a Number: ");
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                Compute(choice);
            }
            catch
            {
                Console.WriteLine("Not a valid option, dude.");
            }
            
        }
        static void Compute(int choice)
        {
            if(choice != 0 && choice < 5)
            {   
                try
                {
                    Console.Write("Please enter the first number: ");
                    int number1 = Int32.Parse(Console.ReadLine());
                    Console.Write("Please enter the second number: ");
                    int number2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    
                    Calculator calculator = new Calculator();

                    if(choice == 1)
                    {
                        int answer = calculator.Add(number1, number2);
                        Console.WriteLine($"The answer is {answer}");
                    }
                    if(choice == 2)
                    {
                        int answer = calculator.Subtract(number1, number2);
                        Console.WriteLine($"The answer is {answer}");
                    }
                    if(choice == 3)
                    {
                        int answer = calculator.Multiply(number1, number2);
                        Console.WriteLine($"The answer is {answer}");
                    }
                    if(choice == 4)
                    {
                        try
                        {
                            int answer = calculator.Divide(number1, number2);
                            Console.WriteLine($"The answer is {answer}");
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("Don't divide by zero, please!!");
                        }
                    }
                    Console.WriteLine("");
                    Play();
                }
                catch 
                {
                    Console.Write("You done goofed somehow, buddy.");
                    Console.WriteLine("");
                    Play();
                }

            }

        }
    }
}
