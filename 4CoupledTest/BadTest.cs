using ImprovingOurTestTalk._4CoupledTest.Dependencies;
using Moq;

namespace ImprovingOurTestTalk._4CoupledTest;

public class BadTest
{
    [Fact]
    public void Should_Throw_When_Insufficient_Funds()
    {
        var accountService = new Mock<IAccountService>();
        var bankService = new BankService(accountService.Object);
        
        var exception = Assert.Throws<Exception>(() => bankService.Withdraw("123", 100));
        Assert.Equal("Insufficient funds", exception.Message);
    }
    
    [Fact]
    public void Should_Withdraw_When_Enough_Funds()
    {
        var accountService = new Mock<IAccountService>();
        accountService.Setup(x => x.GetBalance("123")).Returns(100);
        var bankService = new BankService(accountService.Object);
        
        bankService.Withdraw("123", 100);
        
        accountService.Verify(x => x.WithDraw("123", 100));
    }
}