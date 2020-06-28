using Login.DS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin1 : Form
    {
       

        public frmLogin1()
        {
            InitializeComponent();
        }

        #region moverPantalla

        //********** codigo para mover la pantalla*********************************
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region button
        private void aceptarButton_Click(object sender, EventArgs e)
        {         

            if (ClaveextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ClaveextBox, "Debes ingresar una clave de acceso");
                ClaveextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (!CADUsuario.ValidarUsuario(UsuarioTextBox.Text, ClaveextBox.Text))
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Posible intruso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UsuarioTextBox.Text = string.Empty;
                ClaveextBox.Text = string.Empty;
                UsuarioTextBox.Focus();
                return;
            }

            frmPrincipalMDI frm = new frmPrincipalMDI();
            this.Hide();
            frm.Show();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Procedes a cerrar", "Precaución", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }

        }
        #endregion

        #region frmLogin
        private void frmLogin1_Load(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void frmLogin1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }
        #endregion

        #region label
        private void IniciodeseccionLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void HaOlvidadoLaContraseñeaLabel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        #endregion

        #region cerrarMinizar
        private void MinimizarPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Procedes a cerrar", "Precaución", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }


        }
        #endregion

        #region texbox
        private void UsuarioTextBox_Enter(object sender, EventArgs e)
        {

        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == string.Empty)
            {
                UsuarioTextBox.Text = "Usuario:";
                UsuarioTextBox.ForeColor = Color.DimGray;
            }
        }

        private void ClaveextBox_Enter(object sender, EventArgs e)
        {
            if (ClaveextBox.Text == "Clave:")
            {
                ClaveextBox.Text = String.Empty;
                ClaveextBox.ForeColor = Color.DimGray;
                ClaveextBox.UseSystemPasswordChar = true;
            }
        }

        private void ClaveextBox_Leave(object sender, EventArgs e)
        {
            if (ClaveextBox.Text == string.Empty)
            {
                ClaveextBox.Text = "Clave:";
                ClaveextBox.ForeColor = Color.DimGray;
                ClaveextBox.UseSystemPasswordChar = false;
            }
        }
        #endregion

        #region imagen
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

     
    }   
}
