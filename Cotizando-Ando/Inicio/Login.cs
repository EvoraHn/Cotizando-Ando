using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Punto_de_venta.Inicio
{
    public partial class Login : Form
    {
        Punto_de_venta.Bases_de_datos.BPBEntities1 entity = new Punto_de_venta.Bases_de_datos.BPBEntities1();
        public Login()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    
                    
                    MessageBox.Show("Horas restantes para que se acabe su licencia: " + horas.ToString(),
                        "LICENCIA DE PROGRAMA",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                                Punto_de_venta.Menú.Menu_estilo_2 Formulario = new Punto_de_venta.Menú.Menu_estilo_2(tUsuarios.FKPerfil);
                                this.Hide();                 
                                Formulario.ShowDialog();                                
                                this.Show();
                            }
                        }
                }

                else
                    {
                        if (horas > 0)
                        {
                            MessageBox.Show("Revise su conexión a la Red, No se puede acceder al servidor","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("¡Su licencia expiró!");
                            Punto_de_venta.Mantenimientos.FormCondicional Licencia = new Punto_de_venta.Mantenimientos.FormCondicional();
                            this.Hide();
                            Licencia.ShowDialog();
                            this.Show();
                        }     
                    }  
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Revise su licencia o conexión a la Red");
                Punto_de_venta.Mantenimientos.FormCondicional Licencia = new Punto_de_venta.Mantenimientos.FormCondicional();
                this.Hide();
                Licencia.ShowDialog();
                this.Show();
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
    }
    public class Hash
    {
        public static string obtenerHash256(string text)
        {

            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashString = new SHA256Managed();

            byte[] hash = hashString.ComputeHash(bytes);
            string hashStr = string.Empty;

            foreach (byte x in hash)
            {
                hashStr += String.Format("{0:x2}", x);
            }
            return hashStr;
        }
    }

    public static class Seguridad
    {
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
