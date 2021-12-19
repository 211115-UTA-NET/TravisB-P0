using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravisB_P0
{
    public class Manager : Person
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        public Manager(string firstName, string lastName, string email) : base(firstName, lastName, email)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._email = email;
        }


    }
}
