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
    public partial class FormSeleccionar : Form
    {
        public FormSeleccionar()
        {
            InitializeComponent();
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }

        private void pictureBoxSocios_Click(object sender, EventArgs e)
        {

            FormSocios form = new FormSocios();
            form.ShowDialog();

        }

        private void pictureBoxEventos_Click(object sender, EventArgs e)
        {
            FormEventos form = new FormEventos();
            form.ShowDialog();
        }
    }
}
