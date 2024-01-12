//Console.WriteLine("Hello, OS");

namespace Delegate
{
    class Program
    {
        delegate int CalculateDel(int operand1, int operand2);

        static void Main(string[] args)
        {
            CalculateDel addCalculationDel = new CalculateDel(AddIntegerValues);
            CalculateDel subCalculationDel = new CalculateDel(SubtractIntegerValues);

            int result_add = addCalculationDel(2, 2);
            int result_sub = subCalculationDel(80, 40);

            Console.WriteLine("Sum = {0} and sub = {1}",result_add, result_sub);

        }

        static int AddIntegerValues (int operand1, int operand2)
        {
            return operand1 + operand2;
        }

        static int SubtractIntegerValues(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
    }
}