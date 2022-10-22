using System;
using System.Collections.Generic;
using System.Text;

namespace LegacyApp
{
    public class User
    {
        public Client Client { get; internal set; }
        public DateTime DateOfBirth { get; internal set; }
        public string EmailAddress { get; internal set; }
        public string Firstname { get; internal set; }
        public string Surname { get; internal set; }
        public bool HasCreditLimit { get; internal set; }
        public int CreditLimit { get; internal set; }
    }
}
