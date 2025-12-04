using Microsoft.AspNetCore.Mvc;
using workout_tracker.Data;
using workout_tracker.Models;
using System.Linq;


namespace workout_tracker.Controllers
{
    public class WorkoutController : Controller
    {
        private readonly AppDb _db;

        public WorkoutController(AppDb db)
        {
            _db = db;
        }

        // عرض جميع التمارين من قاعدة البيانات
        public IActionResult Index()
        {
            var workouts = _db.Workouts.ToList();
            return View(workouts);
        }

        // نوديه لصفحة عشان يحط التكرين
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // بعد ما اليوزر يعبي البيانات ويرسلها
        [HttpPost]
        public IActionResult Create(WorkoutModel workout)
        {
            _db.Workouts.Add(workout);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // عشان يعدل البيانات حقت التمرين
        [HttpGet]
        public IActionResult Edit(string title)
        {
            var workout = _db.Workouts.FirstOrDefault(x => x.Title == title);
            return View(workout);
        }

        // نجفظه بعد التعديل
        [HttpPost]
        public IActionResult Edit(WorkoutModel workout)
        {
            var existing = _db.Workouts.FirstOrDefault(x => x.Title == workout.Title);
            if (existing != null)
            {
                existing.Category = workout.Category;
                existing.Duration = workout.Duration;
                existing.Calories = workout.Calories;
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // حذف تمرين ناخذ الانديكس او الرقم البرايمري من الفيو الي اسمه انديكس 
        public IActionResult Delete(int id)
        {
            var workout = _db.Workouts.FirstOrDefault(x => x.Id == id);
            if (workout != null)
            {
                _db.Workouts.Remove(workout);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SearchForm()
        {
            return View();
        }

        // عرض نتائج البحث
        [HttpPost]
        public IActionResult SearchResult(string searchTitle)
        {
            var results = _db.Workouts
                .Where(w => w.Title.Contains(searchTitle))
                .ToList();

            return View("Index", results);
        }
    }
}