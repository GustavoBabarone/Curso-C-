using System;

namespace F_enumeracoes_composicoes.Aula01.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "Order = " + Id + ", " + Moment + ", " + Status;
        }
    }
}