using Enumeracoes_e_Composicoes.Entities;
using Enumeracoes_e_Composicoes.Entities.Enums;
using System;

namespace Enumeracoes_e_Composicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversão de string para enumeração e vice-versa:

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
