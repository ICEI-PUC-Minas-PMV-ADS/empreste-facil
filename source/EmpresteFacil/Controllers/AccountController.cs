using EmpresteFacil.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EmpresteFacil.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AccountController(UserManager<Usuario> userManager,
        SignInManager<Usuario> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = "/Home"
            });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user,
                loginVM.Password, true, false);

                if (result.Succeeded)
                {
                    var isMember = await _userManager.IsInRoleAsync(user, "Member");
                    if (isMember)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                    if (isAdmin)
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                }
            }
            ModelState.AddModelError("", "Falha ao realizar o login!!");
            return View();
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistroViewModel registroVM)
        {
            if (ModelState.IsValid)
            {
                var user = new Usuario { UserName = registroVM.UserName, Nome = registroVM.Nome, Perfil = registroVM.Perfil, TelefoneFixo = registroVM.TelefoneFixo, Email = registroVM.Email, EmailConfirmed = true, Document = registroVM.Document, RG = registroVM.RG  };
                var result = await _userManager.CreateAsync(user, registroVM.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Member").Wait();
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Success", "Account");
                }
                else
                {
                    this.ModelState.AddModelError("Registro", "Falha ao registrar o usuário");
                }
            }
            return View(registroVM);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            HttpContext.Session.Clear();
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
