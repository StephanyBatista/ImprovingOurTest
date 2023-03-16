namespace ImprovingOurTestTalk._2ExcessiveSetup.Dependencies;

public class PeopleService
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly IBankRepository _bankRepository;
    private readonly IRolesRepository _rolesRepository;
    private readonly ICompanyRepository _companyRepository;
    private readonly ISerasaApp _serasaApp;
    private readonly INotifierEmail _notifierEmail;
    private readonly ISAPApp _sapApp;
    private readonly ISalesForceApp _salesForceApp;

    public PeopleService(
        IPeopleRepository peopleRepository,
        IBankRepository bankRepository,
        IRolesRepository rolesRepository,
        ICompanyRepository companyRepository,
        ISerasaApp serasaApp,
        INotifierEmail notifierEmail,
        ISAPApp sapApp,
        ISalesForceApp salesForceApp)
    {
        _peopleRepository = peopleRepository;
        _bankRepository = bankRepository;
        _rolesRepository = rolesRepository;
        _companyRepository = companyRepository;
        _serasaApp = serasaApp;
        _notifierEmail = notifierEmail;
        _sapApp = sapApp;
        _salesForceApp = salesForceApp;
    }
    
    public void Create(string name, string email)
    {
        var people = new People(name, email);
        _peopleRepository.Save(people);
        _notifierEmail.Send("People created", email);
    }
    
    public void BindBankAccount(People people, string bankAccount)
    {
        _bankRepository.Save(new BankAccount(people, bankAccount));
        _notifierEmail.Send("Bank account binded", people.Email);
    }
    
    public void BindRole(People people, string role)
    {
        _rolesRepository.Save(new Role(people, role));
        _notifierEmail.Send("Role binded", people.Email);
    }
    
    public void Authenticate(People people, string password)
    {
        _sapApp.Authenticate(people, password);
        _notifierEmail.Send("People authenticated", people.Email);
    }
    
    public void QueryOnSerasa(People people)
    {
        _serasaApp.Query(people);
        _notifierEmail.Send("People queried on serasa", people.Email);
    }
    
    public void BindCompany(People people, string company)
    {
        _companyRepository.Save(new Company(people, company));
        _notifierEmail.Send("Company binded", people.Email);
    }
    
    public void BindSalesForce(People people, string salesForce)
    {
        _salesForceApp.Save(new SalesForce(people, salesForce));
        _notifierEmail.Send("SalesForce binded", people.Email);
    }
}

