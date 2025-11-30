using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Laboratorio203
{
    public partial class _Default : Page
    {

        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["ConexionProductos"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HabilitarControlesBusqueda();
            }
        }
        private void HabilitarControlesBusqueda()
        {
            tsbNuevo.Enabled = true;
            tsbGuardar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbEliminar.Enabled = false;

            tstId.Enabled = true;
            tsbBuscar.Enabled = true;

            txtId.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtStock.ReadOnly = true;

            txtId.Text = txtNombre.Text = txtPrecio.Text = txtStock.Text = string.Empty;
            tstId.Text = string.Empty;
            litMensaje.Text = string.Empty;
            hdnEstadoNuevo.Value = "false";
        }

        private void HabilitarControlesEdicion(bool isNew)
        {
            tsbNuevo.Enabled = false;
            tsbGuardar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbEliminar.Enabled = !isNew;

            tstId.Enabled = false;
            tsbBuscar.Enabled = false;

            txtId.ReadOnly = !isNew;
            txtNombre.ReadOnly = false;
            txtPrecio.ReadOnly = false;
            txtStock.ReadOnly = false;

            litMensaje.Text = string.Empty;
        }

        //Buscar
        protected void tsbBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstId.Text))
            {
                litMensaje.Text = "<span class='text-danger'>Ingrese un ID para buscar.</span>";
                return;
            }

            string sql = "SELECT Id, Nombre, Precio, Stock FROM LAPTOPS WHERE Id=@Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", tstId.Text);
                    con.Open();

                    try
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            // Encontrado: Cargar datos en los TextBoxes
                            txtId.Text = reader["Id"].ToString();
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtPrecio.Text = reader["Precio"].ToString();
                            txtStock.Text = reader["Stock"].ToString();

                            HabilitarControlesEdicion(false); // Modo edición
                            hdnEstadoNuevo.Value = "false";
                            litMensaje.Text = "<span class='text-success'>Registro encontrado. Puede modificar.</span>";
                        }
                        else
                        {
                            // No encontrado (Comportamiento de Lab 14)
                            HabilitarControlesBusqueda();
                            litMensaje.Text = "<span class='text-danger'>Ningún registro encontrado con el Id ingresado.</span>";
                        }
                    }
                    catch (Exception ex)
                    {
                        litMensaje.Text = $"<span class='text-danger'>Error al buscar: {ex.Message}</span>";
                    }
                }
            }
        }

        //Nuevo
        protected void tsbNuevo_Click(object sender, EventArgs e)
        {
            HabilitarControlesBusqueda();
            HabilitarControlesEdicion(true);
            hdnEstadoNuevo.Value = "true";
            litMensaje.Text = "<span class='text-primary'>Modo Nuevo. Ingrese datos.</span>";
        }

        //Guardar
        protected void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                litMensaje.Text = "<span class='text-danger'>Id y Nombre son obligatorios.</span>";
                return;
            }

            string sql;
            string mensaje;
            bool esNuevo = hdnEstadoNuevo.Value == "true";

            if (esNuevo)
            {
                //INSERTAR
                sql = "INSERT INTO LAPTOPS (Id, Nombre, Precio, Stock) VALUES (@Id, @Nombre, @Precio, @Stock)";
                mensaje = "Registro creado exitosamente.";
            }
            else
            {
                //ACTUALIZAR
                sql = "UPDATE LAPTOPS SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE Id=@Id";
                mensaje = "Registro actualizado exitosamente.";
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

                    decimal precio;
                    int stock;
                    decimal.TryParse(txtPrecio.Text, out precio);
                    int.TryParse(txtStock.Text, out stock);

                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        litMensaje.Text = $"<span class='text-success'>{mensaje}</span>";
                        HabilitarControlesBusqueda();
                    }
                    catch (Exception ex)
                    {
                        litMensaje.Text = $"<span class='text-danger'>Error al guardar: {ex.Message}</span>";
                    }
                }
            }
        }

        //Eliminar 
        protected void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (hdnEstadoNuevo.Value == "true" || string.IsNullOrEmpty(txtId.Text))
            {
                litMensaje.Text = "<span class='text-danger'>Operación de eliminación no válida.</span>";
                return;
            }

            string sql = "DELETE FROM LAPTOPS WHERE Id=@Id";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", txtId.Text);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            litMensaje.Text = "<span class='text-success'>Registro eliminado exitosamente.</span>";
                        }
                        else
                        {
                            litMensaje.Text = "<span class='text-warning'>El registro no fue encontrado para eliminar.</span>";
                        }

                        HabilitarControlesBusqueda();
                    }
                    catch (Exception ex)
                    {
                        litMensaje.Text = $"<span class='text-danger'>Error al eliminar: {ex.Message}</span>";
                    }
                }
            }
        }

        // Botón Cancelar 
        protected void tsbCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControlesBusqueda(); // Vuelve al estado inicial de búsqueda
            litMensaje.Text = "<span class='text-warning'>Operación cancelada.</span>";
        }
    }
}

