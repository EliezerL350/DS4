using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double velcidad = Convert.ToDouble(tbxIngValores.Text);
                double tiempo = Convert.ToDouble(tbxValores2.Text);

                double resultado = velcidad * tiempo;

                tbxDisTotal.Text = "Resultado" + resultado.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Error: Por favor ingrese valores numéricos válidos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Los valores ingresados son demasiado grandes o pequeños.", "Error de desbordamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxIngValores_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxValores2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDisTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxIngValores.Clear();
            tbxValores2.Clear();
            tbxDisTotal.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
