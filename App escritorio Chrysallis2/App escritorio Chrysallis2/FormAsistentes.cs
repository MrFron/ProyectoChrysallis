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
    public partial class FormAsistentes : Form
    {
        esdeveniments evento;
        
        List<Soci> sociosAsistentes;
        List<assistir> asistentes;
        int asTotales;
        public FormAsistentes(esdeveniments evento)
        {
            InitializeComponent();
            this.evento = evento;


           
            string mensajeSociosAsistentesByEvento = "";
            sociosAsistentes = BD.AsistirORM.SellectSociosAsistentesByEvento(evento.id, ref mensajeSociosAsistentesByEvento);
            if (mensajeSociosAsistentesByEvento != "")
            {
                MessageBox.Show(mensajeSociosAsistentesByEvento, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }


            string mensajeAsistentesByEvento = "";
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

        private void FormAsistentes_Load(object sender, EventArgs e)
        {
            bindingSourceAsistentes.DataSource = sociosAsistentes;
            
            for (int i = 0; i < asistentes.Count; i++)
            {
                asTotales += int.Parse(asistentes[i].num_familiars.ToString());
            }
            asTotales = asTotales + sociosAsistentes.Count();
            labelValoracionMedia.Text = asTotales.ToString();
        }

        private void dataGridViewAsistentes_DoubleClick(object sender, EventArgs e)
        {
            Soci socio = (Soci)dataGridViewAsistentes.SelectedRows[0].DataBoundItem;



            

            string mensajeAsistentesBySocio = "";
            assistir asistencia = BD.AsistirORM.SellectAsistentesBySocio(socio, evento.id, ref mensajeAsistentesBySocio);
            if (mensajeAsistentesBySocio != "")
            {
                MessageBox.Show(mensajeAsistentesBySocio, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }




            MessageBox.Show(socio.nom+" "+socio.cognoms+ " llevará "+asistencia.num_familiars+" acompañante(s).", "INFORMACIÓN DEL SOCIO ASISTENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoAsistentes form = new FormInfoAsistentes();
            form.Show();
        }
    }
}
