using System;
using System.Collections.Generic;
using System.Text;
using Chain_Of_Reponsibility.User;

namespace Chain_Of_Reponsibility.User
{
    public class User : Generic
    {
        private new const AccessLevel _acc = AccessLevel.User;
        public User(String name) : base( name)
        {
            
        }
    }
}
