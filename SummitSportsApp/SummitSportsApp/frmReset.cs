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
    public partial class frmReset : Form
    {
        Form parentForm;
        public frmReset(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clsSQL.CloseConnection();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
