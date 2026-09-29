using System;
using System.Collections.Generic;
using System.Text;
using Chain_Of_Reponsibility.User;

namespace Chain_Of_Reponsibility.User
{
    public class Admin : Generic
    {
        const AccessLevel _acc = AccessLevel.Admin;
        public Admin(String name) : base( name)
        {

        }
    }
}
