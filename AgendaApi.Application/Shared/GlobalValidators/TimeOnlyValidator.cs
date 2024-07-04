﻿using System.Globalization;

namespace AgendaApi.Application.Shared.GlobalValidators
{
    public static class TimeOnlyValidator
    {
        public static bool Format(TimeOnly time) =>
            TimeOnly.TryParseExact(time.ToString(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
    }
}
