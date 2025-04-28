using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDSPK.API.Infrastructure.Persistence;

namespace TDSPK.API.Infrastructure.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("Users");
            builder
                .HasKey("Id");
            builder
                .Property(user => user.Name)
                .IsRequired();
         
        }
    }
}
