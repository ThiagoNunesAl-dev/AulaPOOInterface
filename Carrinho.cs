namespace AulaPOOInterface
{
    using System;
    using System.Collections.Generic;
    public class Carrinho : ICarrinho
    {
        public float ValorTotal { get; set; }
        List<Produto> produtos = new List<Produto>();
        public void AdicionarProd (Produto produto) {
            produtos.Add(produto);
        }
        public void RemoverProd (Produto produto) {
            produtos.Remove(produto);
        }
        public void Ler () {
            foreach (Produto p in produtos)
            {
                Console.WriteLine($"Nome: {p.Nome}\nPreço: R$ {p.Preco}\n");
            }
        }
        public void MostrarTotal () {
            foreach (Produto p in produtos)
            {
                ValorTotal = ValorTotal + p.Preco;
            }
            Console.WriteLine($"Preço Total: R$ {ValorTotal}");
        }
        public void AlterarProd (int _codigo, Produto _produtoNovo) {
            produtos.Find(o => o.Codigo == _codigo).Nome = _produtoNovo.Nome;
            produtos.Find(o => o.Codigo == _codigo).Preco = _produtoNovo.Preco;
        }
    }
}