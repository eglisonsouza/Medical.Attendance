using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel
{
    public class ConfigViewModel
    {
        public Guid Id { get; set; }
        public bool IsWorkingHolidays { get; set; }
        public DoctorViewModel Doctor { get; set; } = new();
        public List<DayViewModel> Days { get; set; } = [];

        public void SetConfigFromEntity(Config entity)
        {
            Id = entity.Id;
            IsWorkingHolidays = entity.IsWorkingHolidays;
        }

        public void SetDoctorFromEntity(Doctor entity)
        {
            Doctor.Id = entity.Id;
            Doctor.Name = entity.Name;
        }

        public void AddDayFromEntity(Day entity)
        {
            Days.Add(DayViewModel.FromEntity(entity));
        }
    }
}
