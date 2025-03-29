using System.ComponentModel.DataAnnotations;

namespace AplicacaoWeb.Class
{
    public class TesteRelatorio
    {
        public DateTime? DataHora { get; set; }
        public string? CodigoPeca { get; set; }
        public DateTime? TempoProduco { get; set; }
        public int? ResultadoTeste { get; set; }
    }
}
