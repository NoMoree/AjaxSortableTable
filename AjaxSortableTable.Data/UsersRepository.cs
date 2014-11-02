using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Models;

namespace AjaxSortableTable.Data
{
    public class UsersRepository : GenericRepository<User>, IUsersRepository
    {
        public UsersRepository(DbContext context)
            : base(context)
        {
        }

        public IQueryable<User> AllNotDeleted()
        {
            return this.DbSet.Where(x => x.Status != UserStatus.Deleted).AsQueryable();
        }
    }
}
