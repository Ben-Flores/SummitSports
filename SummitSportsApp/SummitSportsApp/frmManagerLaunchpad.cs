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
    public partial class frmManagerLaunchpad : Form
    {
        frmLogon parentForm;
        int managerID;

        public frmManagerLaunchpad(frmLogon parentForm, int managerID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.managerID = managerID;
            lblName.Text = clsSQL.FindName(managerID);
            //clsSQL.CloseConnection();
        }

        private void frmManagerLaunchpad_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsiPOS_Click(object sender, EventArgs e)
        {
            if (clsSQL.OpenConnection())
            {
                frmPOS frmPOS = new frmPOS(this, managerID);
                if (!frmPOS.IsDisposed)
                {
                    frmPOS.Show();
                    this.Hide();
                }
            }
            clsSQL.CloseConnection();
        }

        private void tsiProducts_Click(object sender, EventArgs e)
        {
            if (clsSQL.OpenConnection())
            {
                frmInventory frmInventory = new frmInventory(this);
                if (!frmInventory.IsDisposed)
                {
                    frmInventory.Show();
                    this.Hide();
                }
            }
        }
    }
}
