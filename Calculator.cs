

namespace Calculator
{ 
    public class Calculator
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        public int Mul(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        public int Div(int firstNum, int secondNum)
        {
            if (secondNum != 0)
            {
                return firstNum / secondNum;
            }
            else
            {
                Console.WriteLine("Error: Division by zero.");
                return 0;
            }
        }
    }
}
