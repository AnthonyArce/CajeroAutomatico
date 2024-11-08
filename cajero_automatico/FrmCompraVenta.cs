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
    public partial class FrmCompraVenta : Form
    {
        public FrmCompraVenta()
        {
            InitializeComponent();
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
    }
}
