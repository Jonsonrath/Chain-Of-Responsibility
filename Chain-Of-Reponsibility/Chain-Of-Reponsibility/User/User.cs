using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Reponsibility.User.User
{
    public class User : Generic
    {
        private new const AccessLevel _acc = AccessLevel.User;
        public User(String name) : base( name)
        {
            
        }
    }
}
