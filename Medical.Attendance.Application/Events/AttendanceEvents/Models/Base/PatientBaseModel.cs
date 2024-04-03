namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.Base
{
    public abstract class PatientBaseModel
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
