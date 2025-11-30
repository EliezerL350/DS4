using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _202
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDimension.Text, out int N) || N <= 0)
            {
                litMatriz.Text = "<span style='color:red'>ingrese un número entero positivo (N > 0).</span>";
                return;
            }

            StringBuilder matrizHTML = new StringBuilder();

            matrizHTML.Append("<table border='1' cellpadding='10' cellspacing='0' style='border-collapse:collapse; text-align:center; font-family:monospace;'>");

            for (int i = 0; i < N; i++)
            {
                matrizHTML.Append("<tr>");

                for (int j = 0; j < N; j++)
                {
                    int valorCelda = 0;

                    if (i + j == N - 1)
                    {
                        valorCelda = 1;
                    }
                    string estilo = (valorCelda == 1) ? "background-color: #f2f2f2; font-weight: bold;" : "";

                    matrizHTML.Append($"<td style='width: 30px; height: 30px; {estilo}'>{valorCelda}</td>");
                }

                matrizHTML.Append("</tr>"); 
            }
            matrizHTML.Append("</table>"); 

            litMatriz.Text = matrizHTML.ToString();
        }
    }
}