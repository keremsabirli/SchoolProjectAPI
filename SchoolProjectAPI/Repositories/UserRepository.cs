using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;

namespace SchoolProjectAPI.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
