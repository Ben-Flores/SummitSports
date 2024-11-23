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
    public partial class frmRegister : Form
    {
        Form parentForm;
        public frmRegister(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }
}
