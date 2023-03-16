namespace ImprovingOurTestTalk._5ImplementationVsBehaviour.Dependencies;

public class Investigation
{
    public Company Company { get; private set; }
    public string Reason { get; private set; }

    public Investigation(Company company, string reason)
    {
        Company = company;
        Reason = reason;
    }
}