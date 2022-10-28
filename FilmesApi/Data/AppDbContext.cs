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
            builder.Entity<Endereco>() //Um para um
                .HasOne(endereco => endereco.Cinema) //Endereço possuí um cinema
                .WithOne(cinema => cinema.Endereco) //Cinema também possuí um endereço
                .HasForeignKey<Cinema>(cinema => cinema.EnderecoId); //Cinema tem uma chave estrangeira, sendo o EnderecoId.

            builder.Entity<Cinema>() // Um para muitos
                .HasOne(cinema => cinema.Gerente) // Cinema possuí gerente
                .WithMany(gerente => gerente.Cinemas) // Gerente pode possuir nenhum ou vários cinemas
                .HasForeignKey(cinema => cinema.GerenteId); // Cinema tem chave estrangeira, sendo o GerenteId.
                                                            //.HasForeignKey(cinema => cinema.GerenteId).IsRequired(false); // Is required faz um cinema poder existir sem um gerente.
                                                            //.OnDelete(DeleteBehavior.Restrict); // Com isso, se apagarmos gerente, ele não apaga o cinema.
                                                            // Por padrão, o modo de deleção é em cascata.

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Filme) // Nossa sessão terá um filme
                .WithMany(filme => filme.Sessoes) // Esse filme terá nenhuma ou várias sessões
                .HasForeignKey(sessao => sessao.FilmeId); // A sessao tem uma chave estrangeira que é o Id do filme.

            builder.Entity<Sessao>()
                .HasOne(sessao => sessao.Cinema) // Nossa sessão terá um cinema
                .WithMany(cinema => cinema.Sessoes) // Esse cinema terá nenhuma ou várias sessões
                .HasForeignKey(sessao => sessao.CinemaId); // A sessão tem uma chave estrangeira que é o Id do cinema.
        }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Sessao> Sessoes { get; set; }
    }
}