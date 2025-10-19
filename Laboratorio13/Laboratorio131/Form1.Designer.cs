namespace Laboratorio131
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
            this.btnConexion = new System.Windows.Forms.Button();
            this.lbConsulta = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnConexion.Location = new System.Drawing.Point(271, 107);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(221, 85);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "Conectar y desconectar de SQL Server";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbConsulta
            // 
            this.lbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbConsulta.FormattingEnabled = true;
            this.lbConsulta.ItemHeight = 20;
            this.lbConsulta.Location = new System.Drawing.Point(237, 219);
            this.lbConsulta.Name = "lbConsulta";
            this.lbConsulta.Size = new System.Drawing.Size(288, 84);
            this.lbConsulta.TabIndex = 1;
            this.lbConsulta.SelectedIndexChanged += new System.EventHandler(this.lbConsulta_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbConsulta);
            this.Controls.Add(this.btnConexion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.ListBox lbConsulta;
    }
}

