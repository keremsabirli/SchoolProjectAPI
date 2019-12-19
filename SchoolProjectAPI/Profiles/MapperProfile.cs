﻿
using AutoMapper;
using SchoolProjectAPI.DTOs;
using SchoolProjectAPI.Models;

namespace SchoolProjectAPI.Profiles
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            ///
            //User
            ///
            //Lite
            CreateMap<User, LiteUserDTO>().ReverseMap();
            //Standard
            CreateMap<User, UserDTO>().ReverseMap();
            //Detailed
            CreateMap<User, DetailedUserDTO>().ReverseMap();

            ///
            //Widget
            ///
            //Lite
            CreateMap<Widget, LiteWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<Widget, WidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<Widget, DetailedWidgetDTO>().ReverseMap();

            ///
            //UserWidget
            ///
            //Lite
            CreateMap<UserWidget, LiteUserWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<UserWidget, UserWidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<UserWidget, DetailedUserWidgetDTO>().ReverseMap();
        }
    }
}