using FilmesApi.Models;
using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        // Vamos fazer algumas definições no momento de criação do nosso modelo
        // HasOne faz referência a um objeto do tipo endereço

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.Entity<Endereco>()
                .HasOne(endereco => endereco.Cinema) //Endereço possuí um cinema
                .WithOne(cinema => cinema.Endereco) //Cinema também possuí um endereço
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId); //Cinema tem uma chave estrangeira, sendo o EnderecoId.
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
    }
}