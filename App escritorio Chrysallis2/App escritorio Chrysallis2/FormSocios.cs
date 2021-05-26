using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_escritorio_Chrysallis2
{
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            FormAltaModificarSocios form = new FormAltaModificarSocios("~ Dar de alta ~", "Añadir");
            form.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormAltaModificarSocios form = new FormAltaModificarSocios("~ Modificar ~", "Modificar", (Soci)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            form.ShowDialog();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {

 
            String mensajeAllSocios = "";
            bindingSourceSocis.DataSource = BD.SocioORM.SellectAllSocios(ref mensajeAllSocios);
            if (mensajeAllSocios != "")
            {
                MessageBox.Show(mensajeAllSocios, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscador.Text.Equals("Nombre"))
            {
                


                String mensajeSociosByNom = "";
                bindingSourceSocis.DataSource = BD.SocioORM.SellectSociosByNom(textBoxBuscador.Text, ref mensajeSociosByNom);
                if (mensajeSociosByNom != "")
                {
                    MessageBox.Show(mensajeSociosByNom, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }


            }
            if (comboBoxBuscador.Text.Equals("Apellidos"))
            {
                


                String mensajeSociosByApellido = "";
                bindingSourceSocis.DataSource = BD.SocioORM.SellectSociosByApellido(textBoxBuscador.Text, ref mensajeSociosByApellido);
                if (mensajeSociosByApellido != "")
                {
                    MessageBox.Show(mensajeSociosByApellido, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

            }
            if (comboBoxBuscador.Text.Equals("Teléfono"))
            {
                


                String mensajeSociosByTelefono = "";
                bindingSourceSocis.DataSource = BD.SocioORM.SellectSociosByTelefono(textBoxBuscador.Text, ref mensajeSociosByTelefono);
                if (mensajeSociosByTelefono != "")
                {
                    MessageBox.Show(mensajeSociosByTelefono, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

        }

        private void FormSocios_Activated(object sender, EventArgs e)
        {
            ArrayList aux = new ArrayList();
            bindingSourceSocis.DataSource = aux;

            String mensajeAllSocios = "";
            bindingSourceSocis.DataSource = BD.SocioORM.SellectAllSocios(ref mensajeAllSocios);
            if (mensajeAllSocios != "")
            {
                MessageBox.Show(mensajeAllSocios, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            Soci s = (Soci)dataGridViewSocios.SelectedRows[0].DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Seguro que quiere dar de baja el socio seleccionado?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {


                String mensaje = "";
                mensaje = BD.SocioORM.DeleteSoci(s);
                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("Socio eliminado correctamente", "SOCIO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoSocios form = new FormInfoSocios();
            form.Show();
        }

        private void dataGridViewSocios_DoubleClick(object sender, EventArgs e)
        {
            FormConsultarUsuario f = new FormConsultarUsuario((Soci)dataGridViewSocios.SelectedRows[0].DataBoundItem);
            f.ShowDialog();
        }
    }
}
