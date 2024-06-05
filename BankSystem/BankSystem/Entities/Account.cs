using BankSystem.Entities.Exceptions;

namespace BankSystem.Entities;

public class Account(
    int number,
    string holder,
    double balance,
    double withDrawLimit
)
{
    public int Number { get; set; } = number;
    public string Holder { get; set; } = holder;
    public double Balance { get; set; } = balance;
    public double WithDrawLimit { get; set; } = withDrawLimit;

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void WithDraw(double amount)
    {
        if (amount > WithDrawLimit)
        {
            throw new WithDrawException("Not enough balance");
        } else if (amount > Balance) {
            throw new WithDrawException("The amount exceeds withdraw limit");
        } else {
            Balance -= amount;
        }
    }
}
