using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Models;

namespace AjaxSortableTable.Data
{
    public class DataContext : DbContext
    {
        public DataContext(string contextString)
            : base(contextString)
        {
        }

        public DataContext()
            : base("Test1")
        {
        }

        public IDbSet<User> Users { get; set; }
    }
}
