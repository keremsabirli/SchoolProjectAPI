using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;

namespace SchoolProjectAPI.Repositories
{
    public class WidgetRepository : BaseRepository<Widget>, IWidgetRepository
    {
        public WidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
