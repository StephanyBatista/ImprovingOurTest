namespace ImprovingOurTestTalk._1TheLiar.Dependencies;

public class People
{
    public string Name { get; private set; }
    
    public People(string name)
    {
        Name = $"{DateTime.Now.Day} - {name}";
    }
}