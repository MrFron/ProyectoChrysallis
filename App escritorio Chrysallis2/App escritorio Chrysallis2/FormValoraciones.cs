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
    public partial class FormValoraciones : Form
    {

        List<assistir> asistentes;
        esdeveniments evento;
        float vMedia;
        float sumVal;
        public FormValoraciones(esdeveniments evento)
        {
            InitializeComponent();
            this.evento = evento;
            


            String mensajeAsistentesByEvento = "";
            asistentes = BD.AsistirORM.SellectAsistentesByEvento(evento.id, ref mensajeAsistentesByEvento);
            if (mensajeAsistentesByEvento != "")
            {
                MessageBox.Show(mensajeAsistentesByEvento, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormValoraciones_Load(object sender, EventArgs e)
        {
            bindingSourceAsistentes.DataSource = asistentes;

            
            for (int i = 0; i < asistentes.Count; i++)
            {
                sumVal += int.Parse(asistentes[i].valoració.ToString());
            }

            vMedia = sumVal / asistentes.Count();
            labelValoracionMedia.Text = vMedia.ToString();
        }

        private void dataGridViewValoraciones_DoubleClick(object sender, EventArgs e)
        {
            assistir asis =(assistir) dataGridViewValoraciones.SelectedRows[0].DataBoundItem;
            MessageBox.Show("Valoración hecha por "+asis.Soci.nom+" "+asis.Soci.cognoms+ "\n Comentario: "+asis.comentari, "INFORMACIÓN DE LA VALORACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoValoraciones form = new FormInfoValoraciones();
            form.Show();
        }
    }
}
