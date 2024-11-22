using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class SessionSingleton
    {
        private static SessionSingleton _instance = new SessionSingleton();

        private SessionSingleton()
        {
        }

        public static SessionSingleton GetSession()
        {
            return _instance;
        }
    }
}
