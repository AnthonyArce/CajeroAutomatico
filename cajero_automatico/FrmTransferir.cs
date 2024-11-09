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
    public partial class FrmTransferir : Form
    {
        private string _nroCuenta;
        private FrmCuentaPesos _frmCuentaPesos;
        private string nroCuenta;
        private int _moneda;
        private FrmCuentaDolares frmCuentaDolares;

        public FrmTransferir(string nroCuenta, FrmCuentaPesos frmCuentaPesos)
        {
            InitializeComponent();
            _nroCuenta = nroCuenta;
            _frmCuentaPesos = frmCuentaPesos;
        }

        public FrmTransferir(string nroCuenta, FrmCuentaDolares frmCuentaDolares)
        {
            this.nroCuenta = nroCuenta;
            this.frmCuentaDolares = frmCuentaDolares;
        }

        private void FrmTransferir_Load(object sender, EventArgs e)
        {
            CompletarDatosCuenta(_nroCuenta);
        }


        public void CompletarDatosCuenta(string _nroCuenta)
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

                lblNroCuenta.Text = nrocuenta;


                if (_nroCuenta == nrocuenta)
                {
                    lblNroCuenta.Text = nrocuenta;
                    lblMonto.Text = saldo;
                    lblALIAS.Text = alias;
                    lblCBU.Text = cbu;
                }

            }

            SR.Close();
            FS.Close();

        }

        private void modificarSaldo(string cuenta, int monto)
        {
            FileStream FS = new FileStream("C:\\cajero\\Cuentas.txt", FileMode.Open);
            FileStream FSAUX = new FileStream("C:\\cajero\\CuentasAux.txt", FileMode.Create);
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

                if (alias == cuenta || cbu == cuenta || nroCuenta == cuenta)
                {
                    int montoFinal = int.Parse(saldo) + monto;
                    if (montoFinal > 0)
                    {
                        Reg = $"{nroCuenta};{nroCliente};{moneda};{montoFinal.ToString()};{tipoCuenta};{alias};{cbu}";
                    }
                    else
                    {
                        MessageBox.Show("Saldo insuficiente para realizar esta operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                SW.WriteLine(Reg);
            }

            SR.Close();
            SW.Close();
            FS.Close();
            FSAUX.Close();
            File.Delete("C:\\cajero\\Cuentas.txt");
            File.Move("C:\\cajero\\CuentasAux.txt", "C:\\cajero\\Cuentas.txt");
        }

        private void registrarTransacción(string destino, string remitente)
        {
            int idTransacción = ultimaTransaccionCargada() + 1;

            FileStream FS = new FileStream("C:\\cajero\\transacciones.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS);
            String Reg;

            string fecha = DateTime.Now.ToString("dd/MM/yy");
            Reg = $"{idTransacción};{remitente};{fecha};{destino};Transferencia;-{txtTransferirMonto.Text}";
            SW.WriteLine(Reg);
            SW.Close();
            FS.Close();


        }

        private int ultimaTransaccionCargada()
        {
            FileStream FS = new FileStream("C:\\cajero\\transacciones.txt", FileMode.Open);
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

        private bool verificarCuentaExterna(string cuentaExterna)
        {
            FileStream FS = new FileStream("C:\\cajero\\Cuentas.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);

            String[] vectorregistro;
            String registro;
            String alias, cbu;
            bool existeCuenta = false;

            while (SR.Peek() != -1 && !existeCuenta)
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                alias = vectorregistro[5];
                cbu = vectorregistro[6];

                if ((alias == cuentaExterna) || (cbu == cuentaExterna))
                {
                    existeCuenta = true;
                }
            }

            SR.Close();
            FS.Close();
            return existeCuenta;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            bool existeCuenta = false;
            List<String> datosCliente = new List<string>();
            string cuentaDestino = "";

            existeCuenta = verificarCuentaExterna(txtALIAS.Text);

            if (existeCuenta) 
            {
                modificarSaldo(txtALIAS.Text, int.Parse(txtTransferirMonto.Text));
                datosCliente = obtenerDatos(txtALIAS.Text);
                registrarTransacción( _nroCuenta, datosCliente[0]);
                cuentaDestino = txtALIAS.Text;
            }
            else
            {
                existeCuenta = verificarCuentaExterna(txtCBU.Text);

                if (existeCuenta)
                {
                    modificarSaldo(txtCBU.Text, int.Parse(txtTransferirMonto.Text));
                    cuentaDestino = txtALIAS.Text;
                }
                   
            }
                
            if (!existeCuenta)
                MessageBox.Show("No existe la cuenta ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            if (existeCuenta) 
            {
                modificarSaldo(_nroCuenta, int.Parse($"-{txtTransferirMonto.Text}"));
                registrarTransacción(cuentaDestino, _nroCuenta);
            }

            limpiarInputs();

        }

        private void limpiarInputs()
        {
            txtALIAS.Text = "";
            txtCBU.Text = "";
            txtTransferirMonto.Text = "";

            _frmCuentaPesos.CompletarDatosCuenta(_nroCuenta, _moneda);
            this.Close();
        }

        private List<string> obtenerDatos(string cuenta)
        {
            FileStream FS = new FileStream("C:\\cajero\\Cuentas.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);

            String[] vectorregistro;
            String registro;
            String alias, cbu, nroCuenta;

            List<string> datos = new List<string>();

            while (SR.Peek() != -1)
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                alias = vectorregistro[5];
                cbu = vectorregistro[6];
                nroCuenta = vectorregistro[0];

                if ((alias == cuenta) || (cbu == cuenta) || (nroCuenta == cuenta ))
                {

                    datos.Add(nroCuenta);
                    datos.Add(alias);
                    datos.Add(cbu);
                    
                }
            }

            SR.Close();
            FS.Close();
            return datos;
        }

    }   
 
}
