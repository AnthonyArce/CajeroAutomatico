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
    public partial class FrmInicio : Form
    {
        private bool passVisible = false;
        public FrmInicio()
        {
            InitializeComponent();
            btnCancelar.Click += BtnCancelar_Click;
            txtPin.PasswordChar = '*';
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtDni.Clear();  
            txtPin.Clear(); 
        }

        bool validarUser()
        {
            try
            {
                FileStream FS = new FileStream("D:\\cajero\\Cliente.txt", FileMode.Open);
                StreamReader SR = new StreamReader(FS);

                String[] vectorregistro;
                String registro;
                String dni, pass;
                bool isUser = false;

                while (SR.Peek() != -1 && !isUser)
                {
                    registro = SR.ReadLine();
                    vectorregistro = registro.Split(';');
                    dni = vectorregistro[1];
                    pass = vectorregistro[7];

                    if (dni == txtDni.Text)
                    {
                        if (pass == txtPin.Text)
                        {
                            isUser = true;
                        }
                    }

                }

                SR.Close();
                FS.Close();

                return isUser;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Hubo un error al intentar leer el archivo clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool isUserValido  = false;

            isUserValido = validarUser();

            if (isUserValido)
            {
                FrmPrincipal frmPrincipal = new FrmPrincipal(txtDni.Text);
                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmPrincipal.Show();

            }
            else {

                MessageBox.Show($"Usuario o contraseña invalida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnVerPin_Click(object sender, EventArgs e)
        {
            if (passVisible)
            {
                passVisible = false;
                txtPin.PasswordChar = '*';
            }
            else {
                passVisible = true;
                txtPin.PasswordChar = '\0';
            }
        }

        private void AgregarNumero(string numero)
        {
            txtPin.Text += numero;
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
            if (txtPin.Text.Length > 0)
            {
                txtPin.Text = txtPin.Text.Substring(0, txtPin.Text.Length - 1);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            txtPin.Text = "";
            txtDni.Text = "";
        }
    }
}
