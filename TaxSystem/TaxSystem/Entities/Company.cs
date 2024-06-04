namespace TaxSystem.Entities;

public class Company(
    string name,
    double annualIncome,
    int numberOfEmployees
) : TaxPayer(name, annualIncome)
{
    public int NumberOfEmployees { get; set; } = numberOfEmployees;

    public override double Tax()
    {
        if (NumberOfEmployees <= 10)
        {
            return AnnualIncome * 0.16;
        } else {
            return AnnualIncome * 0.14;
        }
    }
}
