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
    public partial class FormConsultarUsuario : Form
    {
        private Soci soci;

        public FormConsultarUsuario(Soci soci)
        {
            InitializeComponent();
            this.soci = soci;
        }

        private void FormConsultarUsuario_Load(object sender, EventArgs e)
        {

            textBoxNombre.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxCorreo.Enabled = false;
            textBoxTelefono.Enabled = false;

            if (soci.administrador == true)
            {
                labelAdmin.Text = "USUARI@ ADMINISTRADOR";
            }
            else
            {
                labelAdmin.Text = "USUARI@ NO ADMINISTRADOR";
            }

            if (soci.actiu == true)
            {
                labelActiu.Text = "USUARI@ ACTIU";
            }
            else
            {
                labelActiu.Text = "USUARI@ NO ACTIU";
            }

            textBoxNombre.Text = soci.nom;
            textBoxApellidos.Text = soci.cognoms;
            textBoxCorreo.Text = soci.mail;
            textBoxTelefono.Text = soci.telefon;

        }

        private void pictureBoxAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
