using RangeValue.Data.Entities;
using RangeValue.Models;

namespace RangeValue.Validations
{
    public class ValidationService : IValidationService
    {
       
        public bool FinishProgram(List<RangeViewModel> result)
        {
            result = orderList(result);
            for (int i = 0; i < result.Count; i++)
            {

                if (i > 0)
                {
                    RangeViewModel prev = result[i - 1];
                    RangeViewModel current = result[i];
                    if (current.FirstNumber - prev.SecondNumber > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

       
        private List<RangeViewModel> orderList(List<RangeViewModel> result)
        {
            List<RangeViewModel> r = result.OrderBy(r => r.FirstNumber).ToList();
            return r;
        }
      
    }
   
}
