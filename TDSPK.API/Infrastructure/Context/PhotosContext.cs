using Microsoft.EntityFrameworkCore;
using TDSPK.API.Infrastructure.Mappings;
using TDSPK.API.Infrastructure.Persistence;

namespace TDSPK.API.Infrastructure.Context
{
    //classe de contexto do banco de dados - ligação entre o bd e minhas entidades
    public class PhotosContext(DbContextOptions<PhotosContext> options) : DbContext(options) 
    {

        public DbSet<Photo> Photos { get; set; }

        //sobrescreve o método OnModelCreating para adicionar as configurações de mapeamento
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PhotoMapping());
        }
    }
}
