using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Display(Name = "Nome do Lanche")]
        [Required(ErrorMessage = "{0} deve ser informado")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no maximo é {2} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Decrição do Lanche")]
        [Required(ErrorMessage = "{0} deve ser informado")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no maximo é {2} caracteres")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Decrição Detalhada do Lanche")]
        [Required(ErrorMessage = "{0} deve ser informado")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no maximo é {2} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "{0} deve ser informado")]
        [Column(TypeName = "decimal(10,2")]
        [Range (1,999.99, ErrorMessage ="{0} deve estar entre {2} e {1}")]
        public decimal Preco { get; set; }

        [Display(Name ="Caminho da Imagem Normal")]
        [StringLength(200, ErrorMessage ="{0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho da Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "{0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name ="Estoque?")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
