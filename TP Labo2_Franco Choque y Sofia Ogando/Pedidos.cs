using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Labo2_Franco_Choque_y_Sofia_Ogando
{
    internal class Pedidos
    {
        //para hacer una lista con los pedidos
        // se me ocurrio hacer 3 listas en el main con los articulos y hacer una cuarta lista con los pedidos
        // que tenga los datos del cliente (direccion,DNI , nombre y tipo de entrega) y ademas uns pila (o algo asi) con las cosas que compro
        //osea en esta clase hacer una pila (no se si se puede). si se te ocurre algo mejor

        public string Nombre_Apellido;
        public string DNI;
        public int hora_de_entrega=0;
        Stack <string> Productos;

        public Pedidos(string nombre_Apellido, string dNI, int hora_de_entrega)
        {
            Nombre_Apellido = nombre_Apellido;
            DNI = dNI;
            this.hora_de_entrega = hora_de_entrega;
            Productos = new Stack<string>();
        }

        public void Hacer_Pedido(Listas lista_) {
            //es un ejemplo, lo podemos hacer aleatorio.La funcion puede recibir la cantidad de productos y hacemos un for aleatorio
            Productos.Push(lista_.Listado[0]);

        }
      
        

    }
}
