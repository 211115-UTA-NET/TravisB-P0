using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TravisB_P0
{
    public interface IOrder
    {
        void AddToCart(string productName, int quantity);
        void FinalizeOrder();
    }
}
