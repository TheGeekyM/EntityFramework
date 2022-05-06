using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFramework.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<Entities.User>
    {
        public void Configure(EntityTypeBuilder<Entities.User> builder)
        {
            builder.Property(entity => entity.Name).IsRequired();
        }
    }
}
