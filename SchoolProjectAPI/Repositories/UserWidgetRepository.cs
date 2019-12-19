using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;

namespace SchoolProjectAPI.Repositories
{
    public class UserWidgetRepository : BaseRepository<UserWidget>, IUserWidgetRepository
    {
        public UserWidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
