using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using simple_web_template.Common;
using simple_web_template.Models.ViewModels;

namespace simple_web_template.Models.Operations
{
    public class LoginOperations
    {
        private AppDbContext _appDbContext;

        public LoginOperations(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public static bool CheckPassword(string password, string passwordHash)
        {
            return (password.ToMd5() == passwordHash);
        }

        public User Authentificate(string email, string password)
        {
            var hash = password.ToMd5();
            return _appDbContext.Users.FirstOrDefault(u => u.Email == email && u.Password_Hash == hash);
        }
    }
}