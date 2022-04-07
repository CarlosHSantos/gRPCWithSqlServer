using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrpcServer.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome Obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string Nome { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sobrenome Obrigatório.")]
        [MaxLength(300, ErrorMessage = "Máximo 50 caracteres.")]
        public string SobreNome { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "E-mail Obrigatório.")]
        [MaxLength(300, ErrorMessage = "Máximo 100 caracteres.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "DDD Obrigatório.")]
        public int? DDD { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Telefone Obrigatório.")]
        public double? Telefone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Senha Obrigatório.")]
        [MaxLength(50, ErrorMessage = "Máximo 50 caracteres.")]
        public string Senha { get; set; } = string.Empty;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Cargo Obrigatório.")]
        public ECargo Cargo { get; set; }
    }
}
