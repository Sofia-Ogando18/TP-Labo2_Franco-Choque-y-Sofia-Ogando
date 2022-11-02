using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Labo2_Franco_Choque_y_Sofia_Ogando
{
    internal class Furgoneta
    {
        public int Carga_max;//kg
        public int Capacidad_Carga ;//litros
        public double Consume ;// litros cada 100km
        public double Desgaste ;


        public Furgoneta()
        {
            Carga_max = 3500;//kg
            Capacidad_Carga = 17000;//litros
            Consume = 6.9;// litros cada 100km
            Desgaste = 0;

        }
    

    }
}
