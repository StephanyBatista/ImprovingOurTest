namespace ImprovingOurTestTalk._5ImplementationVsBehaviour.Dependencies;

public class InvestigationService
{
    private readonly IInvestigationRepository _investigationRepository;
    private readonly ICompanyRepository _companyRepository;
    private readonly ICoafApp _coafApp;

    public InvestigationService(
        IInvestigationRepository investigationRepository,
        ICompanyRepository companyRepository,
        ICoafApp coafApp)
    {
        _investigationRepository = investigationRepository;
        _companyRepository = companyRepository;
        _coafApp = coafApp;
    }
    
    public void Investigate(Company company, string reason)
    {
        var investigation = new Investigation(company, reason);
        company.UnderInvestigation();
        
        _coafApp.Post(company.Number, reason);
        _investigationRepository.Save(investigation);
        _companyRepository.Update(company);
        
    }
}