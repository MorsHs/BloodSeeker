using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker.Model
{
    internal class ClientLoginController
    {
        public ClientLoginController() { 
        
        }
        public bool verifyUser(string username, string password)
        {
            ClientLoginRepo repo = new ClientLoginRepo();
            return repo.getUser(username, password);
        }
    }
}
