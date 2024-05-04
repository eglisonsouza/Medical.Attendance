using AutoMapper;
using MediatR;
using Medical.Attendance.Application.Events.AttendanceEvents.Commands;
using Medical.Attendance.Application.Events.AttendanceEvents.Models.ViewsModel;
using Medical.Attendance.Domain.Models.Entities;
using Medical.Attendance.Domain.Repositories;

namespace Medical.Attendance.Application.Events.AttendanceEvents.Handlers
{
    public sealed class AddAttendanceHandler(IAttendanceRepository repository, IMapperBase mapper) : IRequestHandler<AddAttendanceCommand, AttendanceViewModel>
    {
        private readonly IAttendanceRepository _repository = repository;
        private readonly IMapperBase _mapper = mapper;

        public async Task<AttendanceViewModel> Handle(AddAttendanceCommand request, CancellationToken cancellationToken)
        {
            var attendance = await _repository.AddAsync(_mapper.Map<AttendanceMedical>(request), cancellationToken);

            return _mapper.Map<AttendanceViewModel>(attendance);
        }
    }
}
