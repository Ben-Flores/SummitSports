using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class Order
    {
        public int personID;
        public List<int> inventoryIDs;
        public List<int> quantities;
        public Discount discount;

        public string discounted;
        public string discountedTotal;
        public string discountedTax;
        public string grandTotal;

        public Order(int personID, List<int> inventoryIDs, List<int>quantities, Discount discount, string discounted, string discountedTotal, string discountedTax, string grandTotal)
        {
            this.personID = personID;
            this.inventoryIDs = inventoryIDs;
            this.quantities = quantities;
            this.discount = discount;
            this.discounted = discounted;
            this.discountedTotal = discountedTotal;
            this.discountedTax = discountedTax;
            this.grandTotal = grandTotal;
        }
    }
}
