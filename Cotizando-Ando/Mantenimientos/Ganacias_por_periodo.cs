using Punto_de_venta.Bases_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Mantenimientos
{
    public partial class Ganacias_por_periodo : Form
    {
        //Conexión a la base de datos
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Bases_de_datos.BPBEntities1();
        //filtro para el botón buscar
        DataView mifiltro;
        Double Precio_Reflejado = 0;
        Double Precio_Costo_Actual = 0;
        public Ganacias_por_periodo()
        {
            InitializeComponent();
            CargarDatos();
           
        }
        private void limpiar()
        {
            txtBuscar.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtGanancias.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtVenta.Text = string.Empty;
            Precio_Reflejado = 0;
            Precio_Costo_Actual = 0;
        }

        private void CargarDatos()
        {
           
            
            string year = (DateTime.Now.Year.ToString()).ToString();
            string day = (DateTime.Now.Day.ToString()).ToString();
            string mont = (DateTime.Now.Month.ToString()).ToString();
            int id = Convert.ToInt16(Punto_de_venta.Clases.Usuario.ID);
            if (mont.Length == 1)
            {
                mont = "0" + mont;
            }
            if (day.Length == 1)
            {
                day = "0" + day;
            }
            string FECHACALCULADA = year + '-' + mont + '-' + day + " 00:00:00";
        
            DateTime Fecha_Actual = DateTime.Parse(FECHACALCULADA);



           


            try
            {
                //int detalle = Convert.ToInt32(txtId.Text);
                var tDetalle = from det in entity.DetalleVentas
                               join prod in entity.Producto
                               on det.Producto equals prod.IdProducto
                               join fact in entity.Venta
                               on det.Venta equals fact.IdVenta
                               where fact.Fecha_Venta >= dtpInicial.Value && fact.Fecha_Venta <= dtpFinal.Value

                               select new
                               {
                                   fact.IdVenta,
                                   fact.Fecha_Venta,
                                   det.id,
                                   prod.Nombre,
                                   det.Cantidad,
                                   det.Precio_Reflejado,
                                   prod.PrecioCosto
                               };

                this.mifiltro = (tDetalle.CopyAnonymusToDataTable()).DefaultView;
                this.dgProductos.DataSource = mifiltro;




            }
            catch (Exception)
            {

            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpInicial.Value.ToString());
            limpiar();
            CargarDatos();
            foreach (DataGridViewRow dr in dgProductos.Rows)
            {
                string id = (dr.Cells[1].Value).ToString();

                try
                {
                    Precio_Costo_Actual += Convert.ToDouble(dr.Cells[4].Value) * Convert.ToDouble(dr.Cells[6].Value);
                    txtCosto.Text = Precio_Costo_Actual.ToString();

                    Precio_Reflejado += Convert.ToDouble(dr.Cells[4].Value) * Convert.ToDouble(dr.Cells[5].Value);
                    txtVenta.Text = Precio_Reflejado.ToString();

                   
                }
                catch (Exception)
                {
                    MessageBox.Show("Error, no hay registros");
                   
                }
                txtGanancias.Text =(Precio_Reflejado - Precio_Costo_Actual).ToString(); 

            }
        }

        private void cmbImpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
