using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double ladoA = Convert.ToDouble(txbA.Text);
                double ladoB = Convert.ToDouble(txbB.Text);
                double ladoC = Convert.ToDouble(txbC.Text);

                double semiperimetro = (ladoA + ladoB + ladoC) / 2;

                txbSemiperimetro.Text = semiperimetro.ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbA.Clear();
            txbB.Clear();
            txbC.Clear();
            txbSemiperimetro.Clear();
            txbArea.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {   
            double ladoA = Convert.ToDouble(txbA.Text);
            double ladoB = Convert.ToDouble(txbB.Text);
            double ladoC = Convert.ToDouble(txbC.Text);

            double semiperimetro = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - ladoA) * (semiperimetro - ladoB) * (semiperimetro - ladoC));

            txbArea.Text = area.ToString("F2");

        }
    }
}
