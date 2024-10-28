using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker.Class
{
    internal class Person
    {
        public string username { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public DateTime birthdate { get; set; }
        public string photo { get; set; }

        public Person(string username, string password, string firstname, string lastname, string email, string phone, string address, string sex, DateTime birthdate, string photo)
        {
            this.username = username;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.sex = sex;
            this.birthdate = birthdate;
            this.photo = photo;
        }
    }
}
