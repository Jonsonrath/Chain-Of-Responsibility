namespace Chain_Of_Reponsibility;

public class Data<T>
{
    public Data(T value)
    {
        Value = value;
    }

    public T Value { get; set; }
}
