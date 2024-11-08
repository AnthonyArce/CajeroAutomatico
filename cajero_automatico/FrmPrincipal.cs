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
    public partial class FrmPrincipal : Form
    {

        private string _dni;
        private string _nroCliente;

        public FrmPrincipal(string dni)
        {
            InitializeComponent();
            _dni = dni;
        }

        void CompletarDatosPersona()
        {

            FileStream FS = new FileStream("D:\\cajero\\Cliente.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            String nrocliente, nombre,apellido, edad,sexo, dni;

            while (!(SR.Peek() == -1))
            {
                registro = SR.ReadLine();
                vectorregistro = registro.Split(';');
                dni = vectorregistro[1];
                if (_dni == dni) 
                {
                    nombre = vectorregistro[2];
                    apellido = vectorregistro[3];
                    edad = vectorregistro[4];
                    _nroCliente = vectorregistro[0];

                    lblApellidoyNombre.Text = $"{apellido} {nombre}";
                }
                
                

            }

            SR.Close();
            FS.Close();

        }

        void CompletarDatosCuenta(string _nroCliente)
        {

            FileStream FS = new FileStream("D:\\cajero\\Cuentas.txt", FileMode.Open);
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

                if (_nroCliente == nrocliente) 
                {
                    if (moneda == "PES")
                    {
                        lblTipoCuentaPes.Text = $"{tipoCuenta} $";
                        lblMontoPes.Text = $"${saldo}";
                        lblNumCuentaPes.Text = $"{nrocuenta}";
                    }
                    else
                    {
                        lblTipoCuentaDol.Text = $"{tipoCuenta} $";
                        lblMontoDol.Text = $"${saldo}";
                        lblNumCuentaDol.Text = $"{nrocuenta}";
                    }
                }
                
            }

            SR.Close();
            FS.Close();

        }

        void CompletarDatosTransacciones(string _nroCuenta) 
        {
            FileStream FS = new FileStream("D:\\cajero\\transacciones.txt", FileMode.Open);
            StreamReader SR = new StreamReader(FS);
            String[] vectorregistro;
            String registro;
            String idTransaccion, nrocuenta, fecha, destinatario, remitente, monto;
            lstvMovimientos.Items.Clear();

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

                    lstvMovimientos.Items.Add(ls);
                }

            }

            SR.Close();
            FS.Close();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CompletarDatosPersona();
                CompletarDatosCuenta(_nroCliente);
                CompletarDatosTransacciones(lblNumCuentaPes.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Hubo un error con la carga de los archivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void grpBox_Enter(object sender, EventArgs e)
        {
            FrmCuentaPesos frmCuentaPesos = new FrmCuentaPesos(lblNumCuentaPes.Text);
            frmCuentaPesos.Show();

            this.Hide();
        }
    }
}
