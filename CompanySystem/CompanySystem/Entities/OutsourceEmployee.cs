namespace CompanySystem.Entities;

public class OutsourceEmployee : Employee
{
    public double AddicionalCharge { get; set; }

    public OutsourceEmployee(string name, int hours, double valuePerHour, double addicionalCharge)
        : base(name, hours, valuePerHour)
    {
        AddicionalCharge = addicionalCharge;
    }

    public override double Payment()
    {
        return base.Payment() + (1.1 * AddicionalCharge);
    }
}
