using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
