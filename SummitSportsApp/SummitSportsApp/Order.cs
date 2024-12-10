using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class Order
    {
        public int personID;
        public int managerID;
        public List<int> inventoryIDs;
        public List<int> quantities;
        public Discount discount;

        public string discounted;
        public string discountedTotal;
        public string discountedTax;
        public string grandTotal;

        public string cardNumber;
        public string ccv;
        public string expDate;

        public Order(int personID, List<int> inventoryIDs, List<int>quantities, Discount discount, string discounted, string discountedTotal, string discountedTax, string grandTotal, string cardNumber, string ccv, string expDate)
        {
            this.personID = personID;
            this.inventoryIDs = inventoryIDs;
            this.quantities = quantities;
            this.discount = discount;
            this.discounted = discounted;
            this.discountedTotal = discountedTotal;
            this.discountedTax = discountedTax;
            this.grandTotal = grandTotal;

            this.cardNumber = cardNumber;
            this.ccv = ccv;
            this.expDate = expDate;
        }

        public Order(int personID, int managerID, List<int> inventoryIDs, List<int> quantities, Discount discount, string discounted, string discountedTotal, string discountedTax, string grandTotal, string cardNumber, string ccv, string expDate)
        {
            this.personID = personID;
            this.managerID = managerID;
            this.inventoryIDs = inventoryIDs;
            this.quantities = quantities;
            this.discount = discount;
            this.discounted = discounted;
            this.discountedTotal = discountedTotal;
            this.discountedTax = discountedTax;
            this.grandTotal = grandTotal;

            this.cardNumber = cardNumber;
            this.ccv = ccv;
            this.expDate = expDate;
        }
    }
}
