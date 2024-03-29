using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Models.Base
{
    public class PatientBaseModel
    {
        public Guid ClientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

    }
}
