using Medical.Attendance.Domain.Models.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.Configurations.SqlServer.EntitiesConfiguration.Base
{
    public class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder
                .HasKey(e => e.Id);
        }
    }
}
