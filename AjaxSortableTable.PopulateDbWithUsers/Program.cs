using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Data;
using AjaxSortableTable.Data.Migrations;

namespace AjaxSortableTable.PopulateDbWithUsers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());

            DataContext dataContext = new DataContext("Test1");

            DbSeed dbSeed = new DbSeed(dataContext);
            dbSeed.PopulateUsers();
        }
    }
}
