using SchoolProjectAPI.IRepositories;

namespace SchoolProjectAPI.Wrappers.IWrappers
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IWidgetRepository Widget { get; }
        IUserWidgetRepository UserWidget { get; }
        public void Save();
    }
}
