using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Infra.Persistence.EntitiesConfiguration.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.EntitiesConfiguration
{
    public class AttendanceConfiguration : BaseConfiguration<AttendanceMedical>
    {

        public new void Configure(EntityTypeBuilder<AttendanceMedical> builder)
        {
            base.Configure(builder);

            builder
                .HasOne(p => p.Patient);

            builder
                .HasOne(p => p.Doctor);

            builder
                .Property(p => p.ProceduralMedicalId)
                .IsRequired();

            builder
                .Property(p => p.Start)
                .IsRequired();

            builder
                .Property(p => p.End)
                .IsRequired();

            builder
                .Property(p => p.HealthInsurance)
                .IsRequired();

            builder
                .Property(p => p.CancellationDescription);

            builder
                .Property(p => p.Status)
                .IsRequired();

            builder
                .Property(p => p.TransactionId);

            builder
                .Property(p => p.Value)
                .IsRequired();
        }
    }
}
