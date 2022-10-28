using AutoMapper;
using FilmesApi.Data.Dtos.Sessao;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioDeInicio, opts => opts // Executando tarefa em tempo de execução
                .MapFrom(dto =>
                dto.HorarioDeEncerramento.AddMinutes(dto.Filme.Duracao * (-1)))); // Multiplicou em menos 1 para subtrair
        }
    }
}
