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
    public partial class FrmDeposito : Form
    {
        private string _nroCuenta;
        private FrmCuentaPesos _frmPesos;
        public FrmDeposito(string nroCuenta, FrmCuentaPesos frmPesos)
        {
            InitializeComponent();
            _nroCuenta = nroCuenta;
            _frmPesos = frmPesos;
        }

        private void AgregarNumero(string numero)
        {
            txtMonto.Text += numero;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtMonto.Text.Length > 0)
            {
                txtMonto.Text = txtMonto.Text.Substring(0, txtMonto.Text.Length - 1);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMonto.Text = "";
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            modificarSaldo();
            registrarTransacción();

            txtMonto.Text = "";
            _frmPesos.CompletarDatosCuenta(_nroCuenta);
            _frmPesos.CompletarDatosTransacciones(_nroCuenta);

            this.Close();

        }

        private void modificarSaldo()
        {
            FileStream FS = new FileStream("D:\\cajero\\Cuentas.txt", FileMode.Open);
            FileStream FSAUX = new FileStream("D:\\cajero\\CuentasAux.txt", FileMode.Create);
            StreamReader SR = new StreamReader(FS);
            StreamWriter SW = new StreamWriter(FSAUX);
            String[] vectorregistro;
            String Reg;
            String nroCuenta, nroCliente, moneda, saldo, tipoCuenta, alias, cbu;

            while (!(SR.Peek() == -1))
            {
                Reg = SR.ReadLine();
                vectorregistro = Reg.Split(';');
                nroCuenta = vectorregistro[0];
                nroCliente = vectorregistro[1];
                moneda = vectorregistro[2];
                saldo = vectorregistro[3];
                tipoCuenta = vectorregistro[4];
                alias = vectorregistro[5];
                cbu = vectorregistro[6];

                if (nroCuenta == _nroCuenta)
                {
                    Reg = $"{nroCuenta};{nroCliente};{moneda};{(int.Parse(saldo) - int.Parse(txtMonto.Text)).ToString()};{tipoCuenta};{alias};{cbu}";
                }

                SW.WriteLine(Reg);
            }
            SR.Close();
            SW.Close();
            FS.Close();
            FSAUX.Close();
            File.Delete("D:\\cajero\\Cuentas.txt");
            File.Move("D:\\cajero\\CuentasAux.txt", "D:\\cajero\\Cuentas.txt");
        }
        private void registrarTransacción()
        {
            int idTransacción = ultimaTransaccionCargada() + 1;

            FileStream FS = new FileStream("D:\\cajero\\transacciones.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            String Reg;

            string fecha = DateTime.Now.ToString("dd/MM/yy");
            Reg = $"{idTransacción};{_nroCuenta};{fecha};sistemaBanquito;extraccion;{txtMonto.Text}";
            SW.WriteLine(Reg);
            SW.Close();
            FS.Close();


        }
        private int ultimaTransaccionCargada()
        {
            FileStream FS = new FileStream("D:\\cajero\\transacciones.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            int idTransacción = 0;


            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                idTransacción = int.Parse(vectorregistro[0]);
            }
            SR.Close();
            FS.Close();

            return idTransacción;
        }
    }
}
