using System;
using System.Collections.Generic;
using System.Text;

namespace AlexisAleTrabajoPractico3
{
    class Helper
    {
        private Random randomizador = new Random();//semilla para los aleatorios

        public static string[] listaCadetes = { "Chaparron bonaparte", "Kim Jong-Un", "Claire Reidfield", "Scorpion", "Ranma Saotome", "Tino Costa", "Macsi Gil Herrera" };
        public static string[] observaciones = { "no funciona timbre", "llevar cambio", "edificio", "no da propinas", "negocio", "no le gusta el queso" };
        public static string[] estado = { "en camino", "entregado", "pendiente" };

        public string enviarCadete()
        {
            string mss = listaCadetes[randomizador.Next(listaCadetes.Length)];
            Console.WriteLine("EL CADETE ASIGNADO PARA EL ENVIO ES: " + mss);
            return mss;
        }

        public void generadorDePedidos()
        {
            string messeger;//esta variable recoge el valor de la funcion que asigna un cadete
            string obss = observaciones[randomizador.Next(observaciones.Length)];
            string state = estado[randomizador.Next(observaciones.Length)];
            Console.WriteLine("POR FAVOR INGRESE EL NOMBRE DEL CLIENTE: ");
            string clNombre = Console.ReadLine();
            Console.WriteLine("POR FAVOR INGRESE LA DIRECCION DEL CLIENTE: ");
            string clDireccion = Console.ReadLine();
            Console.WriteLine("POR FAVOR INGRESE EL TELEFONO DEL CLIENTE: ");
            string clTelefono = Console.ReadLine();
            Cliente customer = new Cliente(clNombre, clDireccion, clTelefono);
            messeger = enviarCadete();
            Pedido pedido1 = new Pedido(obss, customer, state, messeger);
            pedido1.agregarPedido();

        }


    }
}
