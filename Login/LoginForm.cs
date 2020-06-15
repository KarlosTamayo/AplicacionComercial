using Login.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == "Usuario:")
            {
                errorProvider1.SetError(UsuarioTextBox, "Debes ingresar un usuario");
                UsuarioTextBox.Focus();
                return;
            }

            errorProvider1.Clear();

            if (PasswordTextBox.Text == "Clave:")
            {
                errorProvider1.SetError(PasswordTextBox, "Debes ingresar una clave de acceso");
                PasswordTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (PasswordTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PasswordTextBox, "Debes ingresar una clave de acceso");
                PasswordTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (!CADUsuario.ValidarUsuario(UsuarioTextBox.Text, PasswordTextBox.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Posible intruso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsuarioTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                UsuarioTextBox.Focus();
                return;
            }

            frmPrincipal frm = new frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
