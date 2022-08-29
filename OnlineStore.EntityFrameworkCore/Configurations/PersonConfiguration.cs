using Microsoft.EntityFrameworkCore;
using OnlineStore.Domain.Aggregates;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineStore.EntityFrameworkCore.Configurations
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        #region [- Configure() -] 
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person", "Person");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50);

        }
        #endregion
    }
}
