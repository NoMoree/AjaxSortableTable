using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjaxSortableTable.Data;
using AjaxSortableTable.Models;

namespace AjaxSortableTable.PopulateDbWithUsers
{
    public class DbSeed
    {
        private UowData db;

        public DbSeed(DbContext context = null)
        {
            if (context == null)
            {
                this.db = new UowData();
            }
            else
            {
                this.db = new UowData(context);
            }
        }

        public void PopulateUsers(int count = 1000)
        {
            int lastUser = 0;
            var usersCount = db.Users.All().Count();
            if (usersCount!= null && usersCount != 0)
            {
                lastUser = db.Users.All().OrderByDescending(x => x.Id).FirstOrDefault().Id;
            }

            List<User> newUsers = new List<User>(count);
            int random;
            for (int i = 0; i < count; i++)
            {
                lastUser++;
                random = SingleRandom.Instance.Next(10);
                newUsers.Add(new User()
                {
                    FirstName = "FirstName" + lastUser,
                    LastName = "LastName" + lastUser,
                    Telephone = "0888 99 " + lastUser.ToString("D4"),
                    Sex = random % 2 == 0 ? Sex.Male : Sex.Female,
                    Status = random <= 3 ? UserStatus.Active : (random < 8 ? UserStatus.Inactive : UserStatus.Deleted)
                });
            }
            foreach (User user in newUsers)
            {
                db.Users.Add(user);
            }
            db.SaveChanges();
        }
    }
}
