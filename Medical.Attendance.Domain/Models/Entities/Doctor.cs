using Medical.Attendance.Domain.Models.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Domain.Models.Entities
{
    public sealed class Doctor : BaseEntity
    {
        public string Name { get; private set; }
        public Config Config { get; private set; }
    }
}
