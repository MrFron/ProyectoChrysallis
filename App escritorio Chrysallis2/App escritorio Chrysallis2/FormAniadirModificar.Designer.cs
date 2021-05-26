namespace App_escritorio_Chrysallis2
{
    partial class FormAniadirModificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAniadirModificar));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.BtnSeleccionarImagen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxUbicacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidad = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxEliminar = new System.Windows.Forms.PictureBox();
            this.pictureBoxVisualizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxAniadir = new System.Windows.Forms.PictureBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.listBoxDocumentos = new System.Windows.Forms.ListBox();
            this.bindingSourceDocumentos = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxInformación = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAniadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.labelTitulo.Location = new System.Drawing.Point(334, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(248, 54);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = " ~ Añadir ~";
            // 
            // BtnSeleccionarImagen
            // 
            this.BtnSeleccionarImagen.BackColor = System.Drawing.Color.Gray;
            this.BtnSeleccionarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnSeleccionarImagen.Location = new System.Drawing.Point(411, 113);
            this.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            this.BtnSeleccionarImagen.Size = new System.Drawing.Size(126, 62);
            this.BtnSeleccionarImagen.TabIndex = 7;
            this.BtnSeleccionarImagen.Text = "Seleccionar imágen";
            this.BtnSeleccionarImagen.UseVisualStyleBackColor = false;
            this.BtnSeleccionarImagen.Click += new System.EventHandler(this.BtnSeleccionarImagen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "NOMBRE*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "UBICACIÓN*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "FECHA EVENTO*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(12, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "HORA*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(818, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "DESCRIPCIÓN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(818, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "DOCUMENTOS";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.LightGray;
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxNombre.Location = new System.Drawing.Point(265, 235);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(347, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxUbicacion
            // 
            this.textBoxUbicacion.BackColor = System.Drawing.Color.LightGray;
            this.textBoxUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxUbicacion.Location = new System.Drawing.Point(265, 267);
            this.textBoxUbicacion.Name = "textBoxUbicacion";
            this.textBoxUbicacion.Size = new System.Drawing.Size(347, 23);
            this.textBoxUbicacion.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(12, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "FECHA LIMITE DE REGISTRO*";
            // 
            // textBoxHora
            // 
            this.textBoxHora.BackColor = System.Drawing.Color.LightGray;
            this.textBoxHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxHora.Location = new System.Drawing.Point(265, 367);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(347, 23);
            this.textBoxHora.TabIndex = 5;
            // 
            // dateTimePickerFechaEvento
            // 
            this.dateTimePickerFechaEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerFechaEvento.Location = new System.Drawing.Point(265, 299);
            this.dateTimePickerFechaEvento.Name = "dateTimePickerFechaEvento";
            this.dateTimePickerFechaEvento.Size = new System.Drawing.Size(347, 23);
            this.dateTimePickerFechaEvento.TabIndex = 3;
            this.dateTimePickerFechaEvento.Value = new System.DateTime(2020, 3, 21, 19, 54, 6, 0);
            // 
            // dateTimePickerFechaLimite
            // 
            this.dateTimePickerFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateTimePickerFechaLimite.Location = new System.Drawing.Point(265, 335);
            this.dateTimePickerFechaLimite.Name = "dateTimePickerFechaLimite";
            this.dateTimePickerFechaLimite.Size = new System.Drawing.Size(347, 23);
            this.dateTimePickerFechaLimite.TabIndex = 4;
            // 
            // richTextBoxDescripcion
            // 
            this.richTextBoxDescripcion.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescripcion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.richTextBoxDescripcion.Location = new System.Drawing.Point(700, 354);
            this.richTextBoxDescripcion.Name = "richTextBoxDescripcion";
            this.richTextBoxDescripcion.Size = new System.Drawing.Size(347, 173);
            this.richTextBoxDescripcion.TabIndex = 7;
            this.richTextBoxDescripcion.Text = "";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCancelar.Location = new System.Drawing.Point(151, 482);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(126, 45);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "CANCELAR";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAceptar.Location = new System.Drawing.Point(390, 482);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(126, 45);
            this.buttonAceptar.TabIndex = 27;
            this.buttonAceptar.Text = "ACEPTAR";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(12, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "COMUNIDAD DEL EVENTO*";
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.BackColor = System.Drawing.Color.Gray;
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidad;
            this.comboBoxComunidad.DisplayMember = "nom";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(265, 402);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(347, 24);
            this.comboBoxComunidad.TabIndex = 6;
            this.comboBoxComunidad.ValueMember = "id";
            // 
            // bindingSourceComunidad
            // 
            this.bindingSourceComunidad.DataSource = typeof(App_escritorio_Chrysallis2.comunitats);
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.Image = global::App_escritorio_Chrysallis2.Properties.Resources.menos;
            this.pictureBoxEliminar.Location = new System.Drawing.Point(846, 92);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEliminar.TabIndex = 33;
            this.pictureBoxEliminar.TabStop = false;
            this.pictureBoxEliminar.Click += new System.EventHandler(this.pictureBoxEliminar_Click);
            // 
            // pictureBoxVisualizar
            // 
            this.pictureBoxVisualizar.Image = global::App_escritorio_Chrysallis2.Properties.Resources.ojo;
            this.pictureBoxVisualizar.Location = new System.Drawing.Point(960, 92);
            this.pictureBoxVisualizar.Name = "pictureBoxVisualizar";
            this.pictureBoxVisualizar.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxVisualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVisualizar.TabIndex = 32;
            this.pictureBoxVisualizar.TabStop = false;
            this.pictureBoxVisualizar.Click += new System.EventHandler(this.pictureBoxVisualizar_Click);
            // 
            // pictureBoxAniadir
            // 
            this.pictureBoxAniadir.Image = global::App_escritorio_Chrysallis2.Properties.Resources.mas;
            this.pictureBoxAniadir.Location = new System.Drawing.Point(733, 92);
            this.pictureBoxAniadir.Name = "pictureBoxAniadir";
            this.pictureBoxAniadir.Size = new System.Drawing.Size(41, 37);
            this.pictureBoxAniadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAniadir.TabIndex = 31;
            this.pictureBoxAniadir.TabStop = false;
            this.pictureBoxAniadir.Click += new System.EventHandler(this.pictureBoxAniadir_Click);
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBoxImagen.Location = new System.Drawing.Point(65, 63);
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.Size = new System.Drawing.Size(240, 143);
            this.pictureBoxImagen.TabIndex = 1;
            this.pictureBoxImagen.TabStop = false;
            // 
            // listBoxDocumentos
            // 
            this.listBoxDocumentos.DataSource = this.bindingSourceDocumentos;
            this.listBoxDocumentos.DisplayMember = "nom";
            this.listBoxDocumentos.FormattingEnabled = true;
            this.listBoxDocumentos.Location = new System.Drawing.Point(700, 148);
            this.listBoxDocumentos.Name = "listBoxDocumentos";
            this.listBoxDocumentos.Size = new System.Drawing.Size(347, 160);
            this.listBoxDocumentos.TabIndex = 34;
            this.listBoxDocumentos.ValueMember = "id";
            // 
            // bindingSourceDocumentos
            // 
            this.bindingSourceDocumentos.DataSource = typeof(App_escritorio_Chrysallis2.documents);
            // 
            // pictureBoxInformación
            // 
            this.pictureBoxInformación.Image = global::App_escritorio_Chrysallis2.Properties.Resources.informacion;
            this.pictureBoxInformación.Location = new System.Drawing.Point(635, 9);
            this.pictureBoxInformación.Name = "pictureBoxInformación";
            this.pictureBoxInformación.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxInformación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInformación.TabIndex = 35;
            this.pictureBoxInformación.TabStop = false;
            this.pictureBoxInformación.Click += new System.EventHandler(this.pictureBoxInformación_Click);
            // 
            // FormAniadirModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1070, 560);
            this.Controls.Add(this.pictureBoxInformación);
            this.Controls.Add(this.listBoxDocumentos);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.pictureBoxVisualizar);
            this.Controls.Add(this.pictureBoxAniadir);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.richTextBoxDescripcion);
            this.Controls.Add(this.dateTimePickerFechaLimite);
            this.Controls.Add(this.dateTimePickerFechaEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUbicacion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionarImagen);
            this.Controls.Add(this.pictureBoxImagen);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAniadirModificar";
            this.Text = "Evento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAniadirModificar_FormClosing);
            this.Load += new System.EventHandler(this.FormAniadirModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAniadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.Button BtnSeleccionarImagen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxUbicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaLimite;
        private System.Windows.Forms.RichTextBox richTextBoxDescripcion;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.PictureBox pictureBoxAniadir;
        private System.Windows.Forms.PictureBox pictureBoxVisualizar;
        private System.Windows.Forms.PictureBox pictureBoxEliminar;
        private System.Windows.Forms.BindingSource bindingSourceComunidad;
        private System.Windows.Forms.ListBox listBoxDocumentos;
        private System.Windows.Forms.BindingSource bindingSourceDocumentos;
        private System.Windows.Forms.PictureBox pictureBoxInformación;
    }
}