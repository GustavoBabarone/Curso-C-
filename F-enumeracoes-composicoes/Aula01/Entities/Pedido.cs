using System;

namespace F_enumeracoes_composicoes.Aula01.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public StatusPedido StatusPedido { get; set; }

        public override string ToString()
        {
            return $"Order = {Id}, {Data}, {StatusPedido}";
        }
    }
}