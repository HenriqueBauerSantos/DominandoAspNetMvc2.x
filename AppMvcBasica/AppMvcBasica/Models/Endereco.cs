using System.ComponentModel.DataAnnotations;

namespace AppMvcBasica.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O campo {0} precisa ter {1} caracteres")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}")]
        public string Estado { get; set; }

        /* EF Ralation */
        public Fornecedor Fornecedor { get; set; }
    }
}
