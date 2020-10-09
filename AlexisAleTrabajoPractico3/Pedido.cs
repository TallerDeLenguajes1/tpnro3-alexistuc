using System;
using System.Collections.Generic;
using System.Text;

namespace AlexisAleTrabajoPractico3
{
    class Pedido
    {
        //numero, obs, cliente estado

        //atributos
        private int numero = 0;
        private string observaciones;
        private Cliente customer;
        private string estado;
        private string messenger;
        public List<Pedido> listaPedidos = new List<Pedido>();
        
        //constructores
        public Pedido() { }
        public Pedido(int numero) {
            numero++;
        }

        public Pedido(int numero, string obs, Cliente customer, string estado, string messenger)
        {
            this.numero = numero++;
            this.observaciones = obs;
            this.customer = customer;
            this.estado = estado;
            this.messenger = messenger;
        }

        public Pedido(string obs, Cliente customer, string estado, string messenger)
        {
            this.numero = numero++;
            this.observaciones = obs;
            this.customer = customer;
            this.estado = estado;
            this.messenger = messenger;
        }

        //objeto generico
        Pedido pedido1 = new Pedido();

        //metodos

        public void agregarPedido()
        {
            int temp = numero;
            listaPedidos.Add(pedido1);
        }

        public void listadoPedidos()
        {
            try
            {
                foreach (var item in listaPedidos)
                {
                    Console.WriteLine("LISTA DE PEDIDOS: ");
                    Console.WriteLine("PEDIDO NUM: " + numero);
                    Console.WriteLine("CLIENTE NUM: " + this.customer);
                    Console.WriteLine("ESTADO DEL PEDIDO: " + this.estado);
                    Console.WriteLine("CADETE: " + this.messenger);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("SE HA PRODUCIDO UN ERROR EN LA CARGA DE PEDIDOS \n" + e.Message);
            }
        }

    }
}
