using Microsoft.AspNetCore.Mvc;
// اضفناه عشان نقدر نستخدم الموديلز
using workout_tracker.Models;

namespace workout_tracker.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // يضيف اكشن لصفحة تسجيل الدخول عشان الكنترول يشوفها ويرجع فيو ونقدر نوصل لها 
        [HttpGet]// عشان لما يضغط المستخدم على رابط تسجيل الدخول
        public IActionResult Login()
        {
            return View();
        }



        // نفس فكرة تسجيل الدخول بس هذي لتسجيل حساب جديد
        [HttpGet]// عشان لما يضغط المستخدم على رابط تسجيل حساب جديد
        public IActionResult Signup()
        {
            return View();
        }




        // هنا بنستقبل البيانات اللي يرسلها المستخدم من صفحة تسجيل الدخول
        [HttpPost]// عشان لما يضغط المستخدم على زر تسجيل الدخول ويرسل البيانات
        public IActionResult Signup(UserModel user)
        {
            return View("SignupSuccess", user);
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            return View("LoginSuccess", user);
        }
    }
}