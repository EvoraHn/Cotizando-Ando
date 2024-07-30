using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using CrystalDecisions.Shared;
//using Aspose.Pdf.Facades;

namespace Punto_de_venta.Ventas
{
    public partial class Formulario_Ventas : Form
    {
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
        public Formulario_Ventas()
        {
            InitializeComponent();
        }

        private void dgProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProductos.RowCount > 0)
            {
                try
                {
                    id = Convert.ToString(dgProductos.SelectedCells[0].Value);
                    var tabla = entity.Producto.FirstOrDefault(x => x.IdProducto == id);
                    txtId.Text = tabla.IdProducto;
                    txtProducto.Text = tabla.Nombre;
                }
                catch (Exception)
                { }
            }
        }
        private void dgFactura_SelectionChanged(object sender, EventArgs e)
        {
            if (dgFactura.RowCount > 0)
            {
                try
                {
                    idDetalle = Convert.ToInt32(dgFactura.SelectedCells[0].Value);
                    var tabla = entity.DetalleVentas.FirstOrDefault(x => x.id == Convert.ToInt32(idDetalle));   
                }
                catch (Exception)
                { }
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Buscar();
        }
        private void Mostrar_datos()
        {
            var tProductos = from p in entity.Vista1
                             orderby p.Producto
                             select new
                             {
                                 p.Codigo,
                                 p.Categoria,
                                 p.Proveedor,
                                 p.Producto,
                                 p.Precio,
                                 /* p.Costo,*/
                             };
            this.mifiltro = (tProductos.CopyAnonymusToDataTable()).DefaultView;
            this.dgProductos.DataSource = mifiltro;

        }
        private void Mostrar_datos_Factura()
        {
            int NumeroFactura = Convert.ToInt32(lblFactura.Text);
            var tFactura = from p in entity.DetalleVentas
                                where p.Venta == NumeroFactura
                           select new
                                {
                                    p.id,
                                    p.Producto,
                                    p.Cantidad,
                                };
            dgFactura.DataSource = tFactura.CopyAnonymusToDataTable();
        }
        private void Limpiar()
        {
            txtBuscar.Text = txtId.Text = txtProducto.Text =  string.Empty;
            txtCantidad.Text = "1" ;
            txtBuscar.Focus();
            //agregado
            HacerCuentas();
        }
        private void LimpiarTodo()
        {
            rbtnninguno.Checked = true;
            txtId.Text = txtCliente.Text = txtRTN.Text = 
            txtDescuentos.Text = txtImporteExento.Text = txtImporteExonerado.Text
            =txtISV15.Text =txtISV18.Text = txtIG18.Text = txtIG15.Text = txtTotal.Text =
            txtSubtotal.Text=txtBuscar.Text= string.Empty;
            txtDescuentos.Text = "0";
            txtImporteExonerado.Text = "0";
            dgFactura.Rows.Clear();
            dgFactura.RowCount = 0;
            txtCantidad.Text = "1";
            lblFactura.Text = "00000";
            //agregado
            txtBuscar.Focus();
            
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == string.Empty || Convert.ToInt32(txtCantidad.Text) < 1)
            {
                txtCantidad.Text = "1";
            }
            AgregarProducto();
            Limpiar();
        }

        private void AgregarProducto()
        {
            int indice = dgProductos.CurrentCell.RowIndex;
            int indiceF = dgFactura.RowCount == 0 ? 0 : dgFactura.CurrentCell.RowIndex;

            string codigo = dgProductos.Rows[indice].Cells[0].Value.ToString();
            string producto = dgProductos.Rows[indice].Cells[3].Value.ToString();
            string precio = dgProductos.Rows[indice].Cells[4].Value.ToString();
            string cantidad = dgFactura.RowCount == 0 ? txtCantidad.Text : dgFactura.Rows[indiceF].Cells[3].Value.ToString();
            //string PrecioXCantidad = (Convert.ToDouble(precio) * Convert.ToDouble(cantidad)).ToString();
            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                string id = (dr.Cells[1].Value).ToString();
            
                if (id == producto)
                {
                   
                    int quantity = Convert.ToInt32(dr.Cells[3].Value);
                    cantidad = (Convert.ToInt32(txtCantidad.Text) + quantity).ToString();
                    dgFactura.Rows.RemoveAt(dr.Index);
                    //PrecioXCantidad = (Convert.ToDouble(precio) * Convert.ToDouble(cantidad)).ToString();
                    break;
                }
                else
                {
                    cantidad = txtCantidad.Text;
                }
               
            }
            dgFactura.Rows.Add(codigo, producto, precio, cantidad);
            HacerCuentas();
        }

        private void QuitarProducto()
        {
            try
            {
                if (dgFactura.SelectedRows.Count > 0)
                {
                    int indice = dgFactura.CurrentCell.RowIndex;
                    int indiceF = dgFactura.RowCount == 0 ? 0 : dgFactura.CurrentCell.RowIndex;
                    int cantidadf = dgFactura.RowCount == 0 ? 0 : Convert.ToInt32(dgFactura.Rows[indice].Cells[3].Value);
                    
                    if (cantidadf <= 1)
                    {
                        dgFactura.Rows.RemoveAt(indice);
                    }
                    else
                    {
                        string codigo = dgFactura.Rows[indice].Cells[0].Value.ToString();
                        string producto = dgFactura.Rows[indice].Cells[1].Value.ToString();
                        string precio = dgFactura.Rows[indice].Cells[2].Value.ToString();
                        string cantidad = dgFactura.RowCount == 0 ? "0" : dgFactura.Rows[indiceF].Cells[3].Value.ToString();

                        //HacerCuentas();
                        foreach (DataGridViewRow dr in dgFactura.Rows)
                        {
                            string id = (dr.Cells[1].Value).ToString();

                            if (id == producto)
                            {

                                int quantity = 1;
                                cantidad = (Convert.ToInt32(cantidad) - quantity).ToString();
                                dgFactura.Rows.RemoveAt(dr.Index);
                                break;
                            }
                            else
                            {
                                //cantidad = txtCantidad.Text;
                            }

                        }
                        dgFactura.Rows.Add(codigo, producto, precio, cantidad);
                        HacerCuentas();
                        dgFactura.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }

        private void HacerCuentas()
        {
            double subtot = 0;
            double isv15 = 0;
            double isv18 = 0;
            double exento = 0;
            double iG15 = 0;
            double iG18 = 0;
            //double descuento = 0.00;
            double descuento = txtDescuentos.Text == string.Empty ? 0 : Convert.ToDouble(txtDescuentos.Text);

            double exonerado = txtImporteExonerado.Text == string.Empty ? 0 : Convert.ToDouble(txtImporteExonerado.Text);

            verificar_checkbox_descuentos();
            //if (rbtn3.Checked) { descuento = (Convert.ToDouble(txtTotal.Text) * 0.03);
            //    rbtn10.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtnninguno.Checked = false;
            //    txtDescuentos.Text = descuento.ToString();
            //}
            //if (rbtn5.Checked) { descuento = (Convert.ToDouble(txtTotal.Text) * 0.05);
            //    rbtn10.Checked = false;
            //    rbtn3.Checked = false;
            //    rbtnninguno.Checked = false;
            //    txtDescuentos.Text = descuento.ToString();
            //}
            //if (rbtn10.Checked) { descuento = (Convert.ToDouble(txtTotal.Text) * 0.10);
            //    rbtn3.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtnninguno.Checked = false;
            //    txtDescuentos.Text = descuento.ToString();
            //}
            //if (rbtnninguno.Checked)
            //{
            //    descuento = 0.00;
            //    rbtn3.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtn10.Checked = false;
            //    txtDescuentos.Text = descuento.ToString();
            //}

            //txtDescuentos.Text = descuento.ToString();

            try
            {
                foreach (DataGridViewRow dr in dgFactura.Rows)
                {
                    double cantidad = Convert.ToDouble((dr.Cells[3].Value).ToString());
                    string fkid = (dr.Cells[0].Value).ToString(); ;
                    //var pel = entity.Producto.FirstOrDefault(x => x.IdProducto == fkid);
                    var pel = entity.Producto.FirstOrDefault(x => x.IdProducto == fkid);
                    subtot += Convert.ToDouble(pel.PrecioVenta) * cantidad;
                    //subtot += Convert.ToDouble((dr.Cells[2].Value).ToString()) * cantidad;


                    if (pel.Tipo_Impuesto != null)
                    {
                        //isv15 += pel.Tipo_Impuesto.Equals(null) ? 0 : pel.Tipo_Impuesto.Equals("15%") ? (pel.PrecioVenta * cantidad) * (Convert.ToDecimal(pel.Tipo_Impuesto.Substring(0, 2)) / 100)
                        //: 0;
                        //isv15 += pel.Tipo_Impuesto.Equals(null) ? 0 : pel.Tipo_Impuesto.Equals("15%") ? (Convert.ToDouble(pel.PrecioVenta) / 1.15) * cantidad
                        //: 0;
                        isv15 += pel.Tipo_Impuesto.Equals(null) ? 0 : pel.Tipo_Impuesto.Equals("15%") ? (Convert.ToDouble(pel.PrecioVenta ) * cantidad - ((Convert.ToDouble(pel.PrecioVenta) / 1.15) * cantidad))
                        : 0;
                        iG15 += pel.Tipo_Impuesto.Equals("15%") ? ((Convert.ToDouble(pel.PrecioVenta) / 1.15) * cantidad)
                            : 0;

                        isv18 += pel.Tipo_Impuesto.Equals("18%") ? Convert.ToDouble(pel.PrecioVenta) * (Convert.ToDouble(pel.PrecioVenta) * cantidad - ((Convert.ToDouble(pel.PrecioVenta) / 1.18) * cantidad))
                            : 0;

                        iG18 += pel.Tipo_Impuesto.Equals("18%") ? ((Convert.ToDouble(pel.PrecioVenta) / 1.18) * cantidad)
                            : 0;

                        exento += pel.Tipo_Impuesto.Equals("E  ") ? Convert.ToDouble(pel.PrecioVenta) * cantidad
                            : 0;
                        
                    }
                    else
                    {
                        //MessageBox.Show("sin impuesto");
                    }
                }
                txtSubtotal.Text = subtot.ToString("N2");
                txtISV18.Text = isv18.ToString("N2");
                txtISV15.Text = isv15.ToString("N2");
                txtIG15.Text = iG15.ToString("N2");
                txtIG18.Text = iG18.ToString("N2");
                txtImporteExento.Text = exento.ToString("N2");
                txtTotal.Text = (iG15 + iG18+ exento + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                if ((descuento + exonerado) < subtot)
                {
                    txtTotal.Text = (iG15 + iG18 + exento + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                    //txtTotal.Text = (subtot + isv15 + isv18 - (descuento + exonerado)).ToString("N2");
                }
                else
                {
                    MessageBox.Show("Error en descuentos y exonerados",
                    "No puede dar más descuentos de lo que suman los productos,¡Revise!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al agregar factura",
                "Contacte con el administrador", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }

        private void verificarIntegridad()
        {
            double descuento = 0;
            double total = 0;
            double exonerado = 0;

            try
            {
                 //descuento = txtDescuentos.Text == " " ? 0 : Convert.ToDouble(txtDescuentos.Text);
                 total = txtTotal.Text == " " ? 0 : Convert.ToDouble(txtTotal.Text);
                 exonerado = txtImporteExonerado.Text == " " ? 0 : Convert.ToDouble(txtImporteExonerado.Text);
            }
            catch { };

            if ((descuento + exonerado) > total)
            {
                MessageBox.Show("los descuentos y Exonerados no pueden ser mayores al total",
                "Error al imprimir factura", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                 errorV = true; return;
            }
            else
            {

                if (dgFactura.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Para imprimir debe tener mínimo un producto en la factura",
                    "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Warning); errorV = true; return;
                }
                else
                {
                    if (lblFactura.Text == "00000")
                    {
                        errorV = false;
                        cotizacion = false;
                        AgregarVenta();
                        Thread.Sleep(100);
                        AgregarDetalleDeVenta();
                        Thread.Sleep(100);
                        DisminuirInventario();
                        MessageBox.Show("¡Venta guardada correctamente!",
                        "¡Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                }
            }
        }
        private void AgregarVenta()
        {
            Punto_de_venta.Bases_de_datos.Venta tabla = new Punto_de_venta.Bases_de_datos.Venta();
            tabla.Importe_Exento = Convert.ToDecimal(txtImporteExento.Text);
            tabla.Importe_Exonerado = Convert.ToDecimal(txtImporteExonerado.Text);
            tabla.Impuesto_Gravado_15_ = Convert.ToDecimal(txtIG15.Text);
            tabla.Impuesto_Gravado_18_ = Convert.ToDecimal(txtIG18.Text);
            tabla.Impuesto_Gravado_15_ = Convert.ToDecimal(txtIG15.Text);
            tabla.ISV15_ = Convert.ToDecimal(txtISV15.Text);
            tabla.ISV18_ = Convert.ToDecimal(txtISV18.Text);
            tabla.Total_Venta = Convert.ToDecimal(txtTotal.Text);
            tabla.Fecha_Venta = DateTime.Now;
            tabla.Estado = 1;
            entity.Venta.Add(tabla);
            entity.SaveChanges();
            lblFactura.Text = tabla.IdVenta.ToString();
        }
        private void AgregarDetalleDeVenta()
        {
            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                Punto_de_venta.Bases_de_datos.DetalleVentas tabla = new Punto_de_venta.Bases_de_datos.DetalleVentas();
                string fkid = (dr.Cells[0].Value).ToString(); ;
                var Product = entity.Producto.FirstOrDefault(x => x.IdProducto == fkid);
                tabla.Producto = (dr.Cells[0].Value).ToString(); 
                tabla.Cantidad = Convert.ToInt32(dr.Cells[3].Value);
                tabla.Venta = Convert.ToInt32(lblFactura.Text);
                entity.DetalleVentas.Add(tabla);
                entity.SaveChanges();
                
            }
        }
        private void DisminuirInventario()
        {
            foreach (DataGridViewRow dr in dgFactura.Rows)
            {
                Punto_de_venta.Bases_de_datos.Producto tabla = new Punto_de_venta.Bases_de_datos.Producto();
                id =(dr.Cells[0].Value).ToString();
                var tablaP = entity.Producto.FirstOrDefault(x => x.IdProducto == id);
                tablaP.Cantidad = tablaP.Cantidad - Convert.ToInt32(dr.Cells[3].Value);
                entity.SaveChanges();


            }
        }
        private void Formulario_Ventas_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
            Mostrar_datos();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            QuitarProducto();
            HacerCuentas();
            Limpiar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            HacerCuentas();
            //dgFactura.Focus();
            if (dgFactura.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Para imprimir una cotización debe tener por lo menos un producto seleccionado",
                "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else
            {
                if (lblFactura.Text == "00000")
                {
                    cotizacion = true;
                    imprimirFactura();
                }
            }
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
                txtCantidad.Focus(); //control + C Elegir cantidad
            }
        }
        /// <summary>
        /// Impresión de Factura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters
            // of stringToPrint that will fit within the bounds of the page.




            //Pass the filepath and filename to the StreamWriter Constructor
            //StreamWriter sw = new StreamWriter("C:\\testPage.txt");
            //Write a line of text


            //Configuración para la cotización tamaño Carta ( tipo de letra,
            //ancho total de la factura, separación entre textos
            //tipos de alineado
            Font font = new Font("Arial", 10);
            int ancho = 180;
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

            e.Graphics.MeasureString(stringToPrint, this.Font,
            e.MarginBounds.Size, StringFormat.GenericTypographic,
            out charactersOnPage, out linesPerPage);



            //----------------------- Logo de la empresa ----------------------------------------------------------
            Bitmap myPng = Properties.Resources.puleria_isis;
            //----------------------------------------- x,y,ancho y alto
            e.Graphics.DrawImage(myPng, new RectangleF(50, y += 10, 100, 100));
            Bitmap myPng2 = Properties.Resources.PROFORMASOLA;
            //----------------------------------------- x,y,ancho y alto
            e.Graphics.DrawImage(myPng2, new RectangleF(25, y += 120, 150, 17));
            // //-----------------------Encabezado de cotización ----------------------------------------------------

            //---------------------------- Productos --------------------------------------------------------------
            //e.Graphics.DrawString("------ ------ ------ ------ ------ ------ ------ ------ ------ ------ Productos ------ ------ ------ ------ ------ ------ ------ ------ ------ ------", font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20), stringFormat);

            // Draws the string within the bounds of the page        font, Brushes.Black, new RectangleF(0, y += 40, ancho, 20), stringFormat);
            e.Graphics.DrawString(stringToPrint, font, Brushes.Black, new RectangleF(10, y += 20, ancho, e.MarginBounds.Height), StringFormat.GenericTypographic);

            //-------------------------- Pie de cotización --------------------------------------------------------


            // Remove the portion of the string that has been printed.
           // stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            //e.HasMorePages = (stringToPrint.Length > 0);
            //e.Graphics.DrawString(stringToPrint, font, Brushes.Black, new RectangleF(10, y += 20, ancho, e.MarginBounds.Height), StringFormat.GenericTypographic);
        }
        private void imprimirFactura()
        {
            string total = "";
            StreamWriter sw = new StreamWriter("C:\\testPage.txt");
            //string filePath = @"C:\testPage.txt";
            //if (!File.Exists(filePath))
            //{
            //    File.SetAttributes(filePath,
            //            (new FileInfo(filePath)).Attributes | FileAttributes.ReadOnly);

            //    // Crear .txt si no existe
            //    using (StreamWriter swp = File.CreateText(filePath))
            //    {}
            //}
            
            //----Encabezado----
            //sw.WriteLine("COTIZACIÓN DE PRODUCTOS",ContentAlignment.TopCenter);
            sw.WriteLine(" ");
            sw.WriteLine(" ");
            sw.WriteLine("Teléfono: 2773 - 0953"+"                                                         "+ DateTime.Now.ToString());
            //sw.WriteLine(DateTime.Now.ToString(),ContentAlignment.TopRight);
            sw.WriteLine("" + "Cliente: " + txtCliente.Text.ToUpper() + " ");
            sw.WriteLine("" + "RTN: " + txtRTN.Text + " ");
            sw.WriteLine("" + "Bodegón de los Precios Bajos, esquina opuesta al instituto Dr.Genaro Muñoz Hernandez, Siguatepeque, Comayagua.");
            sw.WriteLine(" ");
            sw.WriteLine("      ← PRODUCTOS →   ");
            sw.WriteLine(" ");
            //----productos----
            foreach (DataGridViewRow row in dgFactura.Rows)
            {
                // Producto
                sw.WriteLine("◢ "+ row.Cells[1].Value.ToString() + " ");
                sw.WriteLine("                  L. " + row.Cells[2].Value.ToString() + " X " + row.Cells[3].Value.ToString());
                sw.WriteLine(" ");
            }
            sw.WriteLine(" ");
            //----final de impresión 
            sw.WriteLine("Subtotal: L. " + txtSubtotal.Text + " ");
            sw.WriteLine("Importe exonerado: L." + txtImporteExonerado.Text + " ");
            sw.WriteLine("Descuento: L. " + Convert.ToDecimal(txtDescuentos.Text) + " ");
            sw.WriteLine("Importe exento: L. " + txtImporteExento.Text + " ");
            //sw.WriteLine("Importe grabado 18%: L. " + txtIG18.Text + " ");
            //sw.WriteLine("I.S.V 18%: L. " + txtISV18.Text + " ");
            sw.WriteLine("Importe grabado 15%: ");
            sw.WriteLine("L. " + txtIG15.Text + " ");
            sw.WriteLine("I.S.V 15%: L. " + txtISV15.Text + " ");
            total = (Convert.ToDecimal(txtSubtotal.Text) - Convert.ToDecimal(txtDescuentos.Text) - Convert.ToDecimal(txtImporteExonerado.Text)).ToString();
            sw.WriteLine(" ");
            sw.WriteLine("TOTAL: L. " + txtTotal.Text + " ");
            sw.Close();
            string docName = "testPage.txt";
            string docPath = @"C:\";
            string fullPath = System.IO.Path.Combine(docPath, docName);

            printDocument1.DocumentName = docName;

            stringToPrint = System.IO.File.ReadAllText(fullPath);
            //PrintDocument.PrinterSettings.PrinterName = "Microsoft Print To PDF";

         
             //PrinterSettings settings = new PrinterSettings();
             //foreach (string printer in PrinterSettings.InstalledPrinters)
             //{
             //    settings.PrinterName = "Microsoft Print To PDF";
               
             //}

         
         
            printDocument1.Print();

           
        }
        /* private void getImpresoraPorDefecto()
         {
             PrinterSettings settings = new PrinterSettings();
             foreach (string printer in PrinterSettings.InstalledPrinters)
             {
                 settings.PrinterName = printer;
                 if (settings.IsDefaultPrinter)
                     MessageBox.Show( printer);
             }

         }
        */
            private void getImpresoraPorDefecto()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = "Microsoft Print To PDF";
                /*if (settings.IsDefaultPrinter)
                    MessageBox.Show(printer);*/
            }

        }

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
            try
            {
                if (dgFactura.SelectedRows.Count > 0)
                {
                    int indice = dgFactura.CurrentCell.RowIndex;
                    dgFactura.Rows.RemoveAt(indice);
                }
                else
                {
                    MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un producto de la factura para eliminarlo",
                 "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            HacerCuentas();
            Limpiar();
        }

        private void btnSoloGuardar_Click(object sender, EventArgs e)
        {
       
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            if (dgFactura.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Para imprimir una cotización debe tener por lo menos un producto seleccionado",
                "Error al imprimir", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else
            {
                if (lblFactura.Text == "00000")
                {
                    cotizacion = true;
                   
                    imprimirFactura();
                }
            }
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

            string salida_datos = "";
            string[] palabras_busqueda = this.txtBuscar.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra +
                        "%' OR Categoria LIKE '%" + palabra + "%' OR Proveedor LIKE '%" + palabra + "%' )";
                }
                else
                {
                    salida_datos += "AND(Codigo LIKE '%" + palabra + "%' OR Producto LIKE '%" + palabra +
                        "%' OR Categoria LIKE '%" + palabra + "%' OR Proveedor LIKE '%" + palabra + "%' )";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
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
                if(dgProductos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró el producto que está buscando");
                }
                else
                {
                    if (txtCantidad.Text == string.Empty || Convert.ToInt32(txtCantidad.Text) < 1)
                    {
                        txtCantidad.Text = "1";
                    }
                    AgregarProducto();
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
            txtDescuentos.ReadOnly = true;
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
            txtDescuentos.ReadOnly = true;
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
            txtDescuentos.ReadOnly = true;
            HacerCuentas();
        }

        private void rbtnninguno_CheckedChanged(object sender, EventArgs e)
        {
            //double descuento = 0.00;
            verificar_checkbox_descuentos();
            //if (rbtnninguno.Checked)
            //{
            //    rbtn3.Checked = false;
            //    rbtn5.Checked = false;
            //    rbtn10.Checked = false;

            //}

            //txtDescuentos.Text = descuento.ToString();
            txtDescuentos.Text = 0.ToString();
            txtDescuentos.ReadOnly = true;
            HacerCuentas();

        }

        private void verificar_checkbox_descuentos()
        {
            double descuento = 0.00;
            double total_calculado = 0.00;
            if (rbtn3.Checked)
            {
                total_calculado = (Convert.ToDouble(txtSubtotal.Text));// + Convert.ToDouble(txtISV15.Text) + Convert.ToDouble(txtISV18.Text));
                //descuento = (Convert.ToDouble(txtTotal.Text) * 0.03);
                descuento = total_calculado * 0.03;
                rbtn10.Checked = false;
                rbtn5.Checked = false;
                rbtnninguno.Checked = false;
                txtDescuentos.Text = descuento.ToString();
            }
            if (rbtn5.Checked)
            {
                total_calculado = (Convert.ToDouble(txtSubtotal.Text));// + Convert.ToDouble(txtISV15.Text) + Convert.ToDouble(txtISV18.Text));
               
                descuento = total_calculado * 0.05;
                rbtn10.Checked = false;
                rbtn3.Checked = false;
                rbtnninguno.Checked = false;
                txtDescuentos.Text = descuento.ToString();
            }
            if (rbtn10.Checked)
            {
                total_calculado = (Convert.ToDouble(txtSubtotal.Text)); // + Convert.ToDouble(txtISV15.Text) + Convert.ToDouble(txtISV18.Text)+Convert.ToDouble(txtImporteExento.Text));
                descuento = total_calculado * 0.10;
                rbtn3.Checked = false;
                rbtn5.Checked = false;
                rbtnninguno.Checked = false;
                txtDescuentos.Text = descuento.ToString();
            }
            //txtDescuentos.Text = descuento.ToString();
            if (rbtnninguno.Checked)
            {
                //descuento = (Convert.ToDouble(txtTotal.Text) - (Convert.ToDouble(txtDescuentos.Text) )); 
                rbtn3.Checked = false;
                rbtn5.Checked = false;
                rbtn10.Checked = false;
                //txtTotal.Text = descuento.ToString();

            }
            
            
        }

        private void txtDescuentos_TextChanged(object sender, EventArgs e)
        {
            //HacerCuentas();
        }
    }
}
