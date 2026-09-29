namespace Chain_Of_Reponsibility.Handler;

public class UserInfoHandler : Handler
{
    public UserInfoHandler(Handler? next = null) :  base(next)
    { }

    public override bool HandleRequest(Information info)
    {
        if (info.GetAccessLevel() == AccessLevel.Generic || info.GetAccessLevel() == AccessLevel.User)
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