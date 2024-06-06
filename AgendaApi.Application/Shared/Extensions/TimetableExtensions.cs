using AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay;
using AgendaApi.Domain.Entities;

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
        //public static bool VerifyAvailability(this Timetable timetable, DateTime startTime, TimeSpan duration)
        //{
        //    DateTime endTime = startTime.Add(duration);
        //    TimeOnly timeOnlyStartTime = TimeOnly.FromDateTime(startTime);
        //    TimeOnly timeOnlyEndTime = TimeOnly.FromDateTime(endTime);

        //    if (timeOnlyStartTime < timetable.StartTime || timeOnlyEndTime >= timetable.EndTime) return false;

        //    foreach ()
        //}
    }
}
