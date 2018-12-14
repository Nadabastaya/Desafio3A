namespace StarWars3A
{
    partial class DetallePelicula
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblIdEpisodio = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblPersonajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(32, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(41, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título: ";
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Location = new System.Drawing.Point(32, 57);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(82, 13);
            this.lblFechaEmision.TabIndex = 2;
            this.lblFechaEmision.Text = "Fecha Emisión: ";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(32, 93);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(50, 13);
            this.lblDirector.TabIndex = 3;
            this.lblDirector.Text = "Director: ";
            // 
            // lblIdEpisodio
            // 
            this.lblIdEpisodio.AutoSize = true;
            this.lblIdEpisodio.Location = new System.Drawing.Point(32, 127);
            this.lblIdEpisodio.Name = "lblIdEpisodio";
            this.lblIdEpisodio.Size = new System.Drawing.Size(67, 13);
            this.lblIdEpisodio.TabIndex = 4;
            this.lblIdEpisodio.Text = "ID Episodio: ";
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(572, 28);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(58, 13);
            this.lblResumen.TabIndex = 5;
            this.lblResumen.Text = "Resumen: ";
            // 
            // lblPersonajes
            // 
            this.lblPersonajes.AutoSize = true;
            this.lblPersonajes.Location = new System.Drawing.Point(238, 28);
            this.lblPersonajes.Name = "lblPersonajes";
            this.lblPersonajes.Size = new System.Drawing.Size(65, 13);
            this.lblPersonajes.TabIndex = 6;
            this.lblPersonajes.Text = "Personajes: ";
            // 
            // DetallePelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPersonajes);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblIdEpisodio);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblFechaEmision);
            this.Controls.Add(this.lblTitulo);
            this.Name = "DetallePelicula";
            this.Text = "ANewHope";
            this.Load += new System.EventHandler(this.ANewHope_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblIdEpisodio;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblPersonajes;
    }
}