using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;
using SchoolProjectAPI.Repositories;
using SchoolProjectAPI.Wrappers.IWrappers;
using System;

namespace SchoolProjectAPI.Wrappers
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private SchoolProjectContext schoolProjectContext;

        public RepositoryWrapper(SchoolProjectContext schoolProjectContext)
        {
            this.schoolProjectContext = schoolProjectContext;
            user = new Lazy<IUserRepository>(() => new UserRepository(schoolProjectContext));
            widget = new Lazy<IWidgetRepository>(() => new WidgetRepository(schoolProjectContext));
            userwidget = new Lazy<IUserWidgetRepository>(() => new UserWidgetRepository(schoolProjectContext));
            personwidget = new Lazy<IPersonWidgetRepository>(() => new PersonWidgetRepository(schoolProjectContext));
            textwidget = new Lazy<ITextWidgetRepository>(() => new TextWidgetRepository(schoolProjectContext));
            weatherwidget = new Lazy<IWeatherWidgetRepository>(() => new WeatherWidgetRepository(schoolProjectContext));
        }

        //Fields
        private Lazy<IUserRepository> user;
        private Lazy<IWidgetRepository> widget;
        private Lazy<IUserWidgetRepository> userwidget;
        private Lazy<IPersonWidgetRepository> personwidget;
        private Lazy<ITextWidgetRepository> textwidget;
        private Lazy<IWeatherWidgetRepository> weatherwidget;

        //Props
        public IUserRepository User => user.Value;
        public IWidgetRepository Widget => widget.Value;
        public IUserWidgetRepository UserWidget => userwidget.Value;
        public IPersonWidgetRepository PersonWidget => personwidget.Value;
        public ITextWidgetRepository TextWidget => textwidget.Value;
        public IWeatherWidgetRepository WeatherWidget => weatherwidget.Value;

        //Save
        public void Save()
        {
            schoolProjectContext.SaveChanges();
        }
    }
}
