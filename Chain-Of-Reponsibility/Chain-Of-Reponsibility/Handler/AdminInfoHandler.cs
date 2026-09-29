namespace Chain_Of_Reponsibility.Handler;

public class AdminInfoHandler : Handler
{
    public AdminInfoHandler(Handler? next = null) :  base(next)
    { }

    public override bool HandleRequest(Information info)
    {
        if (info.GetAccessLevel() == AccessLevel.Generic || info.GetAccessLevel() == AccessLevel.User ||  info.GetAccessLevel() == AccessLevel.Admin)
        {
            if (_next == null)
            {
                return true;
            }
            return _next.HandleRequest(info);
        }

        return false;
    }
}