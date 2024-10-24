using BloodSeeker.Class;
using BloodSeeker.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker.Controllers.Admin
{
    internal class ClientListController
    {
        ClientRepository repository = new ClientRepository();

        public int getClientLength()
        {
            return repository.getPeople().Count();
        }
        public List<Person> getClientList()
        {
            return repository.getPeople();
        }
    }
}
