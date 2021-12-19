using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravisB_P0
{
    public abstract class Person
    {
        private string? _firstName;
        private string? _lastName;
        private string? _email;

        public Person(string firstName, string lastName, string email)
        {

        }


        public Order history { get; private set; }

        public virtual Order ViewHistory()
        {
            return history;
        }
    }
}
