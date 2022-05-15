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

        [Display(Name = "Título"),
            Required(ErrorMessage = "É obrigatório informar o título do livro")]
        public string titulo { get; set; }

        [Display(Name = "Imagem da capa (URL)"),
            DataType(DataType.Url),
            Required(ErrorMessage = "É obrigatório adicionar uma capa")]
        public string ImagemCapa { get; set; }

        [Display(Name = "Categorias"),
            Required(ErrorMessage = "É obrigatório informar categorias para o livro")]
        public string genero { get; set; }

        [Display(Name = "Sinopse"),
            Required(ErrorMessage = "É obrigatório informar uma sinopse para o livro"),
            DataType(DataType.MultilineText),
            MaxLength(255, ErrorMessage = "A sinopse não pode ser maior que 255 caracteres")]
        public string sinopse { get; set; }

        public ICollection<Arquivos> Arquivos { get; set; }
    }
}
