using FilmesAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore] // Utilizado para evitar ciclos de repetição
        public virtual List<Cinema> Cinemas { get; set; }
    }
}
