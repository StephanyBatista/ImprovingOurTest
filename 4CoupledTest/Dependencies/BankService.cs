namespace ImprovingOurTestTalk._4CoupledTest.Dependencies;

public class BankService
{
    private readonly IAccountService _accountService;

    public BankService(IAccountService accountService)
    {
        _accountService = accountService;
    }
    
    public void Withdraw(string accountNumber, decimal amount)
    {
        if(_accountService.GetBalance(accountNumber) < amount)
            throw new Exception("Insufficient funds");
        
        // Withdraw
        _accountService.WithDraw(accountNumber, amount);
    }
}