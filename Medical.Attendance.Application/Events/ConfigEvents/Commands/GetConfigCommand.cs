using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Models.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical.Attendance.Application.Events.ConfigEvents.Commands
{
    public class GetConfigCommand : IRequest<ConfigViewModel>
    {
        public Guid DoctorId { get; set; }
    }
}
