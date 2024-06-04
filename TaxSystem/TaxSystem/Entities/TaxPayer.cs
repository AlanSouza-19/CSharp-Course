namespace TaxSystem.Entities;
public abstract class TaxPayer(string name, double annualIncome)
{
    public string Name { get; set; } = name;
    public double AnnualIncome { get; set; } = annualIncome;

    public abstract double Tax();
}
