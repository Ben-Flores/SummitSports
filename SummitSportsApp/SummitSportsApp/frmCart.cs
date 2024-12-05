using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    public partial class frmCart : Form
    {
        private static List<int> inventoryIDs = new List<int>();
        private static List<int> quantities = new List<int>();
        public static List<int> InventoryIDs
        {
            get { return inventoryIDs; }
            set { inventoryIDs = value; }
        }
        public static List<int> Quantities
        {
            get { return quantities; }
            set { quantities = value; }
        }

        public frmCart()
        {
            InitializeComponent();
        }
    }
}
