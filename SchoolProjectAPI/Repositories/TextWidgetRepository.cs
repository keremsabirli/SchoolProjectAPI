using SchoolProjectAPI.IRepositories;
using SchoolProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolProjectAPI.Repositories
{
    public class TextWidgetRepository : BaseRepository<TextWidget>, ITextWidgetRepository
    {
        public TextWidgetRepository(SchoolProjectContext context) : base(context)
        {
        }
    }
}
