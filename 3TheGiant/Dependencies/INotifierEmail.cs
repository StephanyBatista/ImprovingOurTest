namespace ImprovingOurTestTalk._3TheGiant.Dependencies;

public interface INotifierEmail
{
    void Send(string message, string email);
}