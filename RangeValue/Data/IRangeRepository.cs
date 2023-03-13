using RangeValue.Data.Entities;
using RangeValue.Models;

namespace RangeValue.Data
{
    public interface IRangeRepository
    {
       void addTolist(RangeViewModel result);
        List<RangeViewModel> GetList();
        RangeControl GetByNumber(double number);

    }
}
