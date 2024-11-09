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
        public FrmInicio()
        {
            InitializeComponent();
            txtPin.PasswordChar = '*';
            txtPin.MaxLength = 4;

            btnVerPin.MouseDown += BtnVerPin_MouseDown;
            btnVerPin.MouseUp += BtnVerPin_MouseUp;

            btnCancelar.Click += BtnCancelar_Click;
        }
        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnVerPin_MouseDown(object sender, MouseEventArgs e)
        {
            txtPin.PasswordChar = '\0';
        }

        private void BtnVerPin_MouseUp(object sender, MouseEventArgs e)
        {
            txtPin.PasswordChar = '*';  
        }

        // Evento KeyPress para permitir solo números
        private void txtNumeroCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
                FileStream FS = new FileStream("C:\\cajero\\Cliente.txt", FileMode.Open);
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

        private void btnIngresar_Click(object sender, EventArgs e)
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
    }
}
