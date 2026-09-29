using Chain_Of_Reponsibility.Handler;
using Chain_Of_Reponsibility.Users;

namespace Chain_Of_Reponsibility;

class Program
{
    static void Main()
    {
        List<Generic> people =
        [
            new User("Clemens"),
            new User("Benjamin"),
            new Admin("Daniel"),
            new Admin("Raphael"),
            new Guest("Karl Heinz"),
            new Guest("Kanoirotz")
        ];

        List<Information> informations =
        [
            new(AccessLevel.Generic, new Data<string>("Generic Information")),
            new(AccessLevel.Admin, new Data<string>("Admin Information")),
            new(AccessLevel.User, new Data<string>("User Information"))
        ];

        var handler = new AccessHandlerChain();

        foreach (var person in people)
        {
            foreach (var info in informations)
            {
                if (handler.HandleRequest(info, person))
                {
                    Console.WriteLine($"{person.Name,-20} kann {info.Data.Value,-20} sehen");           
                    //-20 ==> left Allign 20 Chars
                }
            }
        }
    }
}
