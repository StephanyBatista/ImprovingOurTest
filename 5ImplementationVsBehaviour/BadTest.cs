using ImprovingOurTestTalk._5ImplementationVsBehaviour.Dependencies;
using Moq;

namespace ImprovingOurTestTalk._5ImplementationVsBehaviour;

public class BadTest
{
    [Fact]
    public void Should_Create_Investigation()
    {
        var company = new Company();
        var coafApp = new Mock<ICoafApp>();
        var companyRepository = new Mock<ICompanyRepository>();
        var investigationRepository = new Mock<IInvestigationRepository>();
        
        var sut = new InvestigationService(
            investigationRepository.Object,
            companyRepository.Object,
            coafApp.Object);

        sut.Investigate(company, "Under investigation");

        investigationRepository.Verify(x =>
            x.Save(It.Is<Investigation>(i => i.Company == company && i.Reason == "Under investigation")));
        companyRepository.Verify(x => x.Update(company));
        coafApp.Verify(x => x.Post(company.Number, "Under investigation"));
    } 
}