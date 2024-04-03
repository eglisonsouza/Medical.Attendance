using Medical.Attendance.Domain.Models.Entities;

namespace Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel
{
    public sealed class HourViewModel
    {
        public Guid Id { get; set; }
        public DateTime Hour { get; set; }
        public int Sequential { get; set; }

        public static HourViewModel FromEntity(HourDay entity)
        {
            return new HourViewModel { Id = entity.Id, Hour = entity.Hour, Sequential = entity.Sequential };
        }
    }
}