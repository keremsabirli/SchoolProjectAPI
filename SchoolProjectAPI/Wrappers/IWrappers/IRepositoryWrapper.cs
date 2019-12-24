using SchoolProjectAPI.IRepositories;

namespace SchoolProjectAPI.Wrappers.IWrappers
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IWidgetRepository Widget { get; }
        IUserWidgetRepository UserWidget { get; }
        IPersonWidgetRepository PersonWidget { get; }
        public void Save();
    }
}
