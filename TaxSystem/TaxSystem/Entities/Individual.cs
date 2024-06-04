namespace TaxSystem.Entities;

public class Individual(
    string name, 
    double annualIncome, 
    double healthExpenditures
) : TaxPayer(name, annualIncome)
{
    public double HealthExpenditures { get; set; } = healthExpenditures;

    public override double Tax()
    {
        if (AnnualIncome < 20000.00)
        {
            return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
        } else {
            return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}
