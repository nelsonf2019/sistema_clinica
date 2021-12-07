using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class FrmNuevoPaciente : Form
    {
        public FrmNuevoPaciente()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNuevoPaciente_Load(object sender, EventArgs e)
        {
            if (ClsVariables.Paciente == "Nuevo")
            {
                LblTitulo.Text = "Nuevo Paciente";
            } else{
                LblTitulo.Text = "Editar Paciente";
            }
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

          
            Form Formulario = new FrmCombo();
            Formulario.ShowDialog();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
