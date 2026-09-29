using Chain_Of_Reponsibility.Users;

namespace Chain_Of_Reponsibility.Handler;

public class AccessHandlerChain
{
    private readonly Handler _first;

    public AccessHandlerChain()
    {
        _first = new PublicInfoHandler();
        _first.SetNext(new UserInfoHandler())
              .SetNext(new AdminInfoHandler());
    }

    public bool HandleRequest(Information info, Generic person)
    {
        return _first.HandleRequest(info, person);
    }
}
