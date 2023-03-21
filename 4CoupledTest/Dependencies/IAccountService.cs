namespace ImprovingOurTestTalk._4CoupledTest.Dependencies;

public interface IAccountService
{
    decimal GetBalance(string accountNumber);
    void WithDraw(string accountNumber, decimal amount);
}