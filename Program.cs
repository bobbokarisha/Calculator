// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

Console.Write("Enter a number: ");
string firstInput = Console.ReadLine();


while(!int.TryParse(firstInput, out int number))
{
    Console.WriteLine("Please enter a number");
    firstInput = Console.ReadLine();
}

int firstNumber = Convert.ToInt32(firstInput);

Console.Write("Enter Operator: ");
string op = Console.ReadLine();
while (op != "+" && op != "-" && op != "/" && op != "*")
{
    Console.WriteLine("Please enter operator");
    op = Console.ReadLine();
}

Console.Write("Enter a number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine(firstNumber + num2);
}
else if (op == "-")
{
    Console.WriteLine(firstNumber - num2);
}
else if (op == "/")
{
    Console.WriteLine(firstNumber / num2);
}
else if (op == "*")
{
    Console.WriteLine(firstNumber * num2);
}
else
{
    Console.WriteLine("Invalid Operator");
}


    Console.ReadLine(); 
