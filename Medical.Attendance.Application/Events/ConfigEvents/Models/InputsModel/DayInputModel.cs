namespace Medical.Attendance.Application.Events.ConfigEvents.Models.InputsModel
{
    public sealed class DayInputModel
    {
        public string DayName { get; set; }
        public int Sequential { get; set; }
        public List<HourInputModel> Hours { get; set; }
    }
}
