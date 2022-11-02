using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Labo2_Franco_Choque_y_Sofia_Ogando
{
    internal class Furgon
    {
        // tiene GNC y ahorra un 40%
        public int Carga_max ; 
        public int Carga_util ;
        public double Voluem_carga ;
        public double Consumo ;
        public double Desgaste ;

        public Furgon()
        {

            Carga_max = 7000; //kilos
            Carga_util = 49000;
            Voluem_carga = 10.8;//m3 
            Consumo = 14.84;//litros, consume cada 100 km
            Desgaste = 0;

        }
    }
}
