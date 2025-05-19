using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocio
{
    public class NDashboard : DbConnection
    {

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

        public int CantidadTrabajadores()
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

    }
}
