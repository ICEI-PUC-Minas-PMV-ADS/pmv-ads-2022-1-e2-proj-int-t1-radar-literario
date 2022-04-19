using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RadarLiterario.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Required(ErrorMessage ="É obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o sobrenome")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de nascimento"), DataType(DataType.Date), Required(ErrorMessage = "É obrigatório informar sua data de nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "É obrigatório informar um email"), EmailAddress(ErrorMessage = "Preencha um email válido"), Key]
        public string Email { get; set; }

        [Required(ErrorMessage = "É obrigatório informar uma senha"), DataType(DataType.Password)]
        public string Senha { get; set; }

        [Display(Name = "Confirme a senha"), Compare("Senha", ErrorMessage = "A senha e a senha de confirmação não coincidem."), DataType(DataType.Password)]
        public string ConfirmarSenha { get; set; }
    }
}
