namespace ImprovingOurTestTalk._3TheGiant.Dependencies;

public class PeopleService
{
    private readonly INotifierEmail _notifierEmail;
    private readonly IPeopleRepository _peopleRepository;

    public PeopleService(
        IPeopleRepository peopleRepository,
        INotifierEmail notifierEmail
        )
    {
        _peopleRepository = peopleRepository;
        _notifierEmail = notifierEmail;
    }

    public void Create(string name, string email)
    {
        var people = new People(name, email);
        _peopleRepository.Save(people);
        _notifierEmail.Send("People created", email);
    }
}