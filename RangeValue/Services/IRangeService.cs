using RangeValue.Data;
using RangeValue.Data.Entities;
using RangeValue.Models;

namespace RangeValue.Services;

public interface IRangeService
{
    void addTolist(RangeViewModel model);
    int GetScore(double number);
}
