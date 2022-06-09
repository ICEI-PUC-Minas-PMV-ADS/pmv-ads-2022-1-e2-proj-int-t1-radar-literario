using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadarLiterario.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Required(ErrorMessage = "É obrigatório informar seu nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar seu sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de nascimento"),
            DataType(DataType.Date),
            Required(ErrorMessage = "É obrigatório informar sua data de nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "É obrigatório informar um email"),
            EmailAddress(ErrorMessage = "Preencha um email válido"), Key]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma senha"), DataType(DataType.Password),
            MinLength(8, ErrorMessage = "A senha não pode ser menor que 8 caracteres"),
            MaxLength(20, ErrorMessage = "A senha não pode ser maior que 20 caracteres")]
        public string Senha { get; set; }

        [Display(Name = "Confirme a senha"),
            Compare("Senha", ErrorMessage = "As senhas não coincidem"), DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }
    }
}
