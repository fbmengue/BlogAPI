using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class LoginViewModel
{


    [Required(ErrorMessage = "O E-mail é Obrigatório")]
    [EmailAddress(ErrorMessage = "O E-mail é inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a Senha")]
    public string Password { get; set; }
}
