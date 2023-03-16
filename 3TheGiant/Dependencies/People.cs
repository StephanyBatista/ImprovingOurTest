namespace ImprovingOurTestTalk._3TheGiant.Dependencies;

public class People
{
    public string Name { get; private set; }
    public string Email { get; private set; }

    public People(string name, string email)
    {
        if(string.IsNullOrEmpty(name))
            throw new ArgumentNullException("name");
        if (string.IsNullOrEmpty(email))
            throw new ArgumentNullException("email");
        Name = name;
        Email = email;
    }
}