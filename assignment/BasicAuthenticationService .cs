using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string userName, string password)
        {

            return userName == "admin" && password == "password";
        }
        public bool AuthorizeUser(string userName, string role)
        {

            return userName == "admin" && role == "Administrator";
        }
    }
}
