using Chain_Of_Reponsibility.Users;

namespace Chain_Of_Reponsibility.Handler;

public abstract class Handler
{
    protected Handler? _next;

    public Handler SetNext(Handler next)
    {
        _next = next;
        return next;
    }

    public bool HandleRequest(Information info, Generic person)
    {
        if (CanHandle(info))
        {
            return person.AccessLevel >= info.AccessLevel; //weil im enum ziffern automatisch vergeben werden
        }

        return _next?.HandleRequest(info, person) ?? false;
    }

    protected abstract bool CanHandle(Information info);
}
