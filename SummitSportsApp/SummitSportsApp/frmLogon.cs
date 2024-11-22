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
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
        }
    }
}
