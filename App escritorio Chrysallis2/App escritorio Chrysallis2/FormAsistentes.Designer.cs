namespace App_escritorio_Chrysallis2
{
    partial class FormAsistentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsistentes));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelValoracionMedia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAsistentes = new System.Windows.Forms.DataGridView();
            this.pictureBoxInformación = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actiuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunitatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAsistentes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.labelTitulo.Location = new System.Drawing.Point(121, 23);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(525, 39);
            this.labelTitulo.TabIndex = 84;
            this.labelTitulo.Text = " ~ ASISTENTES DEL EVENTO ~";
            // 
            // labelValoracionMedia
            // 
            this.labelValoracionMedia.AutoSize = true;
            this.labelValoracionMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracionMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.labelValoracionMedia.Location = new System.Drawing.Point(539, 398);
            this.labelValoracionMedia.Name = "labelValoracionMedia";
            this.labelValoracionMedia.Size = new System.Drawing.Size(39, 25);
            this.labelValoracionMedia.TabIndex = 89;
            this.labelValoracionMedia.Text = "AT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(164, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 25);
            this.label1.TabIndex = 88;
            this.label1.Text = "ASISTENTES TOTALES DEL EVENTO:";
            // 
            // dataGridViewAsistentes
            // 
            this.dataGridViewAsistentes.AllowUserToAddRows = false;
            this.dataGridViewAsistentes.AllowUserToDeleteRows = false;
            this.dataGridViewAsistentes.AutoGenerateColumns = false;
            this.dataGridViewAsistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAsistentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGridViewAsistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsistentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAsistentes.ColumnHeadersHeight = 30;
            this.dataGridViewAsistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAsistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.cognomsDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.actiuDataGridViewTextBoxColumn,
            this.administradorDataGridViewTextBoxColumn,
            this.assistirDataGridViewTextBoxColumn,
            this.comunitatsDataGridViewTextBoxColumn});
            this.dataGridViewAsistentes.DataSource = this.bindingSourceAsistentes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAsistentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAsistentes.EnableHeadersVisualStyles = false;
            this.dataGridViewAsistentes.GridColor = System.Drawing.Color.Black;
            this.dataGridViewAsistentes.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewAsistentes.MultiSelect = false;
            this.dataGridViewAsistentes.Name = "dataGridViewAsistentes";
            this.dataGridViewAsistentes.ReadOnly = true;
            this.dataGridViewAsistentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAsistentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAsistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAsistentes.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewAsistentes.TabIndex = 87;
            this.dataGridViewAsistentes.DoubleClick += new System.EventHandler(this.dataGridViewAsistentes_DoubleClick);
            // 
            // pictureBoxInformación
            // 
            this.pictureBoxInformación.Image = global::App_escritorio_Chrysallis2.Properties.Resources.informacion;
            this.pictureBoxInformación.Location = new System.Drawing.Point(704, 23);
            this.pictureBoxInformación.Name = "pictureBoxInformación";
            this.pictureBoxInformación.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxInformación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInformación.TabIndex = 91;
            this.pictureBoxInformación.TabStop = false;
            this.pictureBoxInformación.Click += new System.EventHandler(this.pictureBoxInformación_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_escritorio_Chrysallis2.Properties.Resources.atras;
            this.pictureBox1.Location = new System.Drawing.Point(9, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Visible = false;
            // 
            // actiuDataGridViewTextBoxColumn
            // 
            this.actiuDataGridViewTextBoxColumn.DataPropertyName = "actiu";
            this.actiuDataGridViewTextBoxColumn.HeaderText = "actiu";
            this.actiuDataGridViewTextBoxColumn.Name = "actiuDataGridViewTextBoxColumn";
            this.actiuDataGridViewTextBoxColumn.ReadOnly = true;
            this.actiuDataGridViewTextBoxColumn.Visible = false;
            // 
            // administradorDataGridViewTextBoxColumn
            // 
            this.administradorDataGridViewTextBoxColumn.DataPropertyName = "administrador";
            this.administradorDataGridViewTextBoxColumn.HeaderText = "administrador";
            this.administradorDataGridViewTextBoxColumn.Name = "administradorDataGridViewTextBoxColumn";
            this.administradorDataGridViewTextBoxColumn.ReadOnly = true;
            this.administradorDataGridViewTextBoxColumn.Visible = false;
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
            this.comunitatsDataGridViewTextBoxColumn.HeaderText = "comunitats";
            this.comunitatsDataGridViewTextBoxColumn.Name = "comunitatsDataGridViewTextBoxColumn";
            this.comunitatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.comunitatsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceAsistentes
            // 
            this.bindingSourceAsistentes.DataSource = typeof(App_escritorio_Chrysallis2.Soci);
            // 
            // FormAsistentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxInformación);
            this.Controls.Add(this.labelValoracionMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAsistentes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAsistentes";
            this.Text = "Asistentes del evento";
            this.Load += new System.EventHandler(this.FormAsistentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelValoracionMedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAsistentes;
        private System.Windows.Forms.PictureBox pictureBoxInformación;
        private System.Windows.Forms.BindingSource bindingSourceAsistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actiuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assistirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunitatsDataGridViewTextBoxColumn;
    }
}