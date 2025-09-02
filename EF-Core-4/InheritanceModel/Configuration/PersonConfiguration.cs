using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Core_4.InheritanceModel.Configuration
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.UseTphMappingStrategy();
            //builder.UseTpcMappingStrategy();
           // builder.UseTptMappingStrategy();
        }
    }
}
