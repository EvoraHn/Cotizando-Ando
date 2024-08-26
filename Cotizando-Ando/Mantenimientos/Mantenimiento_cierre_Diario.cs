using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using Punto_de_venta.Bases_de_datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Punto_de_venta.Mantenimientos
{
    public partial class Mantenimiento_cierre_Diario : Form
    {
        public Mantenimiento_cierre_Diario()
        {
            InitializeComponent();
        }
        private void Formulario_Ventas_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            Ver_ventas_usuario();
            Mostrar_datos();
            
        }
        private string stringToPrint = "";
        //Conexión a la base de datos
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Bases_de_datos.BPBEntities1();
        //filtro para el botón buscar
        DataView mifiltro;
        //inicializar las variables
        string id = "000000";
        int idDetalle = 0;
        bool errorV = false;
        bool cotizacion = false;
        //tabla temporal
        DataTable dtTemporal = new DataTable();

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDetalle_Transaccion.RowCount > 0)
            {
                try
                {
                    id = Convert.ToString(dgDetalle_Transaccion.SelectedCells[0].Value);
                    var tabla = entity.Producto.FirstOrDefault(x => x.IdProducto == id);
                    //txtId.Text = tabla.IdProducto;
                    //txtProducto.Text = tabla.Nombre;
                }
                catch (Exception)
                { }
            }
        }
        private void dgFactura_SelectionChanged(object sender, EventArgs e)
        {
            //if (ctMeses.RowCount > 0)
            //{
            //    try
            //    {
            //        idDetalle = Convert.ToInt32(ctMeses.SelectedCells[0].Value);
            //        var tabla = entity.DetalleVentas.FirstOrDefault(x => x.id == Convert.ToInt32(idDetalle));
            //    }
            //    catch (Exception)
            //    { }
            //}
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }
        //where p.Fecha_Venta <= (DateTime.UtcNow)
        //DateTime Fecha_Actual = DateTime.Parse((DateTime.UtcNow.ToShortDateString()).ToString());




        private void Ver_ventas_usuario()
        {

            using (BPBEntities1 db = new BPBEntities1())
            {
                //realizamos la consulta aplicando filtros y ordenamientos
                //y convertimos a lista, esto ultimo es Importante
                cmbNombresUsuarios.DataSource = db.Usuario.Where(d => d.IdUsuario > -1 ).OrderBy(d => d.PrimerNombre).ToList();

                //campo que vera el usuario
                cmbNombresUsuarios.DisplayMember = "IdUsuario";

                //campo que es el valor real
                cmbNombresUsuarios.ValueMember = "IdUsuario";
                
            }
            //------------------------------------------
            //cmbNombresUsuarios.Items.Clear();
        }
        
        private void Mostrar_datos()    
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
            //MessageBox.Show(FECHACALCULADA);
            DateTime Fecha_Actual = DateTime.Parse(FECHACALCULADA);

            //Formato
            //DateTime Fecha_Actual = DateTime.Parse("2024-05-20 00:00:00");
            
            //MessageBox.Show((cmbNombresUsuarios.ValueMember).ToString());

            try
            {
            //    int vMember = Convert.ToInt32(Punto_de_venta.Clases.Usuario.ID);
            //    if (cmbNombresUsuarios.Text == string.Empty)
            //    {
            //        vMember = Convert.ToInt32(Punto_de_venta.Clases.Usuario.ID);
            //    }
            //    else
            //    {
            //        vMember = Convert.ToInt32(cmbNombresUsuarios.Text);
            //    }

            //    //cmbNombresUsuarios.Text = Punto_de_venta.Clases.Usuario.ID;

                var tdetalles = from p in entity.Venta
                                where (p.Estado == 1) && (p.Fecha_Venta >= Fecha_Actual) //&& (p.IdUsuario == vMember)

                                //p.Fecha_Venta >= Fecha_Actual
                                orderby p.Fecha_Venta
                                select new
                                {
                                    p.IdVenta,
                                    p.Estado,
                                    p.Total_Venta,
                                    p.ISV15_,
                                    p.ISV18_,
                                }
                             ;

                this.mifiltro = (tdetalles.CopyAnonymusToDataTable()).DefaultView;
                this.dgDetalle_Transaccion.DataSource = mifiltro;


            }
            catch (Exception)
            {

            }

            
          
            try
            {
                cargarGraficoVentasPorSemana();
                cargarGrafico();
            }
            catch (Exception)
            {

                return;
            }
            
        }
        private void Mostrar_datos_Factura()
        {
            int NumeroFactura = Convert.ToInt32(lblFactura.Text);
            var tFactura = from p in entity.VistaVentasPorMes
                           //where p. == NumeroFactura
                           select new
                           {
                               //p.id,
                               //p.Producto,
                               //p.Cantidad,
                           };
            ctMeses.DataSource = tFactura.CopyAnonymusToDataTable();
        }

        private void cargarGrafico()
        {
            var tMeses = from p in entity.VistaVentasPorMes
                         select new
                         {
                             p.Enero,
                             p.Febrero,
                             p.Marzo,
                             p.Abril,
                             p.Mayo,
                             p.Junio,
                             p.Julio,
                             p.Agosto,
                             p.Septiembre,
                             p.Octubre,
                             p.Noviembre,
                             p.Diciembre

                         };
            var tMeses1 = from p in entity.Producto
                          select new
                          {
                              p.IdProducto,


                          };
            double Enero = Convert.ToDouble(tMeses.FirstOrDefault().Enero);
            double Febrero = Convert.ToDouble(tMeses.FirstOrDefault().Febrero);
            double Marzo = Convert.ToDouble(tMeses.FirstOrDefault().Marzo);
            double Abril = Convert.ToDouble(tMeses.FirstOrDefault().Abril);
            double Mayo = Convert.ToDouble(tMeses.FirstOrDefault().Mayo);
            double Junio = Convert.ToDouble(tMeses.FirstOrDefault().Junio);
            double Julio = Convert.ToDouble(tMeses.FirstOrDefault().Julio);
            double Agosto = Convert.ToDouble(tMeses.FirstOrDefault().Agosto);
            double Septiembre = Convert.ToDouble(tMeses.FirstOrDefault().Septiembre);
            double Octubre = Convert.ToDouble(tMeses.FirstOrDefault().Octubre);
            double Noviembre = Convert.ToDouble(tMeses.FirstOrDefault().Noviembre);
            double Diciembre = Convert.ToDouble(tMeses.FirstOrDefault().Diciembre);
            double[] puntos = { Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre };

            string[] series = { "Enero", "febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };

            //ctMeses.Titles.Add("Ventas Por mes en este año");
            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = ctMeses.Series.Add(series[i]);

                // cantidades 
                //serie.Label = "L "+ puntos[i].ToString();
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private void cargarGraficoVentasPorSemana()
        {
            var tMeses = from p in entity.VistaVentasPorDiaDeSemana
                         
                         select new
                         
                         {
                             p.Domingo,
                             p.Lunes,
                             p.Martes,
                             p.Miércoles,
                             p.Jueves,
                             p.Viernes,
                             p.Sábado

                         };
            var tMeses1 = from p in entity.Producto
                          select new
                          {
                              p.IdProducto,
                          };
            double Domingo = Convert.ToDouble(tMeses.FirstOrDefault().Domingo);
            double Lunes = Convert.ToDouble(tMeses.FirstOrDefault().Lunes);
            double Martes = Convert.ToDouble(tMeses.FirstOrDefault().Martes);
            double Miércoles = Convert.ToDouble(tMeses.FirstOrDefault().Miércoles);
            double Jueves = Convert.ToDouble(tMeses.FirstOrDefault().Jueves);
            double Viernes = Convert.ToDouble(tMeses.FirstOrDefault().Viernes);
            double sábado = Convert.ToDouble(tMeses.FirstOrDefault().Sábado);
           
            double[] puntos = { Domingo, Lunes, Martes, Miércoles, Jueves, Viernes, sábado};

            string[] series = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };

            
            for (int i = 0; i < series.Length; i++)
            {
               
                Series serie = ctSemana.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }
        private void Limpiar()
        {
            txtSobrante.Text = txtFaltante.Text = "0";
            //txtBuscar.Text = txtMontoInicial.Text =txtVentas.Text = txtGastos.Text = txtSobrante.Text = txtFaltante.Text = string.Empty;
            //txtVentasEnSistema.Text = txtConteodeCaja.Text = txtISV15.Text= txtISV18.Text =txtTotal.Text= string.Empty;
            txtBuscar.Focus();
            //HacerCuentas();
        }
        private void LimpiarTodo()
        {
            
            txtMontoInicial.Text = 
            txtConteodeCaja.Text = txtVentasEnSistema.Text
             = txtSobrante.Text = 
            txtFaltante.Text = txtBuscar.Text = string.Empty;
            txtVentasEnSistema.Text = "0";
            txtMontoInicial.Text = "0";
           
            lblFactura.Text = "00000";
            //agregado
            txtBuscar.Focus();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Calcular_Cierre();
            //AgregarProducto();
            
        }

       

       
        private void HacerCuentas()
        {
            double subtot = 0;
            double isv15 = 0;
            double isv18 = 0;
            double exento = 0;
            double iG15 = 0;
            double iG18 = 0;
            double exonerado = txtVentasEnSistema.Text == string.Empty ? 0 : Convert.ToDouble(txtVentasEnSistema.Text);

          
           

            try
            {
                
                txtFaltante.Text = subtot.ToString("N2");
               
                txtSobrante.Text = iG18.ToString("N2");
                txtConteodeCaja.Text = exento.ToString("N2");
               // txtTotal.Text = (iG15 + iG18 + exento + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                //if ((descuento + exonerado) < subtot)
                //{
                //    //txtTotal.Text = (iG15 + iG18 + exento + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                //    //txtTotal.Text = (subtot + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                //}
                //else
                //{
                //    MessageBox.Show("Error en descuentos y exonerados",
                //    "No puede dar más descuentos de lo que suman los productos,¡Revise!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar factura",
                "Contacte con el administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }

        private void Calcular_Cierre()
        {

            double ISV15 = 0;
            double ISV18 = 0;
            double Sobrante = 0;
            double Faltante = 0;
            if (txtConteodeCaja.Text == string.Empty){txtConteodeCaja.Text = "0";}
            if (txtMontoInicial.Text == string.Empty) { txtMontoInicial.Text = "0"; }
            double ConteodeCaja = Convert.ToDouble(txtConteodeCaja.Text);
            double Venta = 0;
            double Montoinicial = Convert.ToDouble(txtMontoInicial.Text);
            try
            {
                foreach (DataGridViewRow dr in dgDetalle_Transaccion.Rows)
                {
                    double ventaRealizada = Convert.ToDouble((dr.Cells[2].Value).ToString());
                    double isv15PorVentaRealizada= Convert.ToDouble((dr.Cells[3].Value).ToString());
                    double isv18PorVentaRealizada = Convert.ToDouble((dr.Cells[4].Value).ToString());
                    Venta += Convert.ToDouble(ventaRealizada);
                    ISV15 += Convert.ToDouble(isv15PorVentaRealizada);
                    ISV18 += Convert.ToDouble(isv18PorVentaRealizada);
                    
                }
                txtVentasEnSistema.Text = Venta.ToString();
                
                double MontoSistemaSumado = (Venta+Montoinicial) - ConteodeCaja;
                

                //MessageBox.Show(MontoSistemaSumado.ToString());
                if (MontoSistemaSumado < 0)
                {
                    txtSobrante.Text = (MontoSistemaSumado * -1 ).ToString();
                    txtFaltante.Text = "0";
                }
                if (MontoSistemaSumado > 0)
                {
                    txtFaltante.Text = (MontoSistemaSumado ).ToString();
                    txtSobrante.Text = "0";
                }
                if (MontoSistemaSumado == 0)
                {
                    txtFaltante.Text = txtSobrante.Text = "0";
                }
                Sobrante =Convert.ToDouble(txtSobrante.Text);
                Faltante = Convert.ToDouble(txtFaltante.Text);
                

                if (Faltante > 0)
                {
                   
                }
                //txtTotal.Text = (Venta + Montoinicial + Sobrante - Faltante - Gastos).ToString();
               
            }
            catch(Exception)
            { 
            }






                    //foreach (DataGridViewRow dr in dgDetalle_Transaccion.Rows)
                    //{
                    //    Punto_de_venta.Bases_de_datos.Venta tabla = new Punto_de_venta.Bases_de_datos.Venta();
                    //    double fkid = Convert.ToDouble(dr.Cells[0].Value) ;
                    //    //var Product = entity.Producto.FirstOrDefault(x => x.IdProducto == fkid);
                    //    tabla.Producto = (dr.Cells[0].Value).ToString();
                    //    tabla.Cantidad = Convert.ToInt32(dr.Cells[3].Value);
                    //    tabla.Venta = Convert.ToInt32(lblFactura.Text);

                    //    entity.DetalleVentas.Add(tabla);
                    //    entity.SaveChanges();

                    //}

                }
                private void Hacer_Cierre()
        {

        }

        
        
        private void AgregarVenta()
        {
            Punto_de_venta.Bases_de_datos.Venta tabla = new Punto_de_venta.Bases_de_datos.Venta();
            tabla.Importe_Exento = Convert.ToDecimal(txtConteodeCaja.Text);
            tabla.Importe_Exonerado = Convert.ToDecimal(txtVentasEnSistema.Text);
            
            tabla.Impuesto_Gravado_18_ = Convert.ToDecimal(txtSobrante.Text);
           
            tabla.Fecha_Venta = DateTime.Now;
            tabla.Estado = 1;
            entity.Venta.Add(tabla);
            entity.SaveChanges();
            lblFactura.Text = tabla.IdVenta.ToString();
        }
        
       
        

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            
            HacerCuentas();
            Limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //HacerCuentas();
            imprimirFactura();
        }

        private void Formulario_Ventas_KeyDown(object sender, KeyEventArgs e)
        {

            //accesos rápidos
            if (e.Control == true && e.KeyCode == Keys.Add)
            {
                btnAgregar.PerformClick(); //control + + agregar
            }
            if (e.Control == true && e.KeyCode == Keys.Subtract)
            {
                btnQuitar.PerformClick(); //Control + - quitar uno
            }
            if (e.Control == true && e.KeyCode == Keys.P)
            {
                btnImprimir.PerformClick(); //control + p Imprimir
            }
            if (e.Control == true && e.KeyCode == Keys.G)
            {
                btnSoloGuardar1.PerformClick(); //control + G Guardar
            }
            if (e.Control == true && e.KeyCode == Keys.N)
            {
                BtnNuevaFactura1.PerformClick(); //control + N Nuevo
            }
            if (e.Control == true && e.KeyCode == Keys.Delete)
            {
                btnQuitarTodo.PerformClick(); //control + del Quitar todo
            }
            if (e.Control == true && e.KeyCode == Keys.Space)
            {
                txtBuscar.Focus(); //control + espacio Buscar producto
            }
            if (e.Control == true && e.KeyCode == Keys.C)
            {
              //  txtCantidad.Focus(); //control + C Elegir cantidad
            }
        }
        /// <summary>
        /// Impresión de Factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void txtDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
            //HacerCuentas();
        }

        private void BtnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnQuitarTodo_Click(object sender, EventArgs e)
        {
        }

        private void btnSoloGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            
        }

        private void txtImporteExonerado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Por favor ingresa solo numeros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
            HacerCuentas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Punto_de_venta.Ventas.Formulario_Cancelar_Factura frm = new Punto_de_venta.Ventas.Formulario_Cancelar_Factura();
            frm.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar_datos();
            Buscar();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {

            //string salida_datos = "";
            //string[] palabras_busqueda = this.txtBuscar.Text.Split(' ');
            //foreach (string palabra in palabras_busqueda)
            //{
            //    if (salida_datos.Length == 0)
            //    {
            //        salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra +
            //            "%' OR Categoria LIKE '%" + palabra + "%' OR Proveedor LIKE '%" + palabra + "%' )";
            //    }
            //    else
            //    {
            //        salida_datos += "AND(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra +
            //            "%' OR Categoria LIKE '%" + palabra + "%' OR Proveedor LIKE '%" + palabra + "%' )";
            //    }
            //}
            //this.mifiltro.RowFilter = salida_datos;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //getImpresoraPorDefecto();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dgDetalle_Transaccion.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el producto que está buscando");
                }
                else
                {
                    //if (txtCantidad.Text == string.Empty || Convert.ToInt32(txtCantidad.Text) < 1)
                    //{
                    //    txtCantidad.Text = "1";
                    //}
                    
                    /*Limpiar();*/
                    /*Seleccionar todo el texto del textbox*/
                    if (!String.IsNullOrEmpty(txtBuscar.Text))
                    {
                        txtBuscar.SelectionStart = 0;
                        txtBuscar.SelectionLength = txtBuscar.Text.Length;
                    }
                }
            }
        }

        private void dgFactura_KeyUp(object sender, KeyEventArgs e)
        {
            //HacerCuentas();
        }

        private void txtDescuentos_KeyUp(object sender, KeyEventArgs e)
        {
            //HacerCuentas();
        }

        private void rbtn3_CheckedChanged(object sender, EventArgs e)
        {
            //double descuento = 0.00;

            //if (rbtn3.Checked)
            //{
            //    descuento = (Convert.ToDouble(txtTotal.Text) * 0.03);
            //    rbtn10.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtnninguno.Checked = false;
            //}

            //txtDescuentos.Text = descuento.ToString();
            //txtDescuentos.ReadOnly = true;
            HacerCuentas();
        }

        private void rbtn5_CheckedChanged(object sender, EventArgs e)
        {
            //double descuento = 0.00;

            //if (rbtn5.Checked)
            //{
            //    descuento = (Convert.ToDouble(txtTotal.Text) * 0.05);
            //    rbtn10.Checked = false;
            //    rbtn3.Checked = false;
            //    rbtnninguno.Checked = false;

            //}

            //txtDescuentos.Text = descuento.ToString();
            //txtDescuentos.ReadOnly = true;
            HacerCuentas();
        }

        private void rbtn10_CheckedChanged(object sender, EventArgs e)
        {
            //double descuento = 0.00;

            //if (rbtn10.Checked)
            //{
            //    descuento = (Convert.ToDouble(txtTotal.Text) * 0.10);
            //    rbtn3.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtnninguno.Checked = false;

            //}

            //txtDescuentos.Text = descuento.ToString();
            //txtDescuentos.ReadOnly = true;
            HacerCuentas();
        }

       
        
        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            //HacerCuentas();
        }

        private void dgFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMontoInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45) || (e.KeyChar == 47))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtConteodeCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45) || (e.KeyChar == 47))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void cmbNombresUsuarios_SelectedIndexChanged(object sender, EventArgs e)
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
            //MessageBox.Show(FECHACALCULADA);
            DateTime Fecha_Actual = DateTime.Parse(FECHACALCULADA);
            try
            {
                int vMember = Convert.ToInt32(Punto_de_venta.Clases.Usuario.ID);
                if (cmbNombresUsuarios.Text == string.Empty)
                {
                    vMember = Convert.ToInt32(Punto_de_venta.Clases.Usuario.ID);
                }
                else
                {
                    vMember = Convert.ToInt32(cmbNombresUsuarios.Text);
                }

                //cmbNombresUsuarios.Text = Punto_de_venta.Clases.Usuario.ID;

                var tdetalles = from p in entity.Venta
                                where (p.Estado == 1) && (p.Fecha_Venta >= Fecha_Actual) && (p.IdUsuario == vMember)

                                //p.Fecha_Venta >= Fecha_Actual
                                orderby p.Fecha_Venta
                                select new
                                {
                                    p.IdVenta,
                                    p.Estado,
                                    p.Total_Venta,
                                    p.ISV15_,
                                    p.ISV18_,
                                }
                             ;

                this.mifiltro = (tdetalles.CopyAnonymusToDataTable()).DefaultView;
                this.dgDetalle_Transaccion.DataSource = mifiltro;


            }
            catch (Exception)
            {

            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;
            Font font = new Font("Arial", 12);
            int ancho = 278;
            int y = 0;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            StringFormat stringFormatrigth = new StringFormat();
            stringFormatrigth.Alignment = StringAlignment.Far;
            stringFormatrigth.LineAlignment = StringAlignment.Far;

            StringFormat stringFormatLeft = new StringFormat();
            stringFormatLeft.Alignment = StringAlignment.Near;
            stringFormatLeft.LineAlignment = StringAlignment.Near;
            //selector de ancho y alto manual de la pagina a imprimir
            SizeF sizeF = new SizeF();
            sizeF.Width = e.MarginBounds.Width; //ancho de la pagina (automatico)
            sizeF.Height = e.MarginBounds.Height - 269; // Largo de la pagina (automatico) ; tambien se pueden colocar manualmente
            e.Graphics.MeasureString(stringToPrint, this.Font,
            sizeF, StringFormat.GenericTypographic,
            out charactersOnPage, out linesPerPage);


            //----------------------- Logo de la empresa ----------------------------------------------------------
            Bitmap myPng = Properties.Resources.puleria_isis;
            //----------------------------------------- x,y,ancho y alto
            e.Graphics.DrawImage(myPng, new RectangleF(100, y += 10, 100, 100));

            ////----------------------------------------- x,y,ancho y alto
            Bitmap myPng2 = Properties.Resources.PROFORMASOLA;
            e.Graphics.DrawImage(myPng2, new RectangleF(70, y += 120, 150, 17));


            e.Graphics.DrawString(stringToPrint, font, Brushes.Black, new RectangleF(5, y += 30, ancho, e.MarginBounds.Height), StringFormat.GenericTypographic);
            //-------------------------- Pie de cotización --------------------------------------------------------
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);
            
        }
        private void imprimirFactura()
        {
            string total = "";
            
            StreamWriter sw = new StreamWriter("C:\\testPage.txt");
            //----Encabezado----
            sw.WriteLine(" ");
            sw.WriteLine("                 CIERRE DIARIO");
            sw.WriteLine(" ");
            sw.WriteLine("  FECHA Y HORA DE CIERRE:");
            sw.WriteLine(" ");
            sw.WriteLine("             " + DateTime.Now.ToString());
            
            sw.WriteLine(" ");
            sw.WriteLine(" SUELTO INICIAL:");
            sw.WriteLine("L. "+txtMontoInicial.Text);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine(" SUS VENTAS EL DÍA DE HOY:");
            sw.WriteLine("L. "+txtVentasEnSistema.Text );
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine(" SU CONTEO DE CAJA:");
            sw.WriteLine("L. "+txtConteodeCaja.Text);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            if (Convert.ToDouble(txtFaltante.Text) > 0 )
            {
                sw.WriteLine(" FALTANTE:");
                sw.WriteLine("L. "+txtFaltante.Text);
            }
            else
            {
                sw.WriteLine(" SOBRANTE:");
                sw.WriteLine("L. "+txtSobrante.Text);
            }
            sw.WriteLine(" ");
            sw.WriteLine("* FINAL DE CIERRE DE CAJA *");

            sw.Close();
            string docName = "testPage.txt";
            string docPath = @"C:\";
            string fullPath = System.IO.Path.Combine(docPath, docName);
            printDocument1.DocumentName = docName;
            stringToPrint = System.IO.File.ReadAllText(fullPath);
            printDocument1.Print();


        }

    }
}