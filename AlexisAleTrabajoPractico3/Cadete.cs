using System;
using System.Collections.Generic;
using System.Text;

namespace AlexisAleTrabajoPractico3
{
    class Cadete
    {
        //atributos: id, nombre, dire, tel,listado de pedidos
        private string nombre = "chaparron bonaparte";
        private string direccion = "brandsen 805";
        private string telefono = "N/A";

        private Random randomizador = new Random();//semilla para los aleatorios

        public Cadete()
        {

        }

        public Cadete(int id, string direccion, string telefono)
        {
            this.id = id++;
            this.nombre = Helper.listaCadetes[randomizador.Next(0, 6)];
            this.direccion = direccion;
            this.telefono = telefono;
        }


    }
}
