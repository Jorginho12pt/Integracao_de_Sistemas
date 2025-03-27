using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AplicacaoWeb
{
    
    public class Item
    {
        [Key]  // Ensures this is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-incremented by DB
        public int? Id { get; set; }
        public DateTime? DataHora { get; set; }
        public string? CodigoPeca {  get; set; }
        public DateTime? TempoProduco { get; set; }
        public int? ResultadoTeste { get; set; }
    }
}
