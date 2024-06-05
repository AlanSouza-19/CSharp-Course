namespace BankSystem.Entities.Exceptions;

public class WithDrawException(
    string message
) : ApplicationException(message)
{
}
