using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Labo2_Franco_Choque_y_Sofia_Ogando
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 
         static void Agregar_elementos(List<string> lista_,Listas l) {

            lista_.Add("licuadora");
            lista_.Add("exprimidor");
            lista_.Add("molinillos de cafe");
            lista_.Add("tostadoras");
            lista_.Add("cafeteras");
            lista_.Add("extractor de jugos");
            l.cant = 6;
        
         }

        [STAThread]
        static void Main()
        {
            Listas Pequenios_electrodomesticos=new Listas();
            Agregar_elementos(Pequenios_electrodomesticos.Listado,Pequenios_electrodomesticos);




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
