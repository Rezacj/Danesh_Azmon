using Danesh_Azmon.Models.IO;
using Danesh_Azmon.Service.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Danesh_Azmon.Data;

namespace Danesh_Azmon.Controllers
{
    public class AccountController : Controller
    {
      
        #region Constroctor
        private readonly MyContext _context;
        private readonly ILogin_User _user;

        #endregion
        public AccountController(ILogin_User user, MyContext context)
        {
            _context = context;

            _user = user;
        }

        [HttpPost]
        public async Task<IActionResult> Login(IO_User_Login _input)
        {
            if (_input.NationalCode.Trim() == null || _input.NationalCode.Trim() == null)
            {
                return Unauthorized(0); // اجازه ورود ندارد
            }
          

            var _User = await _user.UserLogin(_input);

            if (_User == null)
            {
                return Unauthorized(1); // رمز عبور یا نام کاربری اشتباه است
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Role, _User.Role),
                    new Claim("NationalCode", _User.NationalCode)
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    IsPersistent = _input.RemmeberMe,
                    ExpiresUtc = _input.RemmeberMe ? DateTime.UtcNow.AddDays(1) : DateTime.UtcNow.AddMinutes(30) // تعیین زمان انقضا
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties);

                if (_User.Role == "student")
                    return Redirect("/Student/index"); // ورود دانشجو
                else
                    return Redirect("/Teacher/index"); ; // ورود استاد



            }
            


        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/home/index");
        }
    }
}
