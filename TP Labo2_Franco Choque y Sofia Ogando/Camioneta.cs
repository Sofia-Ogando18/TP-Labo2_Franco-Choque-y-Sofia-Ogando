using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Labo2_Franco_Choque_y_Sofia_Ogando
{
    internal class Camioneta
    {
        public int Altura_max;
        public int Ancho_max ;
        public int Apertura_Puertas ;
        public int Longitud;
        public int Distancia_Suelo ;
        public double Desgaste;

        public Camioneta()
        {
            Altura_max =  1233;// esta en cm,no?;
            Ancho_max = 1441;
            Apertura_Puertas = 1172;
            Longitud = 3092;
            Distancia_Suelo = 186;
            Desgaste = 0;
        }
    }
}
