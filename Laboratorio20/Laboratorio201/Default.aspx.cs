using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio201
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                litResultado.Text = "<span style='color:red'>Por favor, ingrese un número válido.</span>";
                return;
            }

            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);

                StringBuilder tablaHTML = new StringBuilder();

                tablaHTML.Append("<table border='1' cellpadding='5' style='border-collapse:collapse;'>");
                tablaHTML.Append("<tr style='background-color:#f2f2f2;'><th>Operación</th><th>Resultado</th></tr>");

                for (int i = 1; i <= 25; i++)
                {
                    int resultado = numero * i;

                    tablaHTML.Append("<tr>");
                    tablaHTML.Append($"<td>{numero} x {i}</td>");
                    tablaHTML.Append($"<td>{resultado}</td>");
                    tablaHTML.Append("</tr>");
                }

                tablaHTML.Append("</table>");


                litResultado.Text = tablaHTML.ToString();
            }
            catch (Exception ex)
            {
                litResultado.Text = $"<span style='color:red'>Error: {ex.Message}</span>";
            }
        }
    }
}