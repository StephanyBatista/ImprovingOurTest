using ImprovingOurTestTalk._1TheLiar.Dependencies;

namespace ImprovingOurTestTalk._1TheLiar;

public class BadTest2
{
    [Fact]
    public void Must_validate_Name()
    {
        var employee = new Employee(null, 19, "123434");
        
        Assert.False(employee.IsValid());
        Assert.Single(employee.Errors);
    }
    
    [Fact]
    public void Must_validate_Age()
    {
        var employee = new Employee("Henrique Batista", 17, "123434");
        
        Assert.False(employee.IsValid());
        Assert.Single(employee.Errors);
    }
    
    [Fact]
    public void Must_validate_SocialNumber()
    {
        var employee = new Employee("Henrique Batista", 68, string.Empty);
        
        Assert.False(employee.IsValid());
        Assert.Single(employee.Errors);
    }
}