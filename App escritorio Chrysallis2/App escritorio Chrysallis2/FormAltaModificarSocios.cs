using OC.Core.Crypto;
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
    public partial class FormAltaModificarSocios : Form
    {
        private String estado;
        private Soci soci;

        public FormAltaModificarSocios(String titulo, String estado, Soci soci)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
            this.estado = estado;
            this.soci = soci;
        }
        public FormAltaModificarSocios(String titulo, String estado)
        {
            InitializeComponent();
            labelTitulo.Text = titulo;
            this.estado = estado;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {


            Boolean admin = false;
            Boolean actiu = false;

            if (radioButtonAdmin.Checked)
            {
                admin = true;
            }
            if (radioButtonActiu.Checked)
            {
                actiu = true;
            }

            if (textBoxContrasena.Text.Equals(textBoxConfirm.Text))
            {

                

                if (estado.Equals("Añadir"))
                {

                    if (textBoxNombre.Text.Equals("") || textBoxApellidos.Text.Equals("") || textBoxMail.Text.Equals("") || textBoxTelefono.Text.Equals("") || textBoxContrasena.Text.Equals(""))
                    {
                        DialogResult resultado = MessageBox.Show("Rellene toda la información obligatoria. (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        String mensaje = "";
                        Hash hash = new Hash();
                        String contraencript = hash.Sha512(textBoxConfirm.Text);

                        mensaje = BD.SocioORM.InsertSoci(textBoxTelefono.Text, textBoxMail.Text, textBoxNombre.Text, textBoxApellidos.Text,
                             contraencript, actiu, admin);

                        if (!mensaje.Equals(""))
                        {

                            MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {

                            DialogResult resultado = MessageBox.Show("Socio añadido correctamente.", "ALTA SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

                }
                if (estado.Equals("Modificar"))
                {
                    if (textBoxNombre.Text.Equals("") || textBoxApellidos.Text.Equals("") || textBoxMail.Text.Equals("") || textBoxTelefono.Text.Equals(""))
                    {
                        DialogResult resultado = MessageBox.Show("Rellene toda la información obligatoria. (*)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else { 

                    String mensaje = "";

                    mensaje = BD.SocioORM.UpdateSoci(soci, textBoxNombre.Text, textBoxTelefono.Text, textBoxMail.Text, textBoxNombre.Text, textBoxApellidos.Text, actiu, admin);
                    this.Close();

                    if (!mensaje.Equals(""))
                    {

                        MessageBox.Show(mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        DialogResult resultado = MessageBox.Show("Socio modificado correctamente.", "MODIFICACIÓN DE SOCIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                    }
                }

            }

            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormAltaModificarSocios_Load(object sender, EventArgs e)
        {
            if (estado.Equals("Modificar"))
            {
                if (soci.administrador == true)
                {
                    radioButtonAdmin.Checked = true;
                    radioButtonNoAdmin.Checked = false;
                }
                else
                {
                    radioButtonAdmin.Checked = false;
                    radioButtonNoAdmin.Checked = true;
                }

                if (soci.actiu == true)
                {
                    radioButtonActiu.Checked = true;
                    radioButtonNoActiu.Checked = false;
                }
                else
                {
                    radioButtonActiu.Checked = false;
                    radioButtonNoActiu.Checked = true;
                }
                textBoxNombre.Text = soci.nom;
                textBoxApellidos.Text = soci.cognoms;
                textBoxMail.Text = soci.mail;
                textBoxTelefono.Text = soci.telefon;



                //textBoxContrasena.Text = soci.contrasenya;
                textBoxContrasena.Enabled = false;
                textBoxConfirm.Enabled = false;
            }



        }
    }
}
