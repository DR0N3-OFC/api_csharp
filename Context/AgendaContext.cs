using Microsoft.EntityFrameworkCore;
using modulo_api.Entities;

namespace modulo_api.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}