using ImprovingOurTestTalk._2ExcessiveSetup.Dependencies;

public class PeopleCreationService
{
    public PeopleCreationService(
        IPeopleRepository peopleRepository,
        INotifierEmail notifierEmail,
        IRolesRepository rolesRepository) { }
}

public class BankChangeService
{
    public BankChangeService(
        IPeopleRepository peopleRepository,
        INotifierEmail notifierEmail,
        IBankRepository bankRepository) { }
}