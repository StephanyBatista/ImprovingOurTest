namespace ImprovingOurTestTalk._2ExcessiveSetup.Dependencies;

public class People
{
    public People(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public string Email { get; private set; }

    public string Name { get; private set; }
}

public class SalesForce
{
    public SalesForce(People people, string salesForce)
    {
        throw new NotImplementedException();
    }
}

public class Company
{
    public Company(People people, string company)
    {
        throw new NotImplementedException();
    }
}

public class Role
{
    public Role(People people, string role)
    {
        throw new NotImplementedException();
    }
}

public class BankAccount
{
    public BankAccount(People people, string bankAccount)
    {
        throw new NotImplementedException();
    }
}