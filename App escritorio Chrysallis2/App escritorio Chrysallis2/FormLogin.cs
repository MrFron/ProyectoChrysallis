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
    public partial class FormLogin : Form
    {
        List<Soci> socios;
        bool log = false;

        public FormLogin()
        {
            InitializeComponent();
            

            String mensajeAllSocios = "";
            socios = BD.SocioORM.SellectAllSocios(ref mensajeAllSocios);
            if (mensajeAllSocios != "")
            {
                MessageBox.Show(mensajeAllSocios, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {

            if (textBoxUsuario.Text.Equals("") || textBoxContra.Text.Equals(""))
            {

                MessageBox.Show("Porfavor rellene toda la información.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

            foreach (Soci soci in socios)
            {
                string user = textBoxUsuario.Text;
                Hash hash = new Hash();
                String contr = hash.Sha512(textBoxContra.Text);


                if (user.Equals(soci.telefon) && contr.Equals(soci.contrasenya) && soci.administrador == true)
                {

                    log = true;
                    this.Close();


                }

            }

            if (log == false)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (log == false)
            {
                Application.Exit();
            }
        }
    }
}
