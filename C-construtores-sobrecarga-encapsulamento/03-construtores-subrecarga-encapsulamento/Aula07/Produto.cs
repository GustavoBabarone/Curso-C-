﻿using System.Globalization;

 namespace Curso.Aula07
{
    public class Produto
    {
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }
        
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return Nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double CalcularValorTotal()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public string ExibirMensagem()
        {
            return $"{_nome}, "
                   + $"$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, "
                   + $"{Quantidade} unidades, "
                   + $"Total: $ {(CalcularValorTotal()).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}