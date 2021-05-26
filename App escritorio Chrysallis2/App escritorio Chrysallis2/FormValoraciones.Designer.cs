namespace App_escritorio_Chrysallis2
{
    partial class FormValoraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormValoraciones));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewValoraciones = new System.Windows.Forms.DataGridView();
            this.valoracióDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idsociDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idesdevenimentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numfamiliarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esdevenimentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceAsistentes = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelValoracionMedia = new System.Windows.Forms.Label();
            this.pictureBoxInformación = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.labelTitulo.Location = new System.Drawing.Point(93, 28);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(581, 39);
            this.labelTitulo.TabIndex = 62;
            this.labelTitulo.Text = " ~ VALORACIONES DEL EVENTO ~";
            // 
            // dataGridViewValoraciones
            // 
            this.dataGridViewValoraciones.AllowUserToAddRows = false;
            this.dataGridViewValoraciones.AllowUserToDeleteRows = false;
            this.dataGridViewValoraciones.AutoGenerateColumns = false;
            this.dataGridViewValoraciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewValoraciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.dataGridViewValoraciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValoraciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewValoraciones.ColumnHeadersHeight = 30;
            this.dataGridViewValoraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewValoraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valoracióDataGridViewTextBoxColumn,
            this.comentariDataGridViewTextBoxColumn,
            this.sociDataGridViewTextBoxColumn,
            this.idsociDataGridViewTextBoxColumn,
            this.idesdevenimentDataGridViewTextBoxColumn,
            this.numfamiliarsDataGridViewTextBoxColumn,
            this.esdevenimentsDataGridViewTextBoxColumn});
            this.dataGridViewValoraciones.DataSource = this.bindingSourceAsistentes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewValoraciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewValoraciones.EnableHeadersVisualStyles = false;
            this.dataGridViewValoraciones.GridColor = System.Drawing.Color.Black;
            this.dataGridViewValoraciones.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewValoraciones.MultiSelect = false;
            this.dataGridViewValoraciones.Name = "dataGridViewValoraciones";
            this.dataGridViewValoraciones.ReadOnly = true;
            this.dataGridViewValoraciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewValoraciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewValoraciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewValoraciones.Size = new System.Drawing.Size(776, 251);
            this.dataGridViewValoraciones.TabIndex = 84;
            this.dataGridViewValoraciones.DoubleClick += new System.EventHandler(this.dataGridViewValoraciones_DoubleClick);
            // 
            // valoracióDataGridViewTextBoxColumn
            // 
            this.valoracióDataGridViewTextBoxColumn.DataPropertyName = "valoració";
            this.valoracióDataGridViewTextBoxColumn.HeaderText = "Valoración";
            this.valoracióDataGridViewTextBoxColumn.Name = "valoracióDataGridViewTextBoxColumn";
            this.valoracióDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comentariDataGridViewTextBoxColumn
            // 
            this.comentariDataGridViewTextBoxColumn.DataPropertyName = "comentari";
            this.comentariDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentariDataGridViewTextBoxColumn.Name = "comentariDataGridViewTextBoxColumn";
            this.comentariDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sociDataGridViewTextBoxColumn
            // 
            this.sociDataGridViewTextBoxColumn.DataPropertyName = "Soci";
            this.sociDataGridViewTextBoxColumn.HeaderText = "Soci";
            this.sociDataGridViewTextBoxColumn.Name = "sociDataGridViewTextBoxColumn";
            this.sociDataGridViewTextBoxColumn.ReadOnly = true;
            this.sociDataGridViewTextBoxColumn.Visible = false;
            // 
            // idsociDataGridViewTextBoxColumn
            // 
            this.idsociDataGridViewTextBoxColumn.DataPropertyName = "id_soci";
            this.idsociDataGridViewTextBoxColumn.HeaderText = "id_soci";
            this.idsociDataGridViewTextBoxColumn.Name = "idsociDataGridViewTextBoxColumn";
            this.idsociDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsociDataGridViewTextBoxColumn.Visible = false;
            // 
            // idesdevenimentDataGridViewTextBoxColumn
            // 
            this.idesdevenimentDataGridViewTextBoxColumn.DataPropertyName = "id_esdeveniment";
            this.idesdevenimentDataGridViewTextBoxColumn.HeaderText = "id_esdeveniment";
            this.idesdevenimentDataGridViewTextBoxColumn.Name = "idesdevenimentDataGridViewTextBoxColumn";
            this.idesdevenimentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idesdevenimentDataGridViewTextBoxColumn.Visible = false;
            // 
            // numfamiliarsDataGridViewTextBoxColumn
            // 
            this.numfamiliarsDataGridViewTextBoxColumn.DataPropertyName = "num_familiars";
            this.numfamiliarsDataGridViewTextBoxColumn.HeaderText = "num_familiars";
            this.numfamiliarsDataGridViewTextBoxColumn.Name = "numfamiliarsDataGridViewTextBoxColumn";
            this.numfamiliarsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numfamiliarsDataGridViewTextBoxColumn.Visible = false;
            // 
            // esdevenimentsDataGridViewTextBoxColumn
            // 
            this.esdevenimentsDataGridViewTextBoxColumn.DataPropertyName = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.HeaderText = "esdeveniments";
            this.esdevenimentsDataGridViewTextBoxColumn.Name = "esdevenimentsDataGridViewTextBoxColumn";
            this.esdevenimentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.esdevenimentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceAsistentes
            // 
            this.bindingSourceAsistentes.DataSource = typeof(App_escritorio_Chrysallis2.assistir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(183)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(184, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "VALORACIÓN MEDIA DEL EVENTO:";
            // 
            // labelValoracionMedia
            // 
            this.labelValoracionMedia.AutoSize = true;
            this.labelValoracionMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValoracionMedia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.labelValoracionMedia.Location = new System.Drawing.Point(539, 393);
            this.labelValoracionMedia.Name = "labelValoracionMedia";
            this.labelValoracionMedia.Size = new System.Drawing.Size(43, 25);
            this.labelValoracionMedia.TabIndex = 86;
            this.labelValoracionMedia.Text = "VM";
            // 
            // pictureBoxInformación
            // 
            this.pictureBoxInformación.Image = global::App_escritorio_Chrysallis2.Properties.Resources.informacion;
            this.pictureBoxInformación.Location = new System.Drawing.Point(717, 28);
            this.pictureBoxInformación.Name = "pictureBoxInformación";
            this.pictureBoxInformación.Size = new System.Drawing.Size(55, 50);
            this.pictureBoxInformación.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInformación.TabIndex = 90;
            this.pictureBoxInformación.TabStop = false;
            this.pictureBoxInformación.Click += new System.EventHandler(this.pictureBoxInformación_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_escritorio_Chrysallis2.Properties.Resources.atras;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormValoraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxInformación);
            this.Controls.Add(this.labelValoracionMedia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewValoraciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormValoraciones";
            this.Text = "Valoraciones del evento";
            this.Load += new System.EventHandler(this.FormValoraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValoraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAsistentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInformación)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSourceAsistentes;
        private System.Windows.Forms.DataGridView dataGridViewValoraciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValoracionMedia;
        private System.Windows.Forms.PictureBox pictureBoxInformación;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracióDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsociDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idesdevenimentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfamiliarsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esdevenimentsDataGridViewTextBoxColumn;
    }
}