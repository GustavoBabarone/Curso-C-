﻿using System.Globalization;

 namespace Curso.Aula05
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }
        
        public double GetPreco()
        {
            return _preco;
        }
        
        public int GetQuantidade()
        {
            return _quantidade;
        }

        public double CalcularValorTotal()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public string ExibirMensagem()
        {
            return $"{_nome}, "
                   + $"$ {_preco.ToString("F2", CultureInfo.InvariantCulture)}, "
                   + $"{_quantidade} unidades, "
                   + $"Total: $ {(CalcularValorTotal()).ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}