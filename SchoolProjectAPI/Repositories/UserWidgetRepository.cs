using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class UserWidgetRepository : BaseRepository<UserWidget>
    {
        public UserWidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
