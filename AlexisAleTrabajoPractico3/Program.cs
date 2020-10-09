/*
 2) Sistema para una Cadeteria
Una Empresa de cadetería necesita implementar un sistema para asignar pedidos a sus
cadetes y poder luego saber cuántos pedidos despachó cada uno para poder así pagarles su
correspondiente jornal ($100 por cada pedido Entregado)
Tenga en cuenta que: Cada Pedido tiene un Cliente y cada Cadete puede tener uno o
más pedidos. Si se elimina un pedido entonces el cliente tiene que eliminarse también, mientras
que si se quita el pedido del cadete entonces este pedido se puede asignar a otro cadete.

Generar:
Un informe de entregas realizadas por cadete donde se indique nombre de cadete,
cantidad de pedidos entregados y cuánto debe cobrar de jornal el cadete. Además, realice un
informe donde se indique cuál es el cadete que más pedidos entregó y un informe del promedio
de pedidos entregados.
Para poder realizar estas pruebas se recomienda desarrollar un simulador con valores
aleatorios donde se puede especificar la cantidad de cadetes y la cantidad de pedidos. Esta
implementación deberá ser por medio de una clase helper que realice la tarea.

 */

using System;

namespace AlexisAleTrabajoPractico3
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantPedidos = 0;
            Random randomizador = new Random();//semilla para los aleatorios
            cantPedidos = randomizador.Next(1, 10);

            try {
                for (int i = 0; i < cantPedidos; i++)
                {
                    Helper levantaPedidos = new Helper();
                    levantaPedidos.generadorDePedidos();
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("LO SENTIMOS, SE HA PRODUCIDO UN ERROR\n" + ex.Message);
            };


            
        }
    }
}
