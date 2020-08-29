using System;
using F_enumeracoes_composicoes.Aula01.Entities;

namespace F_enumeracoes_composicoes.Aula01
{
    public class Aula01
    {
        public static void Executar()
        {
            Pedido pedido = new Pedido
            {
                Id = 1080,
                Data = DateTime.Now,
                StatusPedido = StatusPedido.PagamentoPendente
            };
            
            Console.WriteLine(pedido);

            string txt = StatusPedido.PagamentoPendente.ToString();
            Console.WriteLine(txt);

            StatusPedido os = Enum.Parse<StatusPedido>("Entregue");
            Console.WriteLine(os);
        }
    }
}