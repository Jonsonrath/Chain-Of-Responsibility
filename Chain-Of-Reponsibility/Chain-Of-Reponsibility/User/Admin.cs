using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Reponsibility.User.Admin 
{
    public class Admin : Generic
    {
        const AccessLevel _acc = AccessLevel.Admin;
        public Admin(String name) : base( name)
        {

        }
    }
}
