

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;

            while (runProgram)
            {
                Console.WriteLine("Welcome to the calculator");
                bool parseSuccessful;
                int firstNum;
                int secondNum;



                do
                {
                    Console.WriteLine("Enter first number");
                    string num1 = Console.ReadLine();

                    parseSuccessful = int.TryParse(num1, out firstNum);

                    if (!parseSuccessful)
                    {
                        Console.WriteLine("Invalid input");
                    }
                } while (!parseSuccessful);


                string operator1;
                do
                {
                    Console.WriteLine("Enter an operator (+, -, * or /)");
                    operator1 = Console.ReadLine();
                } while (operator1 != "+" && operator1 != "-" && operator1 != "*" && operator1 != "/");


                do
                {

                    Console.WriteLine("Enter second number");
                    string num2 = Console.ReadLine();


                    parseSuccessful = int.TryParse(num2, out secondNum);

                    if (!parseSuccessful)
                    {
                        Console.WriteLine("Invalid input");
                    }
                } while (!parseSuccessful);

                Calculator calculator = new Calculator();


                switch (operator1)
                {
                    case "+":
                        Console.WriteLine($"Result: {calculator.Add(firstNum, secondNum)}");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {calculator.Sub(firstNum, secondNum)}");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {calculator.Mul(firstNum, secondNum)}");
                        break;
                    case "/":
                        Console.WriteLine($"Result: {calculator.Div(firstNum, secondNum)}");
                        break;
                }

                Console.WriteLine("Do you want to calculate again? Y/N");
                string runAgainInput = Console.ReadLine();
                if (runAgainInput.ToLower() == "y")
                {
                    runProgram = true;
                }
                else if (runAgainInput.ToLower() == "n")
                {
                    runProgram = false;
                }
            }
        }
    }
}
