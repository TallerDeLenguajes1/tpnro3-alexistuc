using System;
using System.Collections.Generic;
using System.Text;

namespace AlexisAleTrabajoPractico3
{
    class Cliente
    {
        //atributos
        private int id = 0;
        private string nombre;
        private string direccion;
        private string telefono;
        
        //constructor
        public Cliente() { }
        public Cliente(string nombre, string direccion, string telefono)
        {
            this.id = id++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }


        

    }
}
