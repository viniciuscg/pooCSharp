﻿using System.Xml.Linq;

namespace ConsoleApp4.Entites
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public Client () {}
        public Client (string name, string email, DateTime brithDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = brithDate;
        }
        public override string ToString()
        {
            return name
                + ", ("
                + birthDate.ToString("dd/MM/yyyy")
                + ") - "
                + email;
        }
    }
}