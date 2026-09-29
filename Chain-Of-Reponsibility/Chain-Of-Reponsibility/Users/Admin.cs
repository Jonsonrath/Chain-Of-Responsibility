namespace Chain_Of_Reponsibility.Users;

public class Admin : Generic
{
    public Admin(string name) : base(name)
    {
    }

    public override AccessLevel AccessLevel => Chain_Of_Reponsibility.AccessLevel.Admin;
}
