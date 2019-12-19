using SchoolProjectAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
