using ImprovingOurTestTalk._3TheGiant.Dependencies;
using Moq;

namespace ImprovingOurTestTalk._3TheGiant;

public class BadTest
{
    [Fact]
    public void Should_create_people()
    {
        Assert.Throws<ArgumentNullException>(() => new People(null, "email"));
        Assert.Throws<ArgumentNullException>(() => new People("name", null));

        var repository = new Mock<IPeopleRepository>();
        var notifier = new Mock<INotifierEmail>();
        var service = new PeopleService(repository.Object, notifier.Object);
        var people = new People("name", "email");
        
        service.Create(people.Name, people.Email);
        
        repository.Verify(x => x.Save( It.Is<People>(args => args.Name == people.Name && args.Email == people.Email)));
        notifier.Verify(x => x.Send("People created", people.Email));
    }
}