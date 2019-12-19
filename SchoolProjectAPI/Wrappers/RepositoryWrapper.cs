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
        }

        //Fields
        private Lazy<IUserRepository> user;
        private Lazy<IWidgetRepository> widget;
        private Lazy<IUserWidgetRepository> userwidget;

        //Props
        public IUserRepository User => user.Value;
        public IWidgetRepository Widget => widget.Value;
        public IUserWidgetRepository UserWidget => userwidget.Value;

        //Save
        public void Save()
        {
            schoolProjectContext.SaveChanges();
        }
    }
}
