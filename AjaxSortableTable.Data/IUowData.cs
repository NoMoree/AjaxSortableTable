using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxSortableTable.Data
{
    public interface IUowData : IDisposable
    {
        IUsersRepository Users { get; }

        int SaveChanges();
    }
}
