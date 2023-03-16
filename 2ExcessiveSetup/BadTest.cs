using ImprovingOurTestTalk._2ExcessiveSetup.Dependencies;
using Moq;

namespace ImprovingOurTestTalk._2ExcessiveSetup;

public class BadTest
{
    private readonly Mock<IPeopleRepository> _peopleRepository;
    private readonly Mock<IBankRepository> _bankRepository;
    private Mock<IRolesRepository> _rolesRepository;
    private readonly Mock<ICompanyRepository> _companyRepository;
    private Mock<ISerasaApp> _serasaApp;
    private Mock<INotifierEmail> _notifierEmail;
    private Mock<ISAPApp> _sapApp;
    private readonly Mock<ISalesForceApp> _salesForceApp;

    public BadTest()
    {
        _peopleRepository = new Mock<IPeopleRepository>();
        _bankRepository = new Mock<IBankRepository>();
        _rolesRepository = new Mock<IRolesRepository>();
        _companyRepository = new Mock<ICompanyRepository>();
        _serasaApp = new Mock<ISerasaApp>();
        _notifierEmail = new Mock<INotifierEmail>();
        _sapApp = new Mock<ISAPApp>();
        _salesForceApp = new Mock<ISalesForceApp>();
        var service = new PeopleService(
            _peopleRepository.Object, 
            _bankRepository.Object, 
            _rolesRepository.Object, 
            _companyRepository.Object, 
            _serasaApp.Object, 
            _notifierEmail.Object, 
            _sapApp.Object, 
            _salesForceApp.Object);
    }
}

