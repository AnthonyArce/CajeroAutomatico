using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero_automatico
{
    public partial class FrmCuentaPesos : Form
    {
        private FrmExtraer _frmExtraer;
        private string _nroCuenta;
        private int _moneda;
        public FrmCuentaPesos(string nroCuenta)
        {
            InitializeComponent();
            _nroCuenta = nroCuenta;
        }

        private void FrmCuentaPesos_Load(object sender, EventArgs e)
        {
            CompletarDatosCuenta(_nroCuenta, _moneda);
            CompletarDatosTransacciones(_nroCuenta, _moneda);
        }


        public void CompletarDatosCuenta(string _nroCuenta, int _moneda)
        {

            FileStream FS = new FileStream("C:\\cajero\\Cuentas.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            String nrocliente, nrocuenta, moneda, saldo, tipoCuenta, alias, cbu;

            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                nrocuenta = vectorregistro[0];
                nrocliente = vectorregistro[1];
                moneda = vectorregistro[2];
                saldo = vectorregistro[3];
                tipoCuenta = vectorregistro[4];
                alias = vectorregistro[5];
                cbu = vectorregistro[6];

                if (_nroCuenta == nrocuenta)
                {
                    lblNroCuenta.Text = nrocuenta;
                    lblMontoPes.Text = saldo;
                }

            }

            SR.Close();
            FS.Close();

        }

        public void CompletarDatosTransacciones(string _nroCuenta, int _moneda)
        {
            FileStream FS = new FileStream("C:\\cajero\\transacciones.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            String idTransaccion, nrocuenta, fecha, destinatario, remitente, monto;
            lstvMovimientosPes.Items.Clear();

            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');

                idTransaccion = vectorregistro[0];
                nrocuenta = vectorregistro[1];
                fecha = vectorregistro[2];
                destinatario = vectorregistro[3];
                remitente = vectorregistro[4];
                monto = vectorregistro[5];

                if (_nroCuenta == nrocuenta)
                {
                    ListViewItem ls = new ListViewItem(idTransaccion);
                    ls.SubItems.Add(fecha);
                    ls.SubItems.Add(destinatario);
                    ls.SubItems.Add(monto);

                    lstvMovimientosPes.Items.Add(ls);
                }

            }

            SR.Close();
            FS.Close();

        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
             FrmExtraer _frmExtraer = new FrmExtraer(_nroCuenta, this);
             _frmExtraer.Show();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            FrmTransferir frmTransferir = new FrmTransferir(_nroCuenta, this);
            frmTransferir.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCargarCel_Click(object sender, EventArgs e)
        {
            FrmCargarCel frmCargarCel = new FrmCargarCel(_nroCuenta, this);
            frmCargarCel.Show();
        }
    }
}
