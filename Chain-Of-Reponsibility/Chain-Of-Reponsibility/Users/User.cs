namespace Chain_Of_Reponsibility.Users;

public class User : Generic
{
    public User(string name) : base(name)
    {
    }

    public override AccessLevel AccessLevel => Chain_Of_Reponsibility.AccessLevel.User;
}
