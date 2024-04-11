using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaDecontatos.Models
{
    [Table("ClienteBd")]
    public class ClienteModel
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set;}
        public string Valor { get; set;}
        public string CPF { get; set;}
        public DateTime Data { get; set; } = DateTime.Now;
    }
}
