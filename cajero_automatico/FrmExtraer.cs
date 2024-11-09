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
    public partial class FrmExtraer : Form
    {
        private string _nroCuenta;
        private FrmCuentaPesos _frmPesos;
        private string nroCuenta;
        private int _moneda;
        private FrmCuentaDolares frmCuentaDolares;

        public FrmExtraer(string nroCuenta, FrmCuentaPesos frmPesos)
        {
            _nroCuenta = nroCuenta;
            InitializeComponent();
            _frmPesos = frmPesos;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            modificarSaldo();
            registrarTransacción();
            
            txtExtraerMonto.Text = "";
            _frmPesos.CompletarDatosCuenta(_nroCuenta, _moneda);
            _frmPesos.CompletarDatosTransacciones(_nroCuenta, _moneda);

            this.Close();

        }

        private void modificarSaldo() 
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

                if (nroCuenta == _nroCuenta)
                {
                    Reg = $"{nroCuenta};{nroCliente};{moneda};{(int.Parse(saldo) - int.Parse(txtExtraerMonto.Text)).ToString()};{tipoCuenta};{alias};{cbu}";
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
        private void registrarTransacción() 
        {
            int idTransacción = ultimaTransaccionCargada() + 1;

            FileStream FS = new FileStream("C:\\cajero\\transacciones.txt", FileMode.Append);
            StreamWriter SW = new StreamWriter(FS); 
            String Reg;
            
            string fecha = DateTime.Now.ToString("dd/MM/yy");
            Reg = $"{idTransacción};{_nroCuenta};{fecha};sistemaBanquito;extraccion;-{txtExtraerMonto.Text}";
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


    }
}
