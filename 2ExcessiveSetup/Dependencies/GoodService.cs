namespace ImprovingOurTestTalk._2ExcessiveSetup.Dependencies;

public class PeopleCreationService
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly INotifierEmail _notifierEmail;
    private readonly IRolesRepository _rolesRepository;

    public PeopleCreationService(
        IPeopleRepository peopleRepository,
        INotifierEmail notifierEmail,
        IRolesRepository rolesRepository)
    {
        _peopleRepository = peopleRepository;
        _notifierEmail = notifierEmail;
        _rolesRepository = rolesRepository;
    }
    
    public void Create(string name, string email)
    {
        var people = new People(name, email);
        _peopleRepository.Save(people);
        _notifierEmail.Send("People created", email);
    }
}

public class BankChangeService
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly INotifierEmail _notifierEmail;
    private readonly IBankRepository _bankRepository;

    public BankChangeService(
        IPeopleRepository peopleRepository,
        INotifierEmail notifierEmail,
        IBankRepository bankRepository)
    {
        _peopleRepository = peopleRepository;
        _notifierEmail = notifierEmail;
        _bankRepository = bankRepository;
    }
    
    public void BindBankAccount(People people, string bankAccount)
    {
        _bankRepository.Save(new BankAccount(people, bankAccount));
        _notifierEmail.Send("Bank account binded", people.Email);
    }
}