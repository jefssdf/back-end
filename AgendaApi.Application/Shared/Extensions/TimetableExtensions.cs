using AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay;
using AgendaApi.Domain.Entities;
using System.Reflection.Metadata.Ecma335;

namespace AgendaApi.Application.Shared.Extensions
{
    public static class TimetableExtensions
    {
        public static List<AvailableTimeDTO> PrintFormatedTimetable(this ICollection<Timetable> timetables,
            List<AvailableTimeDTO> list)
        {
            foreach (var timetable in timetables)
            {
                while (timetable.StartTime < timetable.EndTime)
                {
                    list.Add(new AvailableTimeDTO
                    {
                        StartTime = timetable.StartTime,
                        WeekDayId = timetable.WeekDayId,
                    });
                    timetable.StartTime = timetable.StartTime.AddMinutes(30);
                }
            }
            return list;
        }
        public static bool VerifyAvailability(this ICollection<Timetable> timetables, DateTime startTime, Service service)
        {
            DateTime endTime = startTime.Add(service.Duration);
            TimeOnly timeOnlyStartTime = TimeOnly.FromDateTime(startTime);
            TimeOnly timeOnlyEndTime = TimeOnly.FromDateTime(endTime);

            foreach (var timetable in timetables)
            {
                if (timeOnlyStartTime < timetable.StartTime || timeOnlyEndTime >= timetable.EndTime) return false;

                foreach (var scheduling in timetable.Schedulings)
                {
                    if ((startTime >= scheduling.ConfirmationDate && startTime < scheduling.ConfirmationDate.Add(scheduling.Service.Duration)) ||
                        (endTime > scheduling.ConfirmationDate && endTime <= scheduling.ConfirmationDate.Add(scheduling.Service.Duration)) ||
                        (startTime <= scheduling.ConfirmationDate && endTime >= scheduling.ConfirmationDate.Add(scheduling.Service.Duration)))  return false;
                }
            }
            return true;
        }
    }
}
