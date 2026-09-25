namespace Chain_Of_Reponsibility;

public class Data<T>
{
    public T _val;

    public Data(T value)
    {
        _val = value;
    }

    public void Set(T value)
    {
        _val = value;
    }

    public T Get()
    {
        return _val;
    }
}