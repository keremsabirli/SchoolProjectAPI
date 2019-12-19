using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class WidgetRepository : BaseRepository<Widget>
    {
        public WidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
