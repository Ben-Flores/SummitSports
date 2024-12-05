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
    public partial class frmCheckout : Form
    {
        frmCart parentForm;

        public frmCheckout(frmCart parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void tbxCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
            clsValidation.ValidateCard(e);
        }

        private void tbxCard_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.FormatCard(sender);
            clsValidation.ValidateCardFormat(sender, lblCard);
        }

        private void tbxCCV_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
            clsValidation.ValidateCCV(e);
        }

        private void tbxCCV_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateCCVFormat(sender, lblCCV);
        }

        private void tbxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
            clsValidation.ValidateDate(e);
        }

        private void tbxDate_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.FormatDate(sender);
            clsValidation.ValidateDateFormat(sender, lblDate);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCheckout(tbxCard.Text, tbxCCV.Text, tbxDate.Text, lblError))
            {
                parentForm.CreateOrder();
                this.Close();
            }
        }
    }
}
