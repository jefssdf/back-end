﻿namespace AgendaApi.Application.UseCases.WeekDayUseCases.DTOs
{
    public abstract record WeekDayBaseResponse
    {
        public int WeekDayId { get; set; }
        public string Name { get; set; }
    }
}