namespace StarWars3A
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkPeliculas = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkPeliculas
            // 
            this.linkPeliculas.AutoSize = true;
            this.linkPeliculas.Location = new System.Drawing.Point(334, 170);
            this.linkPeliculas.Name = "linkPeliculas";
            this.linkPeliculas.Size = new System.Drawing.Size(94, 13);
            this.linkPeliculas.TabIndex = 0;
            this.linkPeliculas.TabStop = true;
            this.linkPeliculas.Text = "Star Wars Movies!";
            this.linkPeliculas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkPeliculas);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkPeliculas;
    }
}

