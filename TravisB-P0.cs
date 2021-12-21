using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using System.Data.SqlClient;

namespace TravisB_P0
{

    public class Program
    {
        static void Main()
        {
            string first;
            string last;
            Customer thisCustomer = new Customer(string first, string last);
            Order thisOrder = new Order();
            thisOrder.FinalizeOrder(thisCustomer, Locations.MapleGrove);
        }
    }
}
