using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero_automatico
{
    public partial class FrmCuentaDolares : Form
    {
        private string _nroCuenta;
        public FrmCuentaDolares(string nroCuenta)
        {
            InitializeComponent();
            _nroCuenta = nroCuenta;
        }

        private void btnExtraerDolares_Click(object sender, EventArgs e)
        {
            FrmExtraer _frmExtraer = new FrmExtraer(_nroCuenta, this);
            _frmExtraer.Show();
        }

        private void btnTransferirDolares_Click(object sender, EventArgs e)
        {
            FrmTransferir frmTransferir = new FrmTransferir(_nroCuenta, this);
            frmTransferir.Show();
        }
    }
}
