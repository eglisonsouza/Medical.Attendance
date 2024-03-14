using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel
{
    public class DayViewModel
    {
        public Guid Id { get; set; }
        public string DayName { get; set; }
        public int Sequential { get; set; }
        public List<HourViewModel> Hours { get; set; } = [];

        public static DayViewModel FromEntity(Day entity)
        {
            return new DayViewModel
            {
                Id = entity.Id,
                DayName = entity.DayName,
                Sequential = entity.Sequential,
            };
        }
        public void SetHoursFromEntity(HourDay entity)
        {
            Hours.Add(HourViewModel.FromEntity(entity));
        }
    }
}