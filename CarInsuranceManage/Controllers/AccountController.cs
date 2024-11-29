using AutoMapper;
using CarInsuranceManage.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarInsuranceManage.Controllers
{
    public class AccountController : Controller
    {
        private readonly DbContext db;
        private readonly IMapper _mapper;

        public AccountController(DbContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }

        // Đăng ký
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var User = _mapper.Map<User>(model);

                
            }

            return View(model);
        }

        //// Đăng nhập
        //[HttpGet]
        //public IActionResult Login() => View();

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index", "Home");
        //        }

        //        ModelState.AddModelError(string.Empty, "Đăng nhập thất bại.");
        //    }
        //    return View(model);
        //}

        //// Quên mật khẩu
        //[HttpGet]
        //public IActionResult ForgotPassword() => View();

        //[HttpPost]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var user = await _userManager.FindByEmailAsync(model.Email);
        //        if (user == null)
        //        {
        //            ModelState.AddModelError(string.Empty, "Không tìm thấy email này.");
        //            return View(model);
        //        }

        //        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //        var resetLink = Url.Action("ResetPassword", "Account", new { token, email = user.Email }, Request.Scheme);

        //        // Gửi email (bạn cần tích hợp dịch vụ gửi email tại đây)
        //        Console.WriteLine($"Reset link: {resetLink}");
        //        return RedirectToAction("ForgotPasswordConfirmation");
        //    }
        //    return View(model);
        //}
        //public IActionResult ForgotPasswordConfirmation() => View();
    }
}
