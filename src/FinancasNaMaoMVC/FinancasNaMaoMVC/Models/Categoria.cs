using FinancasNaMaoMVC.Areas.Identity.Data;

namespace FinancasNaMaoMVC.Models
{
    public class Categoria 
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Usuario? Usuario { get; set; }
        public string? UsuarioId { get; set; }
    }
}
