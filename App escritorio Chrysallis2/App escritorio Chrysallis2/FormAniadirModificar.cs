using System;
using System.Collections;
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
    public partial class FormAniadirModificar : Form
    {
        byte[] file = null;

        List<documents> documentosEliminados = new List<documents>();
        List<documents> listaDoc = new List<documents>();
        List<documents> docsEvento = new List<documents>();
        List<String> rutas = new List<String>();
        esdeveniments evento;
        String estado;

        public FormAniadirModificar(String titulo, String estado, esdeveniments evento)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
            this.evento = evento;
            this.estado = estado;
            foreach (documents d in evento.documents)
            {
                docsEvento.Add(d);
            }
        }
        public FormAniadirModificar(String titulo, String estado)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
            this.estado = estado;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {


            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Arxiu de imatge|*.*";



            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                Stream s = BuscarImagen.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    s.CopyTo(ms);
                    file = ms.ToArray();
                    pictureBoxImagen.ImageLocation = BuscarImagen.FileName;
                    pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }

            
            

        }

        private void FormAniadirModificar_Load(object sender, EventArgs e)
        {
            
            String mensajeSelectComunidades = "";

            bindingSourceComunidad.DataSource = BD.ComunidadesORM.SellectAllComunitats(ref mensajeSelectComunidades);

            if (mensajeSelectComunidades != "")
            {
                MessageBox.Show(mensajeSelectComunidades, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (estado.Equals("Modificar")) {

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
                dateTimePickerFechaEvento.Text = evento.data.ToString();
                dateTimePickerFechaLimite.Text= evento.data_limit.ToString();
                textBoxHora.Text = evento.hora.ToString();
                comboBoxComunidad.SelectedValue = evento.id_comunitat;
                richTextBoxDescripcion.Text = evento.descripcio;
                bindingSourceDocumentos.DataSource = docsEvento;
                
            }
            

        }

        private void pictureBoxAniadir_Click(object sender, EventArgs e)
        {

            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Todos los archivos (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;


            if (estado.Equals("Modificar"))
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    //No utilizamos una clase nuestra, si no que utiizamos
                    //la clase documents del EntityFramework.
                    documents doc = new documents();

                    doc.nom = ofd.SafeFileName; //es el nombre sin la ruta.
                    doc.document = File.ReadAllBytes(ofd.FileName); //lee el fichero seleccionado y lo guarda como bytes

                    docsEvento.Add(doc);


                }

                bindingSourceDocumentos.DataSource = null;
                bindingSourceDocumentos.DataSource = docsEvento;


            }
            else
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    //No utilizamos una clase nuestra, si no que utiizamos
                    //la clase documents del EntityFramework.
                    documents doc = new documents();

                    doc.nom = ofd.SafeFileName; //es el nombre sin la ruta.
                    doc.document = File.ReadAllBytes(ofd.FileName); //lee el fichero seleccionado y lo guarda como bytes

                    listaDoc.Add(doc);
                    rutas.Add(ofd.FileName);

                }

                bindingSourceDocumentos.DataSource = null;
                bindingSourceDocumentos.DataSource = listaDoc;


            }

            

        }

        private void pictureBoxVisualizar_Click(object sender, EventArgs e)
        {
            

            if (estado.Equals("Modificar"))
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
            else {


                try
                {
                    String direccion = rutas[listBoxDocumentos.SelectedIndex];

                    Process proceso = new Process();
                    proceso.StartInfo.FileName = direccion;
                    proceso.Start();
                }
                catch (System.ArgumentOutOfRangeException)
                {

                    MessageBox.Show("No hay documentos seleccionados", "INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
   

            }

        }

        private void pictureBoxEliminar_Click(object sender, EventArgs e)
        {

            if (estado.Equals("Modificar"))
            {
                

                try
                {
                    documentosEliminados.Add(docsEvento[listBoxDocumentos.SelectedIndex]);
                    docsEvento.RemoveAt(listBoxDocumentos.SelectedIndex);
                    bindingSourceDocumentos.DataSource = null;
                    bindingSourceDocumentos.DataSource = docsEvento;
                }
                catch (System.ArgumentOutOfRangeException)
                {

                    MessageBox.Show("No hay documentos seleccionados", "INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else {
                

                try
                {
                    listaDoc.RemoveAt(listBoxDocumentos.SelectedIndex);
                    rutas.RemoveAt(listBoxDocumentos.SelectedIndex);

                    bindingSourceDocumentos.DataSource = null;
                    bindingSourceDocumentos.DataSource = listaDoc;
                }
                catch (System.ArgumentOutOfRangeException)
                {

                    MessageBox.Show("No hay documentos seleccionados", "INFOMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (estado.Equals("Modificar"))
            {
                if (textBoxNombre.Text.Equals("") || textBoxUbicacion.Text.Equals("") || textBoxHora.Text.Equals(""))
                {

                    DialogResult resultado = MessageBox.Show("Rellene toda la información obligatoria. (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {


                    String mensaje = "";
                    int comunidad = Convert.ToInt32(comboBoxComunidad.SelectedValue);

                    if (file == null)
                    {
                        file = evento.img;
                    }


                    try
                    {
                        mensaje = BD.EventoORM.UpdateEvento(evento, file, textBoxNombre.Text, textBoxUbicacion.Text, dateTimePickerFechaEvento.Value,
                        dateTimePickerFechaLimite.Value, TimeSpan.Parse(textBoxHora.Text), comunidad, richTextBoxDescripcion.Text, docsEvento);

                        if (!mensaje.Equals(""))
                        {

                            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            DialogResult resultado = MessageBox.Show("Evento modificado correctamente.", "MODIFICAR EVENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }



                        if (documentosEliminados.Count != 0)
                        {

                            String mens = "";
                            mens = BD.EventoORM.DeleteDocumentos(documentosEliminados);

                            if (!mensaje.Equals(""))
                            {

                                MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }
                    }
                    catch (System.FormatException ex)
                    {

                        DialogResult resultado = MessageBox.Show("ERROR EN EL FORMATO DE LA HORA \n El fromato de la hora debe ser HH:MM (Ej. 17:00).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    


                }



                

            }
            else
            {

                if (textBoxNombre.Text.Equals("") || textBoxUbicacion.Text.Equals("") || textBoxHora.Text.Equals(""))
                {

                    DialogResult resultado = MessageBox.Show("Rellene toda la información obligatoria. (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    String mensaje = "";
                    int comunidad = Convert.ToInt32(comboBoxComunidad.SelectedValue);


                    try
                    {
                        mensaje = BD.EventoORM.InsertEvento(file, textBoxNombre.Text, textBoxUbicacion.Text, dateTimePickerFechaEvento.Value,
                        dateTimePickerFechaLimite.Value, TimeSpan.Parse(textBoxHora.Text), comunidad, richTextBoxDescripcion.Text, listaDoc);


                        if (!mensaje.Equals(""))
                        {

                            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            DialogResult resultado = MessageBox.Show("Evento añadido correctamente.", "AÑADIR EVENTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    catch (System.FormatException ex)
                    {
                        DialogResult resultado = MessageBox.Show("ERROR EN EL FORMATO DE LA HORA \n El fromato de la hora debe ser HH:MM (Ej. 17:00).", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                
                



            }

            
        }

        private void FormAniadirModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(@"..\..\..\docs\");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }


            
            

        }

        private void pictureBoxInformación_Click(object sender, EventArgs e)
        {
            FormInfoAniadirModificarEvento form = new FormInfoAniadirModificarEvento();
            form.Show();
        }

        
    }
}
