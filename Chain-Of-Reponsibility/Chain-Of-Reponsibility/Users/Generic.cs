namespace Chain_Of_Reponsibility.Users;

public abstract class Generic
{
    protected Generic(string? name)
    {
        Name = name;
    }

    public string? Name { get; }
    public virtual AccessLevel AccessLevel => Chain_Of_Reponsibility.AccessLevel.Generic;
}
