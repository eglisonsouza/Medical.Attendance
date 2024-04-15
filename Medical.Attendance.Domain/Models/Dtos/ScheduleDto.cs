namespace Medical.Attendance.Domain.Models.Dtos
{
    public class ScheduleDto
    {
        public List<DaysSchedulesDto> DaysSchedules { get; set; }
    }

    public class DaysSchedulesDto(DateTime day, int durationInMinutes)
    {
        public DateTime Day { get; set; } = day;
        public int DurationInMinutes { get; set; } = durationInMinutes;
    }
}
