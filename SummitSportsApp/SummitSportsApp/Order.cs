using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class Order
    {
        public string user;
        public List<int> inventoryIDs = new List<int>();
        public List<int> quantities = new List<int>();
        public List<int> discounts = new List<int>();
    }
}
