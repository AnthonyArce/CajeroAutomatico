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
        private FrmTransferir _frmTransferir;
        public FrmTransferir(string nroCuenta, FrmTransferir frmTransferir)
        {
            InitializeComponent();
            _nroCuenta = nroCuenta;
            _frmTransferir = frmTransferir;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                    Reg = $"{nroCuenta};{nroCliente};{moneda};{(int.Parse(saldo) - int.Parse(txtTransferirMonto.Text)).ToString()};{tipoCuenta};{alias};{cbu}";
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
            Reg = $"{idTransacción};{_nroCuenta};{fecha};sistemaBanquito;Transferencia;-{txtTransferirMonto.Text}";
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
