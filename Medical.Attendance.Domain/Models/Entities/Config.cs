using Medical.Attendance.Domain.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Config : BaseEntity
    {
        public bool IsWorkingHolidays { get; private set; }
        public List<Day> WorkDays { get; private set; }
    }
}
