using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Tareaa4.Models;  // Asegúrate de usar el espacio de nombres correcto donde están tus modelos

namespace Tareaa4.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet para los medios (series, películas o libros)
        public DbSet<MediaItem> MediaItems { get; set; }

        // DbSet para los personajes
        public DbSet<Character> Characters { get; set; }
    }
}
