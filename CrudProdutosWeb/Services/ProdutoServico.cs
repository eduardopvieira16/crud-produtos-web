using CrudProdutosWeb.Models;

namespace CrudProdutosWeb.Services
{
    public class ProdutoServico
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto
            {
                Id = 1,
                Descricao = "Smartphone Samsung Galaxy S23 - 128GB",
                Preco = 4999.99m,
                DataValidade = new DateTime(2025, 12, 31)
            },
            new Produto
            {
                Id = 2,
                Descricao = "Notebook Dell Inspiron 15 - Intel i5",
                Preco = 3499.90m,
                DataValidade = new DateTime(2025, 11, 30)
            },
            new Produto
            {
                Id = 3,
                Descricao = "TV LG 55' 4K UHD Smart",
                Preco = 2999.99m,
                DataValidade = new DateTime(2026, 05, 15)
            },
            new Produto
            {
                Id = 4,
                Descricao = "Fone de Ouvido JBL Tune 500BT",
                Preco = 199.90m,
                DataValidade = new DateTime(2025, 08, 20)
            },
            new Produto
            {
                Id = 5,
                Descricao = "Console PlayStation 5 - Edição Digital",
                Preco = 4999.00m,
                DataValidade = new DateTime(2026, 12, 31)
            }
        };

        public Produto CriarProduto(Produto produto)
        {
            produto.Id = produtos.Count + 1;
            produtos.Add(produto);
            return produto;
        }

        public Produto EditarProduto(Produto produto)
        {
            var prodExistente = produtos.FirstOrDefault(p => p.Id == produto.Id);

            if (prodExistente != null)
            {
                prodExistente.Descricao = produto.Descricao;
                prodExistente.Preco = produto.Preco;
                prodExistente.DataValidade = produto.DataValidade;

                return prodExistente;
            }

            throw new Exception("Produto não encontrado.");
        }

        public Produto ExcluirProduto(int idProd)
        {
            var produto = produtos.FirstOrDefault(p => p.Id == idProd);

            if (produto != null)
            {
                produtos.Remove(produto);
                return produto;
            }

            throw new Exception("Produto não encontrado.");
        }

        public List<Produto> ListarProdutos()
        {
            return produtos;
        }

        public Produto ObterPorId(int idProd)
        {
            return produtos.FirstOrDefault(p => p.Id == idProd);
        }

    }
}
