namespace Laboratorio122
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txbNota1 = new System.Windows.Forms.TextBox();
            this.txbNota2 = new System.Windows.Forms.TextBox();
            this.txbNota3 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbPromedio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNota1.Location = new System.Drawing.Point(202, 111);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(114, 24);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "NOTA No. 1";
            this.lblNota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNota2.Location = new System.Drawing.Point(202, 153);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(114, 24);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "NOTA No. 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblNota3.Location = new System.Drawing.Point(202, 197);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(114, 24);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "NOTA No. 3";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPromedio.Location = new System.Drawing.Point(202, 341);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(136, 24);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Nota Promedio";
            this.lblPromedio.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbNota1
            // 
            this.txbNota1.Location = new System.Drawing.Point(344, 111);
            this.txbNota1.Name = "txbNota1";
            this.txbNota1.Size = new System.Drawing.Size(109, 20);
            this.txbNota1.TabIndex = 4;
            this.txbNota1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbNota2
            // 
            this.txbNota2.Location = new System.Drawing.Point(344, 153);
            this.txbNota2.Name = "txbNota2";
            this.txbNota2.Size = new System.Drawing.Size(109, 20);
            this.txbNota2.TabIndex = 5;
            // 
            // txbNota3
            // 
            this.txbNota3.Location = new System.Drawing.Point(344, 201);
            this.txbNota3.Name = "txbNota3";
            this.txbNota3.Size = new System.Drawing.Size(109, 20);
            this.txbNota3.TabIndex = 6;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPromedio.Location = new System.Drawing.Point(206, 253);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(108, 37);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReset.Location = new System.Drawing.Point(330, 253);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 37);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSalir.Location = new System.Drawing.Point(444, 253);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 37);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbPromedio
            // 
            this.txbPromedio.Location = new System.Drawing.Point(353, 345);
            this.txbPromedio.Name = "txbPromedio";
            this.txbPromedio.Size = new System.Drawing.Size(110, 20);
            this.txbPromedio.TabIndex = 10;
            this.txbPromedio.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbPromedio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txbNota3);
            this.Controls.Add(this.txbNota2);
            this.Controls.Add(this.txbNota1);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txbNota1;
        private System.Windows.Forms.TextBox txbNota2;
        private System.Windows.Forms.TextBox txbNota3;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbPromedio;
    }
}

