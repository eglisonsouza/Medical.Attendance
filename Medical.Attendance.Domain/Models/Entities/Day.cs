using Medical.Attendance.Domain.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Day : BaseEntity
    {
        public string DayName { get; private set; }
        public int Sequencial { get; private set; }
        public List<HourDay> Hours { get; private set; }
    }
}
