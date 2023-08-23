using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppMvc.Models {
    public class Filme {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="O {0} precisa ter entre {2} e {1} caracteres")]
        public string Titulo { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.DateTime,ErrorMessage = "{0} em formato incorreto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00c0-\u00FF""'\@-]*$",ErrorMessage = "{0} em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        public string Genero { get; set; }

        [Display(Name = "Preço")]
        [Range(1,100,ErrorMessage = "{0} de {1} e {2}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Avaliação")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage = "Somente números de 0 a 5")]
        public int Avaliacao { get; set; }
    }
}
