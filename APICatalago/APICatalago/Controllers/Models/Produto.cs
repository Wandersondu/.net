namespace APICatalago.Controllers.Models;

public class Produto
{
    public int ProdutoId { get; set; }

    public string? Name { get; set; }

    public string? Descricao { get; set; }

    public decimal Preco { get; set; }

    public string? ImagemUrl { get; set; }

    public float Estoque { get; set; }

    public DateTime DataCadastro { get; set; }
}
