namespace App_escritorio_Chrysallis2
{
    partial class FormSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSocios));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.comboBoxBuscador = new System.Windows.Forms.ComboBox();
            this.pictureBoxInformación = new System.Windows.Forms.PictureBox();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewSocios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceSocis = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 98);
            this.label1.TabIndex = 13;
            this.label1.Text = "SOCIOS";
            // 
            // buttonAlta
            // 
            this.buttonAlta.BackColor = System.Drawing.Color.LightGray;
            this.buttonAlta.FlatAppearance.BorderSize = 2;
            this.buttonAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAlta.Location = new System.Drawing.Point(21, 169);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(173, 39);
            this.buttonAlta.TabIndex = 11;
            this.buttonAlta.Text = "DAR DE ALTA";
            this.buttonAlta.UseVisualStyleBackColor = false;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.LightGray;
            this.buttonModificar.FlatAppearance.BorderSize = 2;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModificar.Location = new System.Drawing.Point(212, 169);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(146, 39);
            this.buttonModificar.TabIndex = 15;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.BackColor = System.Drawing.Color.LightGray;
            this.buttonBaja.FlatAppearance.BorderSize = 2;
            this.buttonBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBaja.Location = new System.Drawing.Point(377, 169);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(173, 39);
            this.buttonBaja.TabIndex = 16;
            this.buttonBaja.Text = "DAR DE BAJA";
            this.buttonBaja.UseVisualStyleBackColor = false;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(17, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar por: ";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.BackColor = System.Drawing.Color.LightGray;
            this.textBoxBuscador.Location = new System.Drawing.Point(298, 223);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(490, 20);
            this.textBoxBuscador.TabIndex = 19;
            this.textBoxBuscador.TextChanged += new System.EventHandler(this.textBoxBuscador_TextChanged);
            // 
            // comboBoxBuscador
            // 
            this.comboBoxBuscador.BackColor = System.Drawing.Color.LightGray;
            this.comboBoxBuscador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBuscador.FormattingEnabled = true;
            this.comboBoxBuscador.Items.AddRange(new object[] {
            "Nombre",
            "Apellidos",
            "Teléfono"});
            this.comboBoxBuscador.Location = new System.Drawing.Point(118, 222);
            this.comboBoxBuscador.Name = "comboBoxBuscador";
            this.comboBoxBuscador.Size = new System.Drawing.Size(174, 21);
            this.comboBoxBuscador.TabIndex = 20;
            // 
            // pictureBoxInformación
            // 
            this.pictureBoxInformación.Image = global::App_escritorio_Chrysallis2.Properties.Resources.informacion;
            this.pictureBoxInformación.Location = new System.Drawing.Point(478, 65);
            this.pictureBoxInformación.Name = "pictureBoxInformación";
            this.pictureBoxInformación.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxInformación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInformación.TabIndex = 36;
            this.pictureBoxInformación.TabStop = false;
            this.pictureBoxInformación.Click += new System.EventHandler(this.pictureBoxInformación_Click);
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.Image = global::App_escritorio_Chrysallis2.Properties.Resources.atras;
            this.pictureBoxAtras.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(52, 55);
            this.pictureBoxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAtras.TabIndex = 14;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_escritorio_Chrysallis2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewSocios
            // 
            this.dataGridViewSocios.AllowUserToAddRows = false;
            this.dataGridViewSocios.AllowUserToDeleteRows = false;
            this.dataGridViewSocios.AutoGenerateColumns = false;
            this.dataGridViewSocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGridViewSocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSocios.ColumnHeadersHeight = 30;
            this.dataGridViewSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.cognomsDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridViewSocios.DataSource = this.bindingSourceSocis;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSocios.EnableHeadersVisualStyles = false;
            this.dataGridViewSocios.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSocios.Location = new System.Drawing.Point(12, 246);
            this.dataGridViewSocios.MultiSelect = false;
            this.dataGridViewSocios.Name = "dataGridViewSocios";
            this.dataGridViewSocios.ReadOnly = true;
            this.dataGridViewSocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSocios.Size = new System.Drawing.Size(776, 261);
            this.dataGridViewSocios.TabIndex = 37;
            this.dataGridViewSocios.DoubleClick += new System.EventHandler(this.dataGridViewSocios_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomsDataGridViewTextBoxColumn
            // 
            this.cognomsDataGridViewTextBoxColumn.DataPropertyName = "cognoms";
            this.cognomsDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.cognomsDataGridViewTextBoxColumn.Name = "cognomsDataGridViewTextBoxColumn";
            this.cognomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Teléfono";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceSocis
            // 
            this.bindingSourceSocis.DataSource = typeof(App_escritorio_Chrysallis2.Soci);
            // 
            // FormSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.dataGridViewSocios);
            this.Controls.Add(this.pictureBoxInformación);
            this.Controls.Add(this.comboBoxBuscador);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonAlta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSocios";
            this.Text = "Socios";
            this.Activated += new System.EventHandler(this.FormSocios_Activated);
            this.Load += new System.EventHandler(this.FormSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSocis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.BindingSource bindingSourceSocis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.ComboBox comboBoxBuscador;
        private System.Windows.Forms.PictureBox pictureBoxInformación;
        private System.Windows.Forms.DataGridView dataGridViewSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
    }
}