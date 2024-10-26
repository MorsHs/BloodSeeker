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
        public List<Person> searchClientById(int clientId)
        {
            return repository.searchClientById(clientId);
        }

        public List<Person> searchClientByFirstName(string firstName)
        {
            return repository.getPeople()
         .Where(client => client.firstname.IndexOf(firstName, StringComparison.OrdinalIgnoreCase) >= 0)
         .ToList();
        }

        public List<Person> searchClientByLastName(string lastName)
        {
            return repository.getPeople()
         .Where(client => client.lastname.IndexOf(lastName, StringComparison.OrdinalIgnoreCase) >= 0)
         .ToList();
        }
    }
}
