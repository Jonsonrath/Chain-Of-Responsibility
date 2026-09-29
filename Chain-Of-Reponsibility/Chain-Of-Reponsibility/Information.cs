namespace Chain_Of_Reponsibility;

public class Information
{
    public Information(AccessLevel accessLevel, Data<string> data)
    {
        AccessLevel = accessLevel;
        Data = data;
    }

    public AccessLevel AccessLevel { get; set; }
    public Data<string> Data { get; set; }
}
