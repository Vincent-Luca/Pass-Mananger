using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pass_Manager;

namespace Pass_Manager.Classes
{
    public class PassMananger
    {
        private static PassMananger _instance;
        public static PassMananger Instance => _instance;

        private Login _login;
        public Login Login => _login;


        public PassMananger() 
        {
            if (_instance == null)
                _instance = this;

            _login = new Login();


        }
    }
}
