namespace Chain_Of_Reponsibility.Handler;

public abstract class Handler
{
    private Handler? _next;

    protected Handler(Handler? next = null)
    {
        _next = next;
    }

    public Handler? setNext(Handler? next)
    {
        _next = next;
        return _next; //für .setNext().setNext()
    }
    public abstract  bool HandleRequest();
}