namespace Chain_Of_Reponsibility.Handler;

public class PublicInfoHandler : Handler
{
    protected override bool CanHandle(Information info) => info.AccessLevel <= AccessLevel.Generic;
}
