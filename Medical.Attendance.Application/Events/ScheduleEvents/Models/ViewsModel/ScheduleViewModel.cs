namespace Medical.Attendance.Application.Events.ScheduleEvents.Models.ViewsModel
{
    public class ScheduleViewModel
    {
        public List<DayScheduleViewModel> DaysRange { get; set; }
    }

    public class DayScheduleViewModel
    {
        public DateTime DateStart { get; set; }
    }
}
