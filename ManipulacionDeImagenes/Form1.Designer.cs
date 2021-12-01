
namespace ManipulacionDeImagenes
{
    partial class Form1
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
            this.original = new System.Windows.Forms.Button();
            this.invertir = new System.Windows.Forms.Button();
            this.gris = new System.Windows.Forms.Button();
            this.bw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.BackColor = System.Drawing.Color.Thistle;
            this.original.Location = new System.Drawing.Point(13, 13);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(75, 37);
            this.original.TabIndex = 0;
            this.original.Text = "Original";
            this.original.UseVisualStyleBackColor = false;
            this.original.MouseClick += new System.Windows.Forms.MouseEventHandler(this.original_MouseClick);
            // 
            // invertir
            // 
            this.invertir.BackColor = System.Drawing.Color.Lime;
            this.invertir.Location = new System.Drawing.Point(100, 13);
            this.invertir.Name = "invertir";
            this.invertir.Size = new System.Drawing.Size(75, 37);
            this.invertir.TabIndex = 1;
            this.invertir.Text = "Invertir";
            this.invertir.UseVisualStyleBackColor = false;
            this.invertir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.invertir_MouseClick);
            // 
            // gris
            // 
            this.gris.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gris.Location = new System.Drawing.Point(308, 13);
            this.gris.Name = "gris";
            this.gris.Size = new System.Drawing.Size(75, 37);
            this.gris.TabIndex = 3;
            this.gris.Text = "Grises";
            this.gris.UseVisualStyleBackColor = false;
            this.gris.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gris_MouseClick);
            // 
            // bw
            // 
            this.bw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bw.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bw.Location = new System.Drawing.Point(187, 13);
            this.bw.Name = "bw";
            this.bw.Size = new System.Drawing.Size(109, 37);
            this.bw.TabIndex = 2;
            this.bw.Text = "Blanco/Negro";
            this.bw.UseVisualStyleBackColor = false;
            this.bw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bw_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 603);
            this.Controls.Add(this.gris);
            this.Controls.Add(this.bw);
            this.Controls.Add(this.invertir);
            this.Controls.Add(this.original);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button original;
        private System.Windows.Forms.Button invertir;
        private System.Windows.Forms.Button gris;
        private System.Windows.Forms.Button bw;
    }
}

