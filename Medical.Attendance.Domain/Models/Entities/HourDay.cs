﻿using Medical.Attendance.Domain.Models.Entities.Base;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class HourDay : BaseEntity
    {
        public DateTime Hour { get; private set; }
        public int Sequencial { get; private set; }
        public Guid DayId { get; private set; }
        public Day Day { get; private set; }
    }
}
