namespace Chain_Of_Reponsibility.Handler;

public class PublicInfoHandler : Handler
{
    public PublicInfoHandler(Handler? next = null) :  base(next)
    { }

    public override bool HandleRequest(Information info)
    {
        if (info.GetAccessLevel() == AccessLevel.Generic)
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