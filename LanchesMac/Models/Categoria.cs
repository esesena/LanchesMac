using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage ="Informe o nome da {0}")]
        [StringLength(100, ErrorMessage ="O tamanho maximo é {1} caracteres")]
        public string CategoriaNome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe o nome da {0}")]
        [StringLength(100, ErrorMessage = "O tamanho maximo é {1} caracteres")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
