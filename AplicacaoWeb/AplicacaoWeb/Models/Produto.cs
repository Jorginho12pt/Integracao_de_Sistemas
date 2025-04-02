namespace AplicacaoWeb.Models
{
    public class Produto
    {
        public int? IdProduto { get; set; }
        public string? CodigoPeca { get; set; }
        public DateTime? DataHoraProducao { get; set; }
        public int? TempoProduco { get; set; }
    }
}