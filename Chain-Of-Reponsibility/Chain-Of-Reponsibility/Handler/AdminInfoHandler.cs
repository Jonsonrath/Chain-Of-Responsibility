namespace Chain_Of_Reponsibility.Handler;

public class AdminInfoHandler : Handler
{
    protected override bool CanHandle(Information info) => info.AccessLevel <= AccessLevel.Admin;
}
