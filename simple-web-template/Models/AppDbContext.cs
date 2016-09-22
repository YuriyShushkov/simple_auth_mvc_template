using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using simple_web_template.Common;

namespace simple_web_template.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        { }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }

    public class UserDbInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext db)
        {
            db.Roles.Add(new Role { Id = 1, Name = "admin" });
            db.Roles.Add(new Role { Id = 2, Name = "user" });
            db.Users.Add(new User
            {
                Email = "navff@gmail.com",
                Password_Hash = "123456".ToMd5(),
                RoleId = 1
            });
            db.Users.Add(new User
            {
                Email = "hooy@gmail.com",
                Password_Hash = "123456".ToMd5(),
                RoleId = 2
            });
            base.Seed(db);
            db.SaveChanges();
        }

        public void Init()
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Count() == 0)
                {
                    this.Seed(new AppDbContext());
                }
            }
            
        }
    }
}