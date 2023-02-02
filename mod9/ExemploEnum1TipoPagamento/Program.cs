using ExemploEnum1TipoPagamento.Entities;
using ExemploEnum1TipoPagamento.Entities.Enums;
using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 1081,
                Moment= DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
           Console.WriteLine(os);
        }
    }
}