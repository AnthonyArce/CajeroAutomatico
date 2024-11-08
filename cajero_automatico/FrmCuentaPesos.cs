﻿using System;
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
        public FrmCuentaPesos()
        {
            InitializeComponent();
        }

        private void FrmCuentaPesos_Load(object sender, EventArgs e)
        {

        }


        void CompletarDatosCuenta(string _nroCuenta)
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

                if (_nroCuenta == nrocuenta)
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
    }
}
