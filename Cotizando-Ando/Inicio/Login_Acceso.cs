using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Inicio
{
    public partial class Login_Acceso : Form
    {
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Punto_de_venta.Bases_de_datos.BPBEntities1();
        public Login_Acceso()
        {
            InitializeComponent();
        }

     

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private void limpiar()
        {
            txtContraseña.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                string line;
                DateTime fechaLimite;
                StreamReader sr = new StreamReader("C:\\Test.txt");
                line = sr.ReadLine();
                sr.Close();
                DateTime fechaActual = DateTime.Now;
                if (((Seguridad.DesEncriptar(line)).Length) > 1)
                {
                    try
                    {
                        fechaLimite = Convert.ToDateTime(Seguridad.DesEncriptar(line));

                    }
                    catch
                    {
                        StreamWriter sw = new StreamWriter("C:\\Test.txt");
                        sw.WriteLine("bAB1AG4AZQBzACwAIAA1ACAAZABlACAAYQBiAHIAaQBsACAAZABlACAAMQA5ADkAOQA =");
                        sw.Close();
                        fechaLimite = new DateTime(2022, 10, 18, 1, 1, 1);
                    }

                }
                else
                {
                    fechaLimite = Convert.ToDateTime(Seguridad.DesEncriptar(line));
                }
                Console.ReadLine();

                //DateTime fechaLimite = new DateTime(2022, 10, 18, 1, 1, 1);

                var horas = (fechaLimite - DateTime.Now).TotalHours;
                if ((DateTime.Compare(fechaActual, fechaLimite)) < 0)
                {


                  
                    this.Hide();
                    if (horas < 360)
                    {
                        MessageBox.Show("SU LICENCIA ESTÁ A MENOS DE 15 DÍAS A VENCER (REVISE SUS HORAS RESTANTES) , contacte con su proveedor de servicios : +504 32689959 ",
                            "Contacte con su proveedor de servicios : +504 3268-9959",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if ((txtUsuario.Text == string.Empty) | (txtContraseña.Text == string.Empty))
                    {
                        MessageBox.Show("Favor llenar los campos de usuario y contraseña antes de iniciar sesión");
                    }
                    else
                    {
                        string pass = Hash.obtenerHash256(txtContraseña.Text);

                        var tUsuarios = entity.Usuario.FirstOrDefault(x => x.Usr == txtUsuario.Text && x.Pwd == pass);

                        if (tUsuarios == null)
                        {
                            MessageBox.Show("Usuario o contraseña incorrecto");
                            return;
                        }
                        else
                        {

                            limpiar();

                            Punto_de_venta.Clases.Usuario.ID = tUsuarios.IdUsuario.ToString();
                            if (Clases.Usuario.ID == "6")
                            {
                                Punto_de_venta.Ventas.Formulario_Cancelar_Factura Licencia = new Punto_de_venta.Ventas.Formulario_Cancelar_Factura();
                                this.Hide();
                                Licencia.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Su usuario no tiene permisos para acceder a este módulo ",
                            "Acceso denegado",
                            
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            
                            
                        }
                    }
                }

                else
                {
                    if (horas > 0)
                    {
                        MessageBox.Show("Revise su conexión a la Red, No se puede acceder al servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("¡Su licencia expiró!");
                        //Punto_de_venta.Mantenimientos.FormCondicional Licencia = new Punto_de_venta.Mantenimientos.FormCondicional();
                        
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revise su licencia o conexión a la Red");
                ////Punto_de_venta.Ventas.Formulario_Cancelar_Factura Licencia = new Punto_de_venta.Ventas.Formulario_Cancelar_Factura();
                //this.Hide();
                //Licencia.ShowDialog();
                //this.Show();
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ejecutando bloque final");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }
    }
    

    
}
