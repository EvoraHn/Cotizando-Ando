using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_venta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Punto_de_venta.Menú.Menu_estilo_2(1));
            //Application.Run(new Punto_de_venta.Ventas.Formulario_Cancelar_Factura());
            
            //("Administración"));
            //Application.Run(new Punto_de_venta.Inicio.Login());
            
            //Application.Run(new Punto_de_venta.Ventas.Formulario_Ventana_Vender());
            Application.Run(new Punto_de_venta.Mantenimientos.Mantenimiento_cierre_Diario());
            //Application.Run(new Punto_de_venta.Compras.Formulario_Compras_Generales());
            Application.Exit();
            //Application.Run(new Punto_de_venta.Mantenimientos.Mantenimiento_Usuarios_2_0());
        }
    }
}
