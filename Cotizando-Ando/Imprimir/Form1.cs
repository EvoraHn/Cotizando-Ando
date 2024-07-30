using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using Punto_de_venta.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.ComTypes;
using CrystalDecisions.Shared;
using Punto_de_venta.Properties;
using System.Reflection;


namespace Punto_de_venta.Imprimir
{
    public partial class Form1 : Form
    {
        private string stringToPrint = "";
        public Form1()
        {
            InitializeComponent();
            Cargar_Impresoras();
        }

        private void cmbimpresoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Cargar_Impresoras()
        {
            cmbimpresoras.Items.Clear();
            PrinterSettings settings = new PrinterSettings();
            foreach (string name in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cmbimpresoras.Items.Add(name.ToString());
                settings.PrinterName = name;
                if (settings.IsDefaultPrinter)
                    //MessageBox.Show(name);
                    cmbimpresoras.Text = name;
                btn_imprimir.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1 = new printDocument();
            PrinterSettings ps = new PrinterSettings();
            if (cmbimpresoras.Text == string.Empty)
            {
                MessageBox.Show("Por favor seleccione una impresora antes de intentar inprimir");
            }
            else
            {
                ps.PrinterName = cmbimpresoras.Text.ToString();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += imprimir;
                printDocument1.Print();
            }
        }

        private void imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 10);
            //int ancho = 180;
            int y = 0;
            


            //----------------------- Logo de la empresa ----------------------------------------------------------

            int charactersOnPage = 0;
            int linesPerPage = 0;



            //Configuración para la cotización tamaño Carta ( tipo de letra,
            //ancho total de la factura, separación entre textos
            //tipos de alineado


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
            Bitmap myPng = Properties.Resources.LOGONEGRO;
            e.Graphics.DrawImage(myPng, new RectangleF(50, y += 10, 100, 100));
            e.Graphics.DrawString("un ticket feliz", font, Brushes.Black, new Rectangle(55, y += 120, 100, 20));
            e.Graphics.DrawImage(pbcodigo_de_barras.Image, new Rectangle(5, y += 120, 200, 40));
        }

        private void btngenerar_codigo_de_Barras_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw mGeneradorCB = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;

            pbcodigo_de_barras.Image = mGeneradorCB.Draw(txtcodigo_a_generar.Text, 30);
        }
    }
}
                         