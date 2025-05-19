using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

using CapaNegocio;

namespace PedidosApp1
{
   public class NDashboard : DbConnection
    {
        public int ObtenerCantidadTrabajadores()
        {
            int cantidad = 0;
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Trabajador", connection))
                {
                    cantidad = (int)command.ExecuteScalar();
                }
            }
            return cantidad;
        }
        // Método para obtener la cantidad total de ventas
        public int ObtenerCantidadVentas()
        {
            int cantidad = 0;
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Venta", connection))
                {
                    cantidad = (int)command.ExecuteScalar();
                }
            }
            return cantidad;
        }
        public int ObtenerCantidadProveedores()
        {
            int cantidad = 0;
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Proveedor", connection))
                {
                    cantidad = (int)command.ExecuteScalar();
                }
            }
            return cantidad;
        }
        public List<FechaCantidadDecimal> ObtenerPrecioVentaPorFechaProduccionDetalle()
        {
            var lista = new List<FechaCantidadDecimal>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = @"
            SELECT fecha_produccion, precio_venta
            FROM Detalle_ingreso
            ORDER BY fecha_produccion";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new FechaCantidadDecimal
                        {
                            Fecha = reader.GetDateTime(0),
                            CantidadDecimal = reader.GetDecimal(1)
                        });
                    }
                }
            }

            return lista;
        }
        public List<ArticuloDTO> ObtenerArticulosConCategoriaYPres()
        {
            var lista = new List<ArticuloDTO>();

            using (SqlConnection connection = GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT a.Idarticulo, a.Codigo, a.Nombre, a.Descripcion,
                   c.Nombre AS CategoriaNombre,
                   p.Nombre AS PresentacionNombre
            FROM Articulo a
            INNER JOIN Categoria c ON a.Idcategoria = c.Idcategoria
            INNER JOIN Presentacion p ON a.Idpresentacion = p.Idpresentacion
            ORDER BY a.Idarticulo";

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ArticuloDTO
                        {
                            IdArticulo = reader.GetInt32(0),
                            Codigo = reader.GetString(1),
                            Nombre = reader.GetString(2),
                            Descripcion = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            Categoria = reader.GetString(4),
                            Presentacion = reader.GetString(5)
                        });
                    }
                }
            }

            return lista;
        }



    }
} 