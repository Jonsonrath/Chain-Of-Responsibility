namespace Chain_Of_Reponsibility;

public class Data<T>
{
    private T _val;
    private AccessLevel _acc;
    

    public Data(T value,  AccessLevel acc)
    {
        _val = value;
        _acc = acc;
    }

    public void Set(T value)
    {
        _val = value;
    }

    public T Get()
    {
        return _val;
    }

    public AccessLevel GetAccessLevel()
    {
        return _acc;
    }
    
}