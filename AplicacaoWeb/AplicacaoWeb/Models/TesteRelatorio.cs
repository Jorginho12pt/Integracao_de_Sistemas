namespace AplicacaoWeb.Models
{
    public class TesteRelatorio
    {
        public DateTime? DataHora { get; set; }
        public string? CodigoPeca { get; set; }
        public TimeSpan? TempoProduco { get; set; }
        public int? ResultadoTeste { get; set; }
    }
}