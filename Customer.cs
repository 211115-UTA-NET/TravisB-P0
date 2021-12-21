using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravisB_P0
{
    public class Customer : Person
    {
        private string _firstName;
        private string _lastName;
        public Customer(string firstName, string lastName) : base(firstName, lastName)
        {
            this._firstName = firstName;
            this._lastName = lastName;
        }

        public string firstName { get { return _firstName; } }
        public string lastName { get { return _lastName;} }


    }
}
