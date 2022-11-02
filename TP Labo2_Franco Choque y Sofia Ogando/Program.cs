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
            lista_.Add("molinillo de cafe");
            lista_.Add("tostadora");
            lista_.Add("cafetera");
            lista_.Add("extractor de jugos");
            l.cant = 6;
        
         }
        static void Agregar_elementos_blancos(List<string> lista_, Listas l)
        {

            lista_.Add("cocina");
            lista_.Add("calefone");
            lista_.Add("termotanque");
            lista_.Add("lavarropas");
            lista_.Add("secarropas");
            lista_.Add("heladera");
            lista_.Add("microondas");
            lista_.Add("freezers");
            l.cant = 8;

        }

        static void Agregar_elementos_Elect(List<string> lista_, Listas l)
        {

            lista_.Add("notebook");
            lista_.Add("impresora");
            lista_.Add("monitor");
            lista_.Add("mouse");
            lista_.Add("parlantes");
            lista_.Add("teclados");
            lista_.Add("televisor");
            l.cant = 7;

        }

        

        [STAThread]
        static void Main()
        {
            Listas Pequenios_electrodomesticos=new Listas();
            Agregar_elementos(Pequenios_electrodomesticos.Listado,Pequenios_electrodomesticos);
            Listas Linea_blanca=new Listas();
            Agregar_elementos_blancos(Linea_blanca.Listado, Linea_blanca);
            Listas Electronicos = new Listas();
            Agregar_elementos_Elect(Electronicos.Listado, Electronicos);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
