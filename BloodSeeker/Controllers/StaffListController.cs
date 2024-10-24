using BloodSeeker.Class;
using BloodSeeker.Model.Admin;
using System.Collections.Generic;
using System.Linq;

namespace BloodSeeker.Admin.Controllers
{
    internal class StaffListController
    {
        StaffRepository repository = new StaffRepository();

        public int getStaffLength()
        {
            return repository.getPeople().Count();
        }
        public List<Person> getStaffList()
        {
            return repository.getPeople();
        }
    }
}
