namespace Laboratorio121
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisRecorrida = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbxIngValores = new System.Windows.Forms.TextBox();
            this.tbxValores2 = new System.Windows.Forms.TextBox();
            this.tbxDisTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(333, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratorio121";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(130, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vel(km/h)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(130, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo (H)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(130, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // btnDisRecorrida
            // 
            this.btnDisRecorrida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDisRecorrida.Location = new System.Drawing.Point(134, 233);
            this.btnDisRecorrida.Name = "btnDisRecorrida";
            this.btnDisRecorrida.Size = new System.Drawing.Size(185, 35);
            this.btnDisRecorrida.TabIndex = 4;
            this.btnDisRecorrida.Text = "Distancia Recorrida";
            this.btnDisRecorrida.UseVisualStyleBackColor = true;
            this.btnDisRecorrida.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLimpiar.Location = new System.Drawing.Point(335, 233);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(185, 35);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Pantalla";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSalir.Location = new System.Drawing.Point(538, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbxIngValores
            // 
            this.tbxIngValores.Location = new System.Drawing.Point(239, 109);
            this.tbxIngValores.Name = "tbxIngValores";
            this.tbxIngValores.Size = new System.Drawing.Size(228, 20);
            this.tbxIngValores.TabIndex = 7;
            this.tbxIngValores.TextChanged += new System.EventHandler(this.tbxIngValores_TextChanged);
            // 
            // tbxValores2
            // 
            this.tbxValores2.Location = new System.Drawing.Point(239, 173);
            this.tbxValores2.Name = "tbxValores2";
            this.tbxValores2.Size = new System.Drawing.Size(228, 20);
            this.tbxValores2.TabIndex = 8;
            this.tbxValores2.TextChanged += new System.EventHandler(this.tbxValores2_TextChanged);
            // 
            // tbxDisTotal
            // 
            this.tbxDisTotal.Location = new System.Drawing.Point(220, 311);
            this.tbxDisTotal.Name = "tbxDisTotal";
            this.tbxDisTotal.Size = new System.Drawing.Size(319, 20);
            this.tbxDisTotal.TabIndex = 9;
            this.tbxDisTotal.TextChanged += new System.EventHandler(this.tbxDisTotal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDisTotal);
            this.Controls.Add(this.tbxValores2);
            this.Controls.Add(this.tbxIngValores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDisRecorrida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisRecorrida;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbxIngValores;
        private System.Windows.Forms.TextBox tbxValores2;
        private System.Windows.Forms.TextBox tbxDisTotal;
    }
}

