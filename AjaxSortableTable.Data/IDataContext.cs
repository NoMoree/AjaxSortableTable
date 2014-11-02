using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Models;

namespace AjaxSortableTable.Data
{
    public interface IDataContext
    {
        IDbSet<User> Users { get; set; }
    }
}
