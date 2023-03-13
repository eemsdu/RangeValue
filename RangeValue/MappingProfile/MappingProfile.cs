using AutoMapper;
using RangeValue.Models;

namespace RangeValue.MappingProfile
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<RangeViewModel, Range>();
        }
    }
}
