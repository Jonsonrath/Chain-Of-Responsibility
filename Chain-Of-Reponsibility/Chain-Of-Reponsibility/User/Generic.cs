using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Reponsibility.User.Gerneric
{
    public abstract class Generic
    {
        protected new const AccessLevel _acc = AccessLevel.Generic;
        protected String? _name = null;

        protected Generic(String name)
        {
            _name = name;
        }
    }
}
