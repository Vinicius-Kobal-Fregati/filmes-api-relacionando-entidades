using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        [JsonIgnore] //Evita de entrar em loop infinito do cinema chamar o endereço e o endereço chamar o cinema
        public virtual Cinema Cinema { get; set; }
    }
}
