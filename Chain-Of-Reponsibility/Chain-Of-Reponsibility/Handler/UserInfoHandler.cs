namespace Chain_Of_Reponsibility.Handler;

public class UserInfoHandler : Handler
{
    protected override bool CanHandle(Information info) => info.AccessLevel <= AccessLevel.User;
}
