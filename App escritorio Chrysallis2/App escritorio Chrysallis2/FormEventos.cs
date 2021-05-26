using System;
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
    public partial class FormEventos : Form
    {
        public FormEventos()
        {
            InitializeComponent();
        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAniadir_Click(object sender, EventArgs e)
        {
            FormAniadirModificar form = new FormAniadirModificar("~ Añadir ~", "Añadir");
            form.ShowDialog();


            String mensajeAllEsdeveniments = "";
            bindingSourceEventos.DataSource = BD.EventoORM.SellectAllEsdeveniments(ref mensajeAllEsdeveniments);
            if (mensajeAllEsdeveniments != "")
            {
                MessageBox.Show(mensajeAllEsdeveniments, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            FormAniadirModificar form = new FormAniadirModificar("~ Modificar ~", "Modificar",(esdeveniments) dataGridViewEventos.SelectedRows[0].DataBoundItem);
            form.ShowDialog();
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            String mensajeAllEsdeveniments = "";
            bindingSourceEventos.DataSource = BD.EventoORM.SellectAllEsdeveniments(ref mensajeAllEsdeveniments);
            if (mensajeAllEsdeveniments != "")
            {
                MessageBox.Show(mensajeAllEsdeveniments, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            String mensajeAllComunitats = "";
            bindingSourceComunidad.DataSource = BD.ComunidadesORM.SellectAllComunitats(ref mensajeAllComunitats);
            if (mensajeAllEsdeveniments != "")
            {
                MessageBox.Show(mensajeAllComunitats, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void pictureBoxAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            esdeveniments esd = (esdeveniments) dataGridViewEventos.SelectedRows[0].DataBoundItem;

            DialogResult resultado = MessageBox.Show("¿Seguro que quiere eliminar el evento seleccionado?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {


                String mensaje = "";
                mensaje = BD.EventoORM.DeleteEvento(esd);
                if (!mensaje.Equals(""))
                {

                    MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("Evento eliminado correctamente", "EVENTO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                String mensajeAllEsdeveniments = "";
                bindingSourceEventos.DataSource = BD.EventoORM.SellectAllEsdeveniments(ref mensajeAllEsdeveniments);
                if (mensajeAllEsdeveniments != "")
                {
                    MessageBox.Show(mensajeAllEsdeveniments, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private void dataGridViewEventos_DoubleClick(object sender, EventArgs e)
        {
            FormConsultarEvento form = new FormConsultarEvento((esdeveniments) dataGridViewEventos.SelectedRows[0].DataBoundItem);
            form.ShowDialog();
        }

        private void comboBoxComunidad_SelectedIndexChanged(object sender, EventArgs e)
        {


            String mensajeEventosByComunidad = "";
            bindingSourceEventos.DataSource = BD.EventoORM.SellectEventosByComunidad(int.Parse(comboBoxComunidad.SelectedValue.ToString()), ref mensajeEventosByComunidad);
            if (mensajeEventosByComunidad != "")
            {
                MessageBox.Show(mensajeEventosByComunidad, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
           

            String mensajeEventosByNom = "";
            bindingSourceEventos.DataSource = BD.EventoORM.SellectEventosByNom(int.Parse(comboBoxComunidad.SelectedValue.ToString()), textBoxBuscador.Text, ref mensajeEventosByNom);
            if (mensajeEventosByNom != "")
            {
                MessageBox.Show(mensajeEventosByNom, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoEventos form = new FormInfoEventos();
            form.Show();
        }
    }
}
