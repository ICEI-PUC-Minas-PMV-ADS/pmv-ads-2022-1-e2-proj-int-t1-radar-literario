using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RadarLiterario.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Titulo"), Required(ErrorMessage ="É obrigatório informar o titulo")]
        public string titulo { get; set; }

        [Display(Name = "Gênero"), Required(ErrorMessage = "É obrigatório informar o gênero do livro")]
        public string genero { get; set; }

        [Display(Name = "Sinopse"), Required(ErrorMessage = "É obrigatório informar o sinopse do livro")]
        public string sinopse { get; set; }

    }
}
