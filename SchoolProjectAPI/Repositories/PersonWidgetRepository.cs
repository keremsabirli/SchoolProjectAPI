using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class PersonWidgetRepository : BaseRepository<PersonWidget>, IPersonWidgetRepository
    {
        public PersonWidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
