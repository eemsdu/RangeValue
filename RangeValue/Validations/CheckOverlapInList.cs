using RangeValue.Data.Entities;
using RangeValue.Models;

namespace RangeValue.Validations;

public class CheckOverlapInList
{
    public static bool checkOverlapInList(RangeViewModel r, List<RangeViewModel> l)
    {
        foreach (RangeViewModel item in l)
        {
            if (checkOverLap(r, item))
            {
                return false;
            }
        }
        return true;
    }

    public static bool checkOverLap(RangeViewModel r1, RangeViewModel r2)
    {
        // Verilen iki aralığın çakışıp çakışmadığını kontrol eder
        if ((r1.SecondNumber < r2.FirstNumber) || (r1.FirstNumber > r2.SecondNumber))
        {
            return false;
        }
        return true;
    }
}


