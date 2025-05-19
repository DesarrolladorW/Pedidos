using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaDatos;
using CapaNegocio;

namespace PedidosApp1
{
    public partial class Dasboard12 : Form
    {
        private readonly NDashboard model = new NDashboard();
        public Dasboard12()
        {
            InitializeComponent();
            
        }
        private void CargarCantidadTrabajadores()
        {
            try
            {
                int totalTrabajadores = model.ObtenerCantidadTrabajadores();
                lblTrabajador.Text = totalTrabajadores.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar trabajadores: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCantidadVentas()
        {
            try
            {
                int total = model.ObtenerCantidadVentas();
                lblventas.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCantidadProveedores()
        {
            try
            {
                int totalProveedores = model.ObtenerCantidadProveedores();
                lblCantidadProveedor.Text = totalProveedores.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarPrecioVentaPorFechaProduccionDetalle()
        {
            try
            {
                var datos = model.ObtenerPrecioVentaPorFechaProduccionDetalle();

                if (datos.Count == 0)
                {
                    MessageBox.Show("No hay datos de precio de venta en Detalle_ingreso.");
                    return;
                }

                Chartdetalle_ingreso.Series.Clear();
                Chartdetalle_ingreso.ChartAreas.Clear();

                // Configurar el área del gráfico
                ChartArea area = new ChartArea("Area1");
                area.AxisX.LabelStyle.Angle = -45;
                area.AxisX.Interval = 1;
                area.AxisX.Title = "Fecha de Producción";
                area.AxisY.Title = "Precio de Venta";
                area.AxisY.LabelStyle.Format = "C2"; // Formato de moneda

                Chartdetalle_ingreso.ChartAreas.Add(area);

                // Crear la serie sin mostrar los valores sobre las barras
                Series serie = new Series("Precio Venta Detalle")
                {
                    ChartType = SeriesChartType.Column,
                    XValueType = ChartValueType.String
                    // IsValueShownAsLabel eliminado para no mostrar texto arriba
                };

                foreach (var item in datos)
                {
                    int idx = serie.Points.AddXY(item.Fecha.ToString("dd/MM/yyyy"), Convert.ToDouble(item.CantidadDecimal));
                    serie.Points[idx].ToolTip = $"Fecha: {item.Fecha:dd/MM/yyyy}: {item.CantidadDecimal:C}";
                }

                Chartdetalle_ingreso.Series.Add(serie);
                Chartdetalle_ingreso.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar precios: " + ex.Message);
            }
        }
        private void Dasboard12_Load(object sender, EventArgs e)
        {
            CargarCantidadVentas();
            CargarCantidadTrabajadores();
            CargarCantidadProveedores();
            CargarPrecioVentaPorFechaProduccionDetalle();
            CargarArticulos();

        }

        private void lblventas_Click(object sender, EventArgs e)
        {

        }

        private void lblTrabajador_Click(object sender, EventArgs e)
        {

        }

        private void lblCantidadProveedor_Click(object sender, EventArgs e)
        {

        }

        private void Chartdetalle_ingreso_Click(object sender, EventArgs e)
        {

        }
        private void CargarArticulos()
        {
            try
            {
                var articulos = model.ObtenerArticulosConCategoriaYPres();
                dataArticulo.DataSource = articulos;

                // Cambiar nombres de columnas opcionalmente
                dataArticulo.Columns["IdArticulo"].HeaderText = "ID";
                dataArticulo.Columns["Codigo"].HeaderText = "Código";
                dataArticulo.Columns["Nombre"].HeaderText = "Nombre";
                dataArticulo.Columns["Descripcion"].HeaderText = "Descripción";
                dataArticulo.Columns["Categoria"].HeaderText = "Categoría";
                dataArticulo.Columns["Presentacion"].HeaderText = "Presentación";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }


        private void lblPresentacion_Click(object sender, EventArgs e)
        {

        }
       
        private void dataArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataArticulo.Rows[e.RowIndex];

                lblCategoria.Text = fila.Cells["Categoria"].Value?.ToString();
                lblPresentacion.Text = fila.Cells["Presentacion"].Value?.ToString();
            }

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
