﻿using BloodSeeker.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodSeeker.Model
{
    internal class Client : Person
    {
        public int donorid { get; set; }
        public string bloodgroup {  get; set; }
        public Client(string username,string password,string firstname,string lastname,string email,string phone,string address,string sex,DateTime birthdate,int donorid,string bloodgroup)
            :base(username,password,firstname,lastname,email,phone,address,sex,birthdate)
        { 
        this.donorid = donorid;
        this.bloodgroup = bloodgroup;
        }
    }
}
