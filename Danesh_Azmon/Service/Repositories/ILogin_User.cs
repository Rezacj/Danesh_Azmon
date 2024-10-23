using Danesh_Azmon.Data;
using Danesh_Azmon.Models;
using Danesh_Azmon.Models.IO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Danesh_Azmon.Service.Repositories
{
    public interface ILogin_User
    {
       Task<tbl_user> UserLogin(IO_User_Login user); // Login
    }

    public class Login_User : ILogin_User
    {
        #region Constroctor
        private readonly MyContext _context;

        public Login_User(MyContext context)
        {
            _context = context;
        }
        #endregion

        public async Task<tbl_user> UserLogin(IO_User_Login user) // Login
        {
            return await _context.tbl_user.FirstOrDefaultAsync(c => c.NationalCode == user.NationalCode.Trim() &&
            c.Password == user.Password);

        }


    }
}
