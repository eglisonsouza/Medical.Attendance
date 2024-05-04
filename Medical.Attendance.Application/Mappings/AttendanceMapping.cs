using AutoMapper;
using Medical.Attendance.Application.Events.AttendanceEvents.Commands;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;
using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Mappings
{
    public class AttendanceMapping : Profile
    {
        protected AttendanceMapping()
        {
            CreateMap<AddAttendanceCommand, AttendanceMedical>()
                .ForMember(dst => dst.DoctorId, map => map.MapFrom(src => src.DoctorId))
                .ForMember(dst => dst.ProceduralMedicalId, map => map.MapFrom(src => src.ProceduralMedicalId))
                .ForMember(dst => dst.Start, map => map.MapFrom(src => src.Start))
                .ForMember(dst => dst.End, map => map.MapFrom(src => src.End))
                .ForMember(dst => dst.HealthInsurance, map => map.MapFrom(src => src.HealthInsurance))
                .ForMember(dst => dst.Status, map => map.MapFrom(src => src.Status))
                .ForMember(dst => dst.Value, map => map.MapFrom(src => src.Value))

                .ForMember(dst => dst.Patient.ClientId, map => map.MapFrom(src => src.Patient.ClientId))
                .ForMember(dst => dst.Patient.Name, map => map.MapFrom(src => src.Patient.Name))
                .ForMember(dst => dst.Patient.Phone, map => map.MapFrom(src => src.Patient.Phone))
                .ReverseMap();

            CreateMap<AttendanceMedical, AttendanceViewModel>()
                .ForMember(dst => dst.Id, map => map.MapFrom(src => src.Id))
                .ForMember(dst => dst.DoctorId, map => map.MapFrom(src => src.DoctorId))
                .ForMember(dst => dst.ProceduralMedicalId, map => map.MapFrom(src => src.ProceduralMedicalId))
                .ForMember(dst => dst.Start, map => map.MapFrom(src => src.Start))
                .ForMember(dst => dst.End, map => map.MapFrom(src => src.End))
                .ForMember(dst => dst.HealthInsurance, map => map.MapFrom(src => src.HealthInsurance))
                .ForMember(dst => dst.Status, map => map.MapFrom(src => src.Status))
                .ForMember(dst => dst.Value, map => map.MapFrom(src => src.Value))

                .ForMember(dst => dst.Patient.Id, map => map.MapFrom(src => src.Patient.Id))
                .ForMember(dst => dst.Patient.ClientId, map => map.MapFrom(src => src.Patient.ClientId))
                .ForMember(dst => dst.Patient.Name, map => map.MapFrom(src => src.Patient.Name))
                .ForMember(dst => dst.Patient.Phone, map => map.MapFrom(src => src.Patient.Phone))
                .ReverseMap();
        }
    }
}
