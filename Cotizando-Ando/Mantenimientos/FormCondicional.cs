using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta.Mantenimientos
{
    public partial class FormCondicional : Form
    {
        public FormCondicional()
        {
            InitializeComponent();
        }

        private void FormCondicional_Load(object sender, EventArgs e)
        {
            //linkLabel1.Links.Add(0, 0, "https://wa.me/qr/ZV523Y7QNQHCE1");
            //if (Acceso == "Administración")
            //{
            //    button1.Enabled = false;
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (Acceso == "Administración")
            //{
            //    button1.Enabled = false;
            //}
            //MessageBox.Show(Acceso);
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DateTime Actual = DateTime.UtcNow;
            try
            {
                string cadena = Punto_de_venta.Inicio.Seguridad.DesEncriptar(rtxtLicencia.Text);
                try
                {
                    DateTime Fecha = Convert.ToDateTime(cadena);
                    if (Fecha < Actual)
                    {
                        MessageBox.Show("Licencia invalida");
                    }
                    else
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter("C:\\Test.txt");
                        //Write a line of text
                        sw.WriteLine(rtxtLicencia.Text);
                        //Write a second line of text
                        sw.WriteLine("Licencia Generada Por Eliab Evora a la fecha de" + " " + Actual);
                        sw.WriteLine("Si La licencia se llega a vencer debe contactar con el adminitador de Sistema (Eliab Evora).");
                        sw.WriteLine("La renovación de la licencia está ligada a costo, consulte de acuerdo a la cantidad de tiempo que desea usar el sistema.");
                        sw.WriteLine("+50499085779 Contacto del administrador de sistema.");
                        //Close the file
                        sw.Close();
                        MessageBox.Show("Licencia guardada correctamente");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Licencia invalida " );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Licencia invalida " );
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            rtxtLicencia.Text = string.Empty;
        }
    }
}
