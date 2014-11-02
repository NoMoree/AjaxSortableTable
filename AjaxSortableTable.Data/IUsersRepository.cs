using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Models;

namespace AjaxSortableTable.Data
{
    public interface IUsersRepository : IRepository<User>
    {
        IQueryable<User> AllNotDeleted();
    }
}
