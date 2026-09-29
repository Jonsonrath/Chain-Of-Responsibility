using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Reponsibility
{
    public class Information
    {
        private AccessLevel _acc;
        private Data<String> _data;

        public Information(AccessLevel  acc, Data<String> data) 
        {
            _acc = acc;
            _data = data;
        }
        public Data<String> GetData()
        {
            return _data;
        }

        public AccessLevel GetAccessLevel()
        {
            return _acc;
        }

        public void SetAccessLevel(AccessLevel acc)
        {
            _acc = acc;
        }

        public void SetData(Data<String> data)
        {
            _data = data;
        }
    }
}
