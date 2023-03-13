using RangeValue.Models;

namespace RangeValue.Validations
{
    public class CheckRange
    {
        public static bool checkRange(RangeViewModel r)
        {
            double number1 = r.FirstNumber;
            double number2 = r.SecondNumber;
            string operand1 = r.FirstOperand;
            string operand2 = r.SecondOperand;

            if ((operand1 == "<" || operand1 == "<=") && (operand2 == "<" || operand2 == "<="))
            {
                return number1 < number2;
            }
            else if ((operand1 == "<" || operand1 == "<=") && (operand2 == ">" || operand2 == ">="))
            {
                return true;
            }
            else if ((operand1 == ">" || operand1 == ">=") && (operand2 == "<" || operand2 == "<="))
            {
                return true;
            }
            else if ((operand1 == ">" || operand1 == ">=") && (operand2 == ">" || operand2 == ">="))
            {
                return number1 > number2;
            }

            return true;
        }
    }
}