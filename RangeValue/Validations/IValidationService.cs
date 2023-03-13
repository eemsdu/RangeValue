using RangeValue.Data.Entities;
using RangeValue.Models;

namespace RangeValue.Validations
{
    public interface IValidationService
    {
        bool FinishProgram(List<RangeViewModel> result);
    }
}
