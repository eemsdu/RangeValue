namespace RangeValue.Data.Entities;

public class RangeControl:Base
{
    public double FirstNumber { get; set; }
    public string FirstOperand { get; set; }
    public double SecondNumber { get; set; }
    public string SecondOperand { get; set; }
    public int Score { get; set; }
}
