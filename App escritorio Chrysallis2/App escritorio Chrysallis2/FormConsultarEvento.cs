using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_escritorio_Chrysallis2
{
    public partial class FormConsultarEvento : Form
    {
        esdeveniments evento;
        List<documents> docsEvento = new List<documents>();

        public FormConsultarEvento(esdeveniments evento)
        {
            InitializeComponent();
            this.evento = evento;
            foreach (documents d in evento.documents)
            {
                docsEvento.Add(d);
            }
        }

        private void FormConsultarEvento_Load(object sender, EventArgs e)
        {
            Bitmap bm = null;

            if (evento.img != null)
            {
                MemoryStream ms = new MemoryStream(evento.img);

                try
                {
                    bm = new Bitmap(ms);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
            pictureBoxImagen.Image = bm;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            textBoxNombre.Text = evento.nom;
            textBoxUbicacion.Text = evento.ubicació;
            textBoxFechaEvento.Text = evento.data.ToString();
            textBoxFechaLimite.Text = evento.data_limit.ToString();
            textBoxHora.Text = evento.hora.ToString();
            textBoxComunidad.Text = evento.comunitats.nom;
            richTextBoxDescripcion.Text = evento.descripcio;
            bindingSourceDocumentos.DataSource = docsEvento;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxVisualizar_Click(object sender, EventArgs e)
        {
            

            try
            {
                byte[] doc = docsEvento[listBoxDocumentos.SelectedIndex].document;
                File.WriteAllBytes(@"..\..\..\docs\" + docsEvento[listBoxDocumentos.SelectedIndex].nom, doc);
                String direccion = @"..\..\..\docs\" + docsEvento[listBoxDocumentos.SelectedIndex].nom;
                Process proceso = new Process();
                proceso.StartInfo.FileName = direccion;
                proceso.Start();
            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("No hay documentos seleccionados", "INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormConsultarEvento_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(@"..\..\..\docs\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoConsultarEvento form = new FormInfoConsultarEvento();
            form.Show();
        }

        private void buttonAsistentes_Click(object sender, EventArgs e)
        {
            FormAsistentes form = new FormAsistentes(evento);
            form.Show();
        }

        private void buttonValoraciones_Click(object sender, EventArgs e)
        {
            FormValoraciones form = new FormValoraciones(evento);
            form.Show();
        }
    }
}
