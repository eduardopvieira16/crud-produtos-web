﻿namespace CrudProdutosWeb.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataValidade { get; set; }
    }
}
