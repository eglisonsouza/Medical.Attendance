using Medical.Attendance.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Medical.Attendance.Infra.Persistence.Configurations.EntitiesConfiguration
{
    public class AttendanceEntityConfiguration : BaseEntityConfiguration<AttendanceMedical>
    {

        public new void Configure(EntityTypeBuilder<AttendanceMedical> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.PatientId)
                .IsRequired();

            builder
                .Property(p => p.DoctorId)
                .IsRequired();

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
                .Property(p => p.CancellationDescription)
                .IsRequired();

            builder
                .Property(p => p.Status)
                .IsRequired();

            builder
                .Property(p => p.TransactionId)
                .IsRequired();

            builder
                .Property(p => p.Value)
                .IsRequired();

            builder.HasOne(p => p.Doctor);
        }
    }
}
