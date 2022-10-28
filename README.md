# filmes-api-relacionando-entidades
Projeto realizado no curso ".NET5 e EF Core: relacionando entidades" da Alura, ministrado pelo professor Daniel Artine.

## Sobre o projeto
API de filmes, ela possuí entidades de cinema, filme, endereço, gerente e sessão, sendo que elas se relacionam de diferentes formas, como 1:1, 1:n e n:n.  
Foram utilizados os pacotes AutoMapper, EntityFramework, AspNetCore, MySql e Newronsoft.  

## Conceitos aprendidos no curso
 - Relacionamentos 1:1 deve ser utilizado quando queremos uq euma entidade possua exatamente outra como par.
 - Como utilizar o ModelBuilder para explicitar como ocorrerá o relacionamento.
 - Lazy properties são usadas ára carregar informações de outra entidade.
 - Relacionamento 1:n estabelece relação de uma entidade e várias outras.
 - Problemas de loops podem ser resolvidos com AutoMapper e CreateMap(), além do JsonIgnore.
 - O que é remoção por cascata e cini alterar seu modo através do OnModelCreating.
 - Como tornar um atributo de chave estrangeira obrigatório ou não com isRequired.
 - Relacionamento n:n é usado para relacionar muitas entidades com muitas outras.
 - Como quebrar um relacionamento n:n para 1:n, criando uma entidade intermediária.
 - Calcular informações em tempo de execução com AutoMapper.
 - Como utilizar query parameters através do FromQuery.
 - Consultas avançadas com encadeamento de métodos e LINQ.
