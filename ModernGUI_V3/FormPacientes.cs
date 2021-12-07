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
    public partial class FormPacientes : Form
    {
        public FormPacientes()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();

        }
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panel2.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel2.Controls.Add(formulario);
                panel2.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
           // if (Application.OpenForms["Form1"] == null)
           //     button4.BackColor = Color.FromArgb(4, 41, 68);
           // if (Application.OpenForms["Form2"] == null)
           //     btnNuevo.BackColor = Color.FromArgb(4, 41, 68);
           // if (Application.OpenForms["Form3"] == null)
           //     button3.BackColor = Color.FromArgb(4, 41, 68);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {


            // FrmNuevoPaciente Frm = new FrmNuevoPaciente();
            // mainMenu.Show();
            // this.Hide();
            ClsVariables.Paciente = "Nuevo";
            AbrirFormulario<FrmNuevoPaciente>();
            // AbrirFormEnPanel(new FrmNuevoPaciente());
            // Frm.Show();


        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClsVariables.Paciente = "Editar Paciente";
            AbrirFormulario<FrmNuevoPaciente>();

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            //button1.BackColor = Color.FromArgb(210, 45, 60);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
