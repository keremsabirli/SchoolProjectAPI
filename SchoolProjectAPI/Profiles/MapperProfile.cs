
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
            CreateMap<User, UserDTO>().IncludeBase<User, LiteUserDTO>().ReverseMap();
            //Detailed
            CreateMap<User, DetailedUserDTO>().IncludeBase<User, UserDTO>().ReverseMap();

            ///
            //Widget
            ///
            //Lite
            CreateMap<Widget, LiteWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<Widget, WidgetDTO>().IncludeBase<Widget, LiteWidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<Widget, DetailedWidgetDTO>().IncludeBase<Widget, WidgetDTO>().ReverseMap();

            ///
            //UserWidget
            ///
            //Lite
            CreateMap<UserWidget, LiteUserWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<UserWidget, UserWidgetDTO>().IncludeBase<UserWidget, LiteUserWidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<UserWidget, DetailedUserWidgetDTO>().IncludeBase<UserWidget, UserWidgetDTO>().ReverseMap();

            ///
            //PersonWidget
            ///
            //Lite
            CreateMap<PersonWidget, LitePersonWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<PersonWidget, PersonWidgetDTO>().IncludeBase<PersonWidget, LitePersonWidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<PersonWidget, DetailedPersonWidgetDTO>().IncludeBase<PersonWidget, PersonWidgetDTO>().ReverseMap();

            ///
            //TextWidget
            ///
            //Lite
            CreateMap<TextWidget, LiteTextWidgetDTO>().ReverseMap();
            //Standard
            CreateMap<TextWidget, TextWidgetDTO>().IncludeBase<TextWidget, LiteTextWidgetDTO>().ReverseMap();
            //Detailed
            CreateMap<TextWidget, DetailedTextWidgetDTO>().IncludeBase<TextWidget, TextWidgetDTO>().ReverseMap();
        }
    }
}
