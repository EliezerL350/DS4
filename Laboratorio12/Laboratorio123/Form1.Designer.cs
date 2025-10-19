namespace Laboratorio123
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSemiperimetro = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txbArea = new System.Windows.Forms.TextBox();
            this.txbSemiperimetro = new System.Windows.Forms.TextBox();
            this.txbC = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.txbA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa la longitud del lado A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(104, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(104, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la longitud del lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(104, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semiperimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(104, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area";
            // 
            // btnSemiperimetro
            // 
            this.btnSemiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSemiperimetro.Location = new System.Drawing.Point(144, 190);
            this.btnSemiperimetro.Name = "btnSemiperimetro";
            this.btnSemiperimetro.Size = new System.Drawing.Size(129, 39);
            this.btnSemiperimetro.TabIndex = 5;
            this.btnSemiperimetro.Text = "Semiperimetro";
            this.btnSemiperimetro.UseVisualStyleBackColor = true;
            this.btnSemiperimetro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArea
            // 
            this.btnArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnArea.Location = new System.Drawing.Point(286, 190);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(101, 39);
            this.btnArea.TabIndex = 6;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(398, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 39);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalir.Location = new System.Drawing.Point(510, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 39);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salida";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txbArea
            // 
            this.txbArea.Location = new System.Drawing.Point(153, 322);
            this.txbArea.Name = "txbArea";
            this.txbArea.Size = new System.Drawing.Size(100, 20);
            this.txbArea.TabIndex = 9;
            // 
            // txbSemiperimetro
            // 
            this.txbSemiperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbSemiperimetro.Location = new System.Drawing.Point(222, 269);
            this.txbSemiperimetro.Name = "txbSemiperimetro";
            this.txbSemiperimetro.Size = new System.Drawing.Size(100, 26);
            this.txbSemiperimetro.TabIndex = 10;
            // 
            // txbC
            // 
            this.txbC.Location = new System.Drawing.Point(323, 131);
            this.txbC.Name = "txbC";
            this.txbC.Size = new System.Drawing.Size(100, 20);
            this.txbC.TabIndex = 11;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(323, 80);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 12;
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(323, 31);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbC);
            this.Controls.Add(this.txbSemiperimetro);
            this.Controls.Add(this.txbArea);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnSemiperimetro);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSemiperimetro;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txbArea;
        private System.Windows.Forms.TextBox txbSemiperimetro;
        private System.Windows.Forms.TextBox txbC;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.TextBox txbA;
    }
}

