using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RangeValue.Models;

namespace RangeValue.Data.Entities
{
    public class RangeRepository : IRangeRepository
    {
        private readonly RangeContext _context;

        public RangeRepository(RangeContext context)
        {
            _context = context;
        }

        public void addTolist(RangeViewModel model)
        {
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                //cfg.AddExpressionMapping();
                cfg.CreateMap<RangeViewModel, RangeControl>();
            }).CreateMapper();

            if ((model.FirstOperand == "<" || model.FirstOperand == "<=") && model.SecondOperand == ">" || model.SecondOperand == ">=")
            {
                double max = Math.Max(model.FirstNumber, model.SecondNumber);
                model.FirstNumber = max;
                model.SecondNumber = double.PositiveInfinity;
                model.FirstOperand = "<";
                model.SecondOperand = "<";
            }
            else if ((model.FirstOperand == ">" || model.FirstOperand == ">=") && model.SecondOperand == "<" || model.SecondOperand == "<=")
            {
                double min = Math.Min(model.FirstNumber, model.SecondNumber);
                model.FirstNumber = double.NegativeInfinity;
                model.SecondNumber = min;
                model.FirstOperand = "<";
                model.SecondOperand = "<";
            }
            else if (((model.FirstOperand == ">" || model.FirstOperand == ">=") && (model.SecondOperand == ">") || model.SecondOperand == ">="))
            {
                double temp = model.FirstNumber;
                model.FirstNumber = model.SecondNumber;
                model.SecondNumber = temp;
                model.FirstOperand = "<";
                model.SecondOperand = "<";
            }

            RangeControl entity = mapper.Map<RangeControl>(model);

            _context.Add(entity);
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Hata işleme kodu
            }

            
        }

        public RangeControl GetByNumber(double number)
        {
            return _context.RangeControls.FirstOrDefault(r => r.FirstNumber <= number && r.SecondNumber >= number);
        }

        public List<RangeViewModel> GetList()
        {
            IMapper mapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RangeControl, RangeViewModel>();
            }).CreateMapper();

            var entities = _context.RangeControls.ToList();
            var models = mapper.Map<List<RangeControl>, List<RangeViewModel>>(entities);

            return models;
        }
    }
}