using SchoolProjectAPI.IRepositories;

namespace SchoolProjectAPI.Wrappers.IWrappers
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IWidgetRepository Widget { get; }
        IUserWidgetRepository UserWidget { get; }
        IPersonWidgetRepository PersonWidget { get; }
        ITextWidgetRepository TextWidget { get; }
        IWeatherWidgetRepository WeatherWidget { get; }
        public void Save();
    }
}
