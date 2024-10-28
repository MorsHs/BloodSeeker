using BloodSeeker.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker.Model
{
    internal class Staff:Person
    {
        public int staffId { get;set; }
        public Staff(string username,string password,string firstname,string lastname,string email,string phone,string address,string sex,DateTime birthdate,string photo,int id):
            base(username,password,firstname,lastname,email,phone,address,sex,birthdate,photo)
        {
            this.staffId = id;
        }
    }
}
