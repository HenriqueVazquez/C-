using ExemploEnum1TipoPagamento.Entities.Enums;
using System;


namespace ExemploEnum1TipoPagamento.Entities {
     class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
