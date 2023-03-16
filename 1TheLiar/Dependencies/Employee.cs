namespace ImprovingOurTestTalk._1TheLiar.Dependencies;

public class Employee
{
    private readonly List<string> _errors = new List<string>();
    
    public IEnumerable<string> Errors => _errors;

    //What happens if an employee over 60 and without a social number now needs to pass on the address?
    public Employee(string name, int age, string socialNumber, string address = null)
    {
        if(string.IsNullOrEmpty(name))
            _errors.Add("Name is required");
        if(age < 18)
            _errors.Add("Age invalid");
        if(string.IsNullOrEmpty(socialNumber))
            _errors.Add("Social number is required");
    }

    public bool IsValid() =>  !_errors.Any();
}