using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Dominio;
namespace ModernGUI_V3
{
    #region Detalles Formulario Usuario
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            BtnAceptar.Select();


        }
        #region//METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PnlBarra_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void PnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "USUARIO")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.DimGray;

            }
        }

       
        

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {

            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.Silver;

            }

        }

        private void TxtContraseña_Leave(object sender, EventArgs e)
        {
                
            if (TxtContraseña.Text == "")
            {
                TxtContraseña.Text = "Contraseña";
                TxtContraseña.ForeColor = Color.Silver;

            }

        }

        private void TxtUsuario_Leave_1(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.Silver;

            }
        }

        private void TxtUsuario_Enter_1(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Silver;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                // TxtContraseña.Select();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FormPrincipal mainMenu = new FormPrincipal();
            mainMenu.Show();
            this.Hide();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)

        {

            FormPrincipal mainMenu = new FormPrincipal();
            mainMenu.Show();
            this.Hide();
        }

        private void lineShape4_Click(object sender, EventArgs e)
        {

        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_Enter_2(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.DimGray;

            }
        }

        private void TxtContraseña_Enter_1(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "Contraseña")
            {
                TxtContraseña.Text = "";
                TxtContraseña.ForeColor = Color.DimGray;

            }
        }

        private void TxtUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 ^ e.KeyChar == 11)
            {
                TxtContraseña.Focus();
                e.Handled = true;
            }
        }

        private void TxtContraseña_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                BtnAceptar.Focus();

                e.Handled = true;
            }
        }
    }
    #endregion


}
