using A1.Data;
using A1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace A1.Service
{
    public class DBService
    {
        static DBService()
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Database.EnsureCreated();
            }
        }

        public void Add(User user)
        {
            using (AppDBContext appDB=new AppDBContext())
            {
                appDB.Add(user);
                appDB.SaveChanges();
            }
        }

        public User Search(Expression<Func<User, bool>> filter)
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                return appDB.Users.FirstOrDefault(filter);
            }
        }

        public void Delete(Expression<Func<User,bool>> filter) 
        {
            using (AppDBContext appDB = new AppDBContext())
            {
                appDB.Users.Remove(appDB.Users.FirstOrDefault(filter));
            }
        }
    }
}
