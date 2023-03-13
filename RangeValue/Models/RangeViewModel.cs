using RangeValue.Data.Entities;

namespace RangeValue.Models
{
    public class RangeViewModel
    {
        public double FirstNumber { get; set; }
        public string FirstOperand { get; set; }
        public double SecondNumber { get; set; }
        public string SecondOperand { get; set; }
        public int Score { get; set; }

        // Errors property to hold validation error messages
        public List<string> Errors { get; set; }
     
            public RangeViewModel()
            {
                Errors = new List<string>();
            }
        

    }
}
