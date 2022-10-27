using AutoMapper;
using FilmesApi.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<EnderecoProfile, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
