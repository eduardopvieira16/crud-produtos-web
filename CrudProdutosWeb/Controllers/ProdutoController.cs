using Microsoft.AspNetCore.Mvc;
using CrudProdutosWeb.Models;
using CrudProdutosWeb.Services;

namespace CrudProdutosWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoServico _produtoServico;

        public ProdutoController()
        {
            _produtoServico = new ProdutoServico();
        }

        // api/produto
        [HttpGet]
        public ActionResult<List<Produto>> ListarProdutos()
        {
            var produtos = _produtoServico.ListarProdutos();
            return Ok(produtos);
        }

        // api/produto/{id}
        [HttpGet("{id}")]
        public ActionResult<Produto> ObterPorId(int id)
        {
            var produto = _produtoServico.ObterPorId(id);
            if (produto == null)
            {
                return NotFound("Produto não encontrado.");
            }
            return Ok(produto);
        }

        // api/produto
        [HttpPost]
        public ActionResult<Produto> CriarProduto([FromBody] Produto produto)
        {
            if (produto == null)
            {
                return BadRequest("Produto inválido.");
            }
            var novoProduto = _produtoServico.CriarProduto(produto);
            return CreatedAtAction(nameof(ObterPorId), new { id = novoProduto.Id }, novoProduto);
        }

        // api/produto/{id}
        [HttpPut("{id}")]
        public ActionResult<Produto> EditarProduto(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest("ID do produto não coincide.");
            }

            try
            {
                var produtoEditado = _produtoServico.EditarProduto(produto);
                return Ok(produtoEditado);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // api/produto/{id}
        [HttpDelete("{id}")]
        public ActionResult<Produto> ExcluirProduto(int id)
        {
            try
            {
                var produtoExcluido = _produtoServico.ExcluirProduto(id);
                return Ok(produtoExcluido);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
