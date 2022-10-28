using FilmesAPI.Models;
using System.Collections.Generic;

namespace FilmesApi.Data.Dtos
{
    public class ReadGerenteDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        // Precisa ser do tipo object para podermos realizar o trabalho com o AutoMapper
        // Evitando o uso do JsonIgnore e ainda selecionando o que retornar de cinemas.
        public object Cinemas { get; set; }
    }
}
