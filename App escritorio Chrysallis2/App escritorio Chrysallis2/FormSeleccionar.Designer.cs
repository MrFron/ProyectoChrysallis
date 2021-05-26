namespace App_escritorio_Chrysallis2
{
    partial class FormSeleccionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSeleccionar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxEventos = new System.Windows.Forms.PictureBox();
            this.pictureBoxSocios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(235, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Qué desea gestionar?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(169, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOCIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(580, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "EVENTOS";
            // 
            // pictureBoxEventos
            // 
            this.pictureBoxEventos.Image = global::App_escritorio_Chrysallis2.Properties.Resources.evento;
            this.pictureBoxEventos.Location = new System.Drawing.Point(485, 102);
            this.pictureBoxEventos.Name = "pictureBoxEventos";
            this.pictureBoxEventos.Size = new System.Drawing.Size(281, 264);
            this.pictureBoxEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEventos.TabIndex = 1;
            this.pictureBoxEventos.TabStop = false;
            this.pictureBoxEventos.Click += new System.EventHandler(this.pictureBoxEventos_Click);
            // 
            // pictureBoxSocios
            // 
            this.pictureBoxSocios.Image = global::App_escritorio_Chrysallis2.Properties.Resources.socios;
            this.pictureBoxSocios.Location = new System.Drawing.Point(84, 102);
            this.pictureBoxSocios.Name = "pictureBoxSocios";
            this.pictureBoxSocios.Size = new System.Drawing.Size(281, 264);
            this.pictureBoxSocios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSocios.TabIndex = 0;
            this.pictureBoxSocios.TabStop = false;
            this.pictureBoxSocios.Click += new System.EventHandler(this.pictureBoxSocios_Click);
            // 
            // FormSeleccionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(851, 499);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxEventos);
            this.Controls.Add(this.pictureBoxSocios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSeleccionar";
            this.Text = "Menú principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSocios;
        private System.Windows.Forms.PictureBox pictureBoxEventos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}