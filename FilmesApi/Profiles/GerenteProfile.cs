using AutoMapper;
using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using System.Linq;

namespace FilmesApi.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            // Com esse uso do AutoMapper, não dependemos da anotação JsonIgnore e ainda escolhemos o que exibir.
            // Note que o tipo de Cinemas teve que ser object para dar certo, isso do ReadGerenteDto.
            CreateMap<Gerente, ReadGerenteDto>() // Mapeamos de gerente para ReadGerenteDto
                .ForMember(gerente => gerente.Cinemas, opts => opts // Para o membro de cinemas, dentro de gerente, solicitamos as opções:
                .MapFrom(gerente => gerente.Cinemas.Select // Mapeia, retorna de gerente.Cinemas o Id, Nome, Endereco e EnderecoId do cinema
                (c => new { c.Id, c.Nome, c.Endereco, c.EnderecoId })));
        }
    }
}
