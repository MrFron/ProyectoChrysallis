namespace App_escritorio_Chrysallis2
{
    partial class FormEventos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventos));
            this.dataGridViewEventos = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacióDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datalimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomunitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.assistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificacionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAniadir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxComunidad = new System.Windows.Forms.ComboBox();
            this.bindingSourceComunidad = new System.Windows.Forms.BindingSource(this.components);
            this.comunitatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.pictureBoxInformación = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEventos
            // 
            this.dataGridViewEventos.AllowUserToAddRows = false;
            this.dataGridViewEventos.AllowUserToDeleteRows = false;
            this.dataGridViewEventos.AutoGenerateColumns = false;
            this.dataGridViewEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEventos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGridViewEventos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEventos.ColumnHeadersHeight = 30;
            this.dataGridViewEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.ubicacióDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.datalimitDataGridViewTextBoxColumn,
            this.idcomunitatDataGridViewTextBoxColumn,
            this.descripcioDataGridViewTextBoxColumn,
            this.imgDataGridViewImageColumn,
            this.assistirDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.notificacionsDataGridViewTextBoxColumn});
            this.dataGridViewEventos.DataSource = this.bindingSourceEventos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEventos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEventos.EnableHeadersVisualStyles = false;
            this.dataGridViewEventos.GridColor = System.Drawing.Color.Black;
            this.dataGridViewEventos.Location = new System.Drawing.Point(12, 282);
            this.dataGridViewEventos.MultiSelect = false;
            this.dataGridViewEventos.Name = "dataGridViewEventos";
            this.dataGridViewEventos.ReadOnly = true;
            this.dataGridViewEventos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEventos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEventos.Size = new System.Drawing.Size(776, 261);
            this.dataGridViewEventos.TabIndex = 0;
            this.dataGridViewEventos.DoubleClick += new System.EventHandler(this.dataGridViewEventos_DoubleClick);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ubicacióDataGridViewTextBoxColumn
            // 
            this.ubicacióDataGridViewTextBoxColumn.DataPropertyName = "ubicació";
            this.ubicacióDataGridViewTextBoxColumn.HeaderText = "Ubicación";
            this.ubicacióDataGridViewTextBoxColumn.Name = "ubicacióDataGridViewTextBoxColumn";
            this.ubicacióDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // datalimitDataGridViewTextBoxColumn
            // 
            this.datalimitDataGridViewTextBoxColumn.DataPropertyName = "data_limit";
            this.datalimitDataGridViewTextBoxColumn.HeaderText = "data_limit";
            this.datalimitDataGridViewTextBoxColumn.Name = "datalimitDataGridViewTextBoxColumn";
            this.datalimitDataGridViewTextBoxColumn.ReadOnly = true;
            this.datalimitDataGridViewTextBoxColumn.Visible = false;
            // 
            // idcomunitatDataGridViewTextBoxColumn
            // 
            this.idcomunitatDataGridViewTextBoxColumn.DataPropertyName = "id_comunitat";
            this.idcomunitatDataGridViewTextBoxColumn.HeaderText = "id_comunitat";
            this.idcomunitatDataGridViewTextBoxColumn.Name = "idcomunitatDataGridViewTextBoxColumn";
            this.idcomunitatDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomunitatDataGridViewTextBoxColumn.Visible = false;
            // 
            // descripcioDataGridViewTextBoxColumn
            // 
            this.descripcioDataGridViewTextBoxColumn.DataPropertyName = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.HeaderText = "descripcio";
            this.descripcioDataGridViewTextBoxColumn.Name = "descripcioDataGridViewTextBoxColumn";
            this.descripcioDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcioDataGridViewTextBoxColumn.Visible = false;
            // 
            // imgDataGridViewImageColumn
            // 
            this.imgDataGridViewImageColumn.DataPropertyName = "img";
            this.imgDataGridViewImageColumn.HeaderText = "img";
            this.imgDataGridViewImageColumn.Name = "imgDataGridViewImageColumn";
            this.imgDataGridViewImageColumn.ReadOnly = true;
            this.imgDataGridViewImageColumn.Visible = false;
            // 
            // assistirDataGridViewTextBoxColumn
            // 
            this.assistirDataGridViewTextBoxColumn.DataPropertyName = "assistir";
            this.assistirDataGridViewTextBoxColumn.HeaderText = "assistir";
            this.assistirDataGridViewTextBoxColumn.Name = "assistirDataGridViewTextBoxColumn";
            this.assistirDataGridViewTextBoxColumn.ReadOnly = true;
            this.assistirDataGridViewTextBoxColumn.Visible = false;
            // 
            // comunitatsDataGridViewTextBoxColumn
            // 
            this.comunitatsDataGridViewTextBoxColumn.DataPropertyName = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.HeaderText = "Comunidad";
            this.comunitatsDataGridViewTextBoxColumn.Name = "comunitatsDataGridViewTextBoxColumn";
            this.comunitatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunitatsDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "documents";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // notificacionsDataGridViewTextBoxColumn
            // 
            this.notificacionsDataGridViewTextBoxColumn.DataPropertyName = "notificacions";
            this.notificacionsDataGridViewTextBoxColumn.HeaderText = "notificacions";
            this.notificacionsDataGridViewTextBoxColumn.Name = "notificacionsDataGridViewTextBoxColumn";
            this.notificacionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.notificacionsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(App_escritorio_Chrysallis2.esdeveniments);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.LightGray;
            this.buttonModificar.FlatAppearance.BorderSize = 2;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModificar.Location = new System.Drawing.Point(199, 153);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(140, 39);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightGray;
            this.buttonEliminar.FlatAppearance.BorderSize = 2;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(369, 153);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(140, 39);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "ELIMINAR";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAniadir
            // 
            this.buttonAniadir.BackColor = System.Drawing.Color.LightGray;
            this.buttonAniadir.FlatAppearance.BorderSize = 2;
            this.buttonAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAniadir.Location = new System.Drawing.Point(23, 153);
            this.buttonAniadir.Name = "buttonAniadir";
            this.buttonAniadir.Size = new System.Drawing.Size(140, 39);
            this.buttonAniadir.TabIndex = 4;
            this.buttonAniadir.Text = "AÑADIR";
            this.buttonAniadir.UseVisualStyleBackColor = false;
            this.buttonAniadir.Click += new System.EventHandler(this.buttonAniadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 55F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 85);
            this.label1.TabIndex = 6;
            this.label1.Text = "EVENTOS";
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.Image = global::App_escritorio_Chrysallis2.Properties.Resources.atras;
            this.pictureBoxAtras.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(52, 55);
            this.pictureBoxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAtras.TabIndex = 16;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_escritorio_Chrysallis2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxComunidad
            // 
            this.comboBoxComunidad.DataSource = this.bindingSourceComunidad;
            this.comboBoxComunidad.DisplayMember = "nom";
            this.comboBoxComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComunidad.FormattingEnabled = true;
            this.comboBoxComunidad.Location = new System.Drawing.Point(56, 240);
            this.comboBoxComunidad.Name = "comboBoxComunidad";
            this.comboBoxComunidad.Size = new System.Drawing.Size(283, 21);
            this.comboBoxComunidad.TabIndex = 18;
            this.comboBoxComunidad.ValueMember = "id";
            this.comboBoxComunidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxComunidad_SelectedIndexChanged);
            // 
            // bindingSourceComunidad
            // 
            this.bindingSourceComunidad.DataSource = typeof(App_escritorio_Chrysallis2.comunitats);
            // 
            // comunitatsBindingSource
            // 
            this.comunitatsBindingSource.DataSource = typeof(App_escritorio_Chrysallis2.comunitats);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Seleccione una comunidad para mostrar sus eventos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(526, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del evento:";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.Color.LightGray;
            this.textBoxBuscador.Location = new System.Drawing.Point(440, 241);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(327, 20);
            this.textBoxBuscador.TabIndex = 21;
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // pictureBoxInformación
            // 
            this.pictureBoxInformación.Image = global::App_escritorio_Chrysallis2.Properties.Resources.informacion;
            this.pictureBoxInformación.Location = new System.Drawing.Point(485, 52);
            this.pictureBoxInformación.Name = "pictureBoxInformación";
            this.pictureBoxInformación.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxInformación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInformación.TabIndex = 36;
            this.pictureBoxInformación.TabStop = false;
            this.pictureBoxInformación.Click += new System.EventHandler(this.pictureBoxInformación_Click);
            // 
            // FormEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.pictureBoxInformación);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxComunidad);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAniadir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.dataGridViewEventos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.FormEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceComunidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunitatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEventos;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAniadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxComunidad;
        private System.Windows.Forms.BindingSource bindingSourceComunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacióDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datalimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomunitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imgDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificacionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comunitatsBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.PictureBox pictureBoxInformación;
    }
}