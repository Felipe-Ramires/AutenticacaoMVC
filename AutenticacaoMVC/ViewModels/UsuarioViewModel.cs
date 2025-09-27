using System.ComponentModel.DataAnnotations;

namespace AutenticacaoMVC.ViewModels
{
    /// <summary>
    /// Modelo de dados para o formulário de registro de usuário.
    /// Contém as regras de validação (DataAnnotations) para a entrada do usuário.
    /// </summary>
    public class UsuarioViewModel
    {
        /// <summary>
        /// Nome de usuário. Deve ser único e seguir um formato específico.
        /// </summary>
        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O nome de usuário deve ter entre 4 e 50 caracteres.")]
        [RegularExpression(@"^[a-zA-Z0-9_.-]+$", ErrorMessage = "O nome de usuário pode conter apenas letras, números, underscore, ponto e hífen.")]
        [Display(Name = "Nome de Usuário")]
        public string Nome { get; set; } = string.Empty;

        /// <summary>
        /// Senha do usuário. A validação exige uma senha forte.
        /// </summary>
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "A senha deve ter no mínimo 8 caracteres.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$",
            ErrorMessage = "A senha deve conter ao menos uma letra maiúscula, uma minúscula, um número e um caractere especial.")]
        public string Senha { get; set; } = string.Empty;

        /// <summary>
        /// Confirmação da senha. Deve ser idêntica à senha informada.
        /// </summary>
        [DataType(DataType.Password)]
        [Compare(nameof(Senha), ErrorMessage = "A senha e a confirmação de senha não coincidem.")]
        [Display(Name = "Confirme a Senha")]
        public string ConfirmarSenha { get; set; } = string.Empty;
    }
}
