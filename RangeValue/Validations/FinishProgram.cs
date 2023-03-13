using RangeValue.Data.Entities;

namespace RangeValue.Validations;

public class FinishProgram
{

   public static bool finishProgram(List<Result> result)
    {
        result = orderList(result);
        for (int i = 0; i < result.Count; i++)
        {

            if (i > 0)
            {
                Result prev = result[i - 1];
                Result current = result[i];
                //if (current.range.firstNumber - prev.range.secondNumber > 1)
                {
                    Console.WriteLine("{0}<C1<{1} ve {2}<C1<{3} bu iki aralık arasında dahil edilmeyen hata var", prev.range.FirstNumber, prev.range.SecondNumber, current.range.FirstNumber, current.range.SecondNumber);
                    return false;
                }
            }
        }
        foreach (Result item in result)
        {
            Console.WriteLine("{0} {1} {2} {3}", item.range.FirstNumber, item.range.FirstOperand, item.range.SecondNumber, item.range.SecondOperand);
        }
        return true;
    }
    static List<Result> orderList(List<Result> result)
    {
        List<Result> r = result.OrderBy(r => r.range.FirstNumber).ToList();
        return r;

    }
}

