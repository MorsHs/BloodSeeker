using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker
{
    internal class SignupController

    {
        private String lastname;
        private String firstname;
        private String contactnum;
        private String email;
        private String password;
        private String confirmpassword;

        Global globe;
       public SignupController(string lastname, string firstname, string contactum,string email,string password,string confirmpassword) { 
            this.lastname = lastname;
            this.firstname = firstname;
            this.contactnum = contactum;
            this.email = email;
            this.password = password;
            this.confirmpassword = confirmpassword;
            globe = new Global();
        }
    }
}
