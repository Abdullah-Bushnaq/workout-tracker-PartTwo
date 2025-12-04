using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using workout_tracker.Models;

namespace workout_tracker.Data
{
    public class AppDb : DbContext
    {
        public AppDb(DbContextOptions<AppDb> options) : base(options) { }

        public DbSet<WorkoutModel> Workouts { get; set; }  // هنا جدول التمارين
    }
}