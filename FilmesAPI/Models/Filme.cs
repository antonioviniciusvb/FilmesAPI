using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "Campo Diretor é obrigatório")]
        public string Diretor { get; set; }

        [StringLength(50, ErrorMessage = "O gênero não pode passar de 50 caracteres.")]
        public string Genero { get; set; }
        
        [Range(1,300, ErrorMessage = "Duração deve ser de 1 a 300 minutos.")]
        public int Duracao { get; set; }
    }
}
