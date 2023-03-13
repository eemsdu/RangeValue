using RangeValue.Data;
using RangeValue.Data.Entities;
using RangeValue.Models;
using RangeValue.Validations;
using System.Collections.Generic;

namespace RangeValue.Services
{
    public class RangeServices : IRangeService
    {
        private readonly IRangeRepository _rangeRepository;
        private readonly IValidationService _validationService;

       

        public RangeServices(IRangeRepository rangeRepository, IValidationService validationService)
        {
            _rangeRepository = rangeRepository;
            _validationService = validationService; 
          
        }

        public void addTolist(RangeViewModel range)
        {
            if (!CheckRange.checkRange(range))
            {
                range.Errors.Add("Hatalı range, yeniden gir");
                return;
            }

            if (!CheckOverlapInList.checkOverlapInList(range, _rangeRepository.GetList()))
            {
                range.Errors.Add("Overlap oldu. Yeniden dene");
                return;
            }
           
            if (!_validationService.FinishProgram(_rangeRepository.GetList()))
            {
                range.Errors.Add("Hatalı aralıklar mevcut");
                return;
            }

            _rangeRepository.addTolist(range);
        }

        public int GetScore(double number)
        {
            var rangeControl = _rangeRepository.GetByNumber(number);

            if (rangeControl == null)
            {
                throw new Exception($"No range control defined for the number {number}.");
            }

            return rangeControl.Score;
        }
    }
}
