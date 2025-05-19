using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
namespace PedidosApp1
{
    public partial class Dashboard : Form
    {
        //Fields
        private NDashboard model;

        //Constructor
        public Dashboard()
        {
            InitializeComponent();
            model = new NDashboard();
            
        }

        //Private methods
        private void LoadData()
        {
            try
            {
                int cantidadVentas = model.ObtenerCantidadVentas();
                lblCantidadVentas.Text = cantidadVentas.ToString(); // Mostrar en la etiqueta
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cantidad de ventas: " + ex.Message);
            }

        }
        private void DisableCustomDates()
        {
           
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dgvUnderstock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCantidadVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
