using Microsoft.EntityFrameworkCore;
using testeweb.Models;

// esse arquivo determina a conexao com o banco de dados

namespace testeweb.Contexts
{
    public class testewebContext : DbContext
    {
        public DbSet<Todo> Todos => Set<Todo>(); // informa quais modelos serao utilizados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Todo.db"); //https://www.connectionstrings.com/sqlite/
        }
    }
}
