using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummitSportsApp
{
    internal class clsCategory
    {
        public int categoryID;
        public string categoryName;

        public clsCategory(int categoryID, string categoryName)
        {
            this.categoryID = categoryID;
            this.categoryName = categoryName;
        }
    }
}
