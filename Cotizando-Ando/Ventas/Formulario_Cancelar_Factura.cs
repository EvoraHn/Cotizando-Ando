using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Ventas
{
    public partial class Formulario_Cancelar_Factura : Form
    {
        //Conexión a la base de datos
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Bases_de_datos.BPBEntities1();
        //filtro para el botón buscar
        DataView mifiltro;
        DataView mifiltro2;
        int id = 0;
        string producto = "";
        decimal precio_Temporal_Venta = 0;
        
        public Formulario_Cancelar_Factura()
        {
            InitializeComponent();
        }
        private void Formulario_Cancelar_Factura_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            Mostrar_datos();
            //Mostrar_detalles();
            var Habilitado = new[] {"Activo",
                        "Inactivo"};

            txtEstado.DataSource = Habilitado;
        }
        private void Mostrar_datos()
        {
            var tFacturas = from p in entity.Venta
                             //where p.Estado == 1
                             orderby p.Fecha_Venta descending
                             select new
                             {
                                 p.IdVenta,
                                 p.Fecha_Venta,
                                 p.Total_Venta,
                                 p.Estado
                             };

            this.mifiltro = (tFacturas.CopyAnonymusToDataTable()).DefaultView;
            this.dgFactura.DataSource = mifiltro;

        }
        private void Mostrar_detalles()
        {
            int detalle = Convert.ToInt32(txtId.Text);
            var tDetalle = from det in entity.DetalleVentas
                           join prod in entity.Producto
                           on det.Producto equals prod.IdProducto

                            where det.Venta == detalle 
                           
                            select new
                            {
                                det.Producto,
                                det.Venta,
                                det.Cantidad,
                                prod.Nombre,
                                det.Precio_Reflejado,
                                det.id
                            };

            this.mifiltro2 = (tDetalle.CopyAnonymusToDataTable()).DefaultView;
            this.dgDetalles.DataSource = mifiltro2;
            
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(IdVenta LIKE '%" + palabra + "%' OR Total_Venta LIKE '%" + palabra + "%' OR Fecha_Venta LIKE '%" + palabra + "%' )";
                }
                else
                {
                    salida_datos = "(IdVenta LIKE '%" + palabra + "%' OR Total_Venta LIKE '%" + palabra + "%' OR Fecha_Venta LIKE '%" + palabra + "%' )";
                }
            }
            this.mifiltro.RowFilter = salida_datos;

        }

        private void dgFactura_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgFactura.RowCount > 0)
            {
                try
                {
                    
                    id = Convert.ToInt32(dgFactura.SelectedCells[0].Value);
                    var tabla = entity.Venta.FirstOrDefault(x => x.IdVenta == id);
                    if (tabla.Estado == 1)
                    {
                        txtEstado.Text = "Activo";
                    }
                    else
                    {
                        txtEstado.Text = "Inactivo";
                    }
                    txtId.Text = tabla.IdVenta.ToString();
                }
                catch (Exception)
                { }
                Mostrar_detalles();
            }

        }


        private void btnCambiar_Click(object sender, EventArgs e)
        {
            try
            {
                var tablaP = entity.Venta.FirstOrDefault(x => x.IdVenta == id);

                if (txtEstado.Text == "Activo")
                {
                    MessageBox.Show(txtEstado.Text.ToString());
                    tablaP.Estado = 1;
                }
                else
                {
                    MessageBox.Show(txtEstado.Text.ToString());
                    Mostrar_detalles();
                    tablaP.Estado = 2;
                    entity.SaveChanges();
                    Thread.Sleep(100);
                    regresarProducto();
                    Thread.Sleep(100);
                    Mostrar_datos();
                    Limpiar();
                    MessageBox.Show("¡Factura inhabilitada correctamente!");
                }






                    //if (txtEstado.Text.Equals("") | txtId.Text.Equals(""))
                    //{
                    //    MessageBox.Show("Por favor ingresar todos los datos en el formulario");
                    //    return;
                    //}
                    //else
                    //{
                    //    var tablaP = entity.Venta.FirstOrDefault(x => x.IdVenta == id);
                    //    if (txtEstado.Text == "Activo")
                    //    {
                    //        tablaP.Estado = 1;
                    //    }
                    //    else
                    //    {
                    //        Mostrar_detalles();
                    //        tablaP.Estado = 2;
                    //        entity.SaveChanges();
                    //        Thread.Sleep(100);
                    //        regresarProducto();
                    //        Thread.Sleep(100);
                    //        Mostrar_datos();
                    //        Limpiar();
                    //        MessageBox.Show("¡Factura inhabilitada correctamente!");

                    //    }
                    //    Mostrar_datos();
                    //}
                }
            catch (Exception) { }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Mostrar_detalles();
        }
        private void regresarProducto()
        {
            foreach (DataGridViewRow dr in dgDetalles.Rows)
            {
                Punto_de_venta.Bases_de_datos.Producto tabla = new Punto_de_venta.Bases_de_datos.Producto();
                producto = (dr.Cells[0].Value).ToString();
                var tablaP = entity.Producto.FirstOrDefault(x => x.IdProducto == producto);
                double n = Convert.ToDouble(dr.Cells[2].Value);
                int numeroEntero = Convert.ToInt32(Math.Truncate(n));
                tablaP.Cantidad += numeroEntero ;
                entity.SaveChanges();
            }
        }
        private void Limpiar ()
        {
            txtBuscar.Text = string.Empty;
            Mostrar_detalles();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EditarDetalleDeVenta();
            //foreach (DataGridViewRow dr in dgDetalles.Rows)
            //{
            //    Punto_de_venta.Bases_de_datos.Producto tabla = new Punto_de_venta.Bases_de_datos.Producto();
            //    producto = (dr.Cells[0].Value).ToString();
            //    var tablaP = entity.Producto.FirstOrDefault(x => x.IdProducto == producto);
            //    double n = Convert.ToDouble(dr.Cells[2].Value);
            //    int numeroEntero = Convert.ToInt32(Math.Truncate(n));
            //    tablaP.Cantidad += numeroEntero;
            //    entity.SaveChanges();
            //}
        }

        private void dgDetalles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgDetalles.RowCount > 0)
            {
                try
                {  
                    txtCantidadProducto.Text = Convert.ToString(dgDetalles.SelectedCells[2].Value);
                }
                catch (Exception)
                { }
            }
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 45) || (e.KeyChar == 47))
            {
                MessageBox.Show("Por favor ingresa solo numeros enteros positivos en este campo",
                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        // ojo
        private void Devolver_a_Inventario()
        {
            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                Punto_de_venta.Bases_de_datos.Producto tabla = new Punto_de_venta.Bases_de_datos.Producto();
                string id = (dr.Cells[0].Value).ToString();
                var tablaP = entity.Producto.FirstOrDefault(x => x.IdProducto == id);
                tablaP.Cantidad = tablaP.Cantidad + Convert.ToDecimal(dr.Cells[3].Value);
                entity.SaveChanges();


            }
        }
        private void Editar_Venta()
        {
            
            int fkid = Convert.ToInt32(txtId.Text);
            var tabla = entity.Venta.FirstOrDefault(x => x.IdVenta == fkid);
            //tabla.Importe_Exento = Convert.ToDecimal(txtImporteExento.Text);
            //tabla.Importe_Exonerado = Convert.ToDecimal(txtImporteExonerado.Text);
            //tabla.Impuesto_Gravado_15_ = Convert.ToDecimal(txtIG15.Text);
            //tabla.Impuesto_Gravado_18_ = Convert.ToDecimal(txtIG18.Text);
            //tabla.Impuesto_Gravado_15_ = Convert.ToDecimal(txtIG15.Text);
            //tabla.ISV15_ = Convert.ToDecimal(txtISV15.Text);
            //tabla.ISV18_ = Convert.ToDecimal(txtISV18.Text);
            tabla.Total_Venta = Convert.ToDecimal(tabla.Total_Venta - precio_Temporal_Venta );
            //tabla.Fecha_Venta = DateTime.Now;
            //tabla.Estado = 1;
            //tabla.IdUsuario = Convert.ToInt16(Punto_de_venta.Clases.Usuario.ID);
            
            entity.SaveChanges();
            Mostrar_datos();
            Mostrar_detalles();
            Limpiar();
           
        }
        private void EditarDetalleDeVenta()
        {      
                int fkid = Convert.ToInt32(dgDetalles.SelectedCells[5].Value);
                var Product = entity.DetalleVentas.FirstOrDefault( x => x.id == fkid);      
                decimal Cantidad = ((Convert.ToDecimal(dgDetalles.SelectedCells[2].Value) )- (Convert.ToDecimal(txtCantidadProducto.Text)));
                precio_Temporal_Venta = Convert.ToDecimal(txtCantidadProducto.Text) * (Product.Precio_Reflejado.Value);
                if (Cantidad<=0)
                {
                    try
                    {
                        entity.DetalleVentas.Remove(Product);
                        entity.SaveChanges();
                        MessageBox.Show("¡Registro eliminado correctamente!");
                        Limpiar();
                        Mostrar_datos();
                        Mostrar_detalles();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("¡No puedes eliminar un producto si ya está en facturas!"); return;
                    }
                }
                else
                {
                Product.Cantidad = Cantidad;
                entity.SaveChanges();
                MessageBox.Show("¡Registro modificado correctamente!");
                Mostrar_detalles();
                Editar_Venta();
                Limpiar();
                Mostrar_datos();
                
                
            }
        }
    }
}
