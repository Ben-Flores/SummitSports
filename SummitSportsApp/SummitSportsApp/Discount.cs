using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class Discount
    {
        public int discountID;
        public string discountCode;
        public int discountLevel;
        public int inventoryID;
        public int discountType;
        public decimal discountPercentage;
        public decimal discountDollarAmount;

        public override string ToString()
        {
            return discountID.ToString() + " " + discountCode + " " + discountLevel.ToString() + " " + inventoryID.ToString() + " " + discountType.ToString() + " " + discountPercentage.ToString() + " " + discountDollarAmount.ToString();
        }
    }
}
