using ImprovingOurTestTalk._1TheLiar.Dependencies;

namespace ImprovingOurTestTalk._1TheLiar;

public class BadTest1
{
    [Fact]
    public void Must_validate_name()
    {
        var people = new People("Henrique Batista");
        
        Assert.NotNull(people);
    }
}