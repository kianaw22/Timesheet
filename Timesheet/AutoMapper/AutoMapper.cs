﻿using AutoMapper;
using Timesheet.Models.Entities.Admin;
using Timesheet.Models.ViewModels.Admin;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Position, PositionViewModel>().ReverseMap();
    }
}