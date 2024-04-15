using MediatR;
using Medical.Attendance.Application.Events.ScheduleEvents.Commands;
using Medical.Attendance.Application.Events.ScheduleEvents.Models.ViewsModel;
using Medical.Attendance.Domain.Repositories;

namespace Medical.Attendance.Application.Events.ScheduleEvents.Handlers
{
    public class GetScheduleHandle(IScheduleRepository repository) : IRequestHandler<GetScheduleCommand, ScheduleViewModel>
    {
        private readonly IScheduleRepository _repository = repository;

        public async Task<ScheduleViewModel> Handle(GetScheduleCommand request, CancellationToken cancellationToken)
        {
            var daysSchedules = _repository.GetDaysSchedules(request.StartMonth, request.DoctorId);

            var configDays = _repository.GetConfigAsync(request.DoctorId);

            var dayRange = new ScheduleViewModel();

            var dayInit = new DateTime(request.StartMonth.Year, request.StartMonth.Month, 1);

            var dayEnd = DateTime.DaysInMonth(request.StartMonth.Year, request.StartMonth.Month);

            //for(var day = request)

            return dayRange;
        }
    }
}
