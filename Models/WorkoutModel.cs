using System.ComponentModel.DataAnnotations;

namespace workout_tracker.Models
{
    public class WorkoutModel
    {
        // من هنا بنضيف الخصائص الخاصة بالتمارين ونسحبها برضو
        public int Id { get; set; } // كانه برايمري كي 
        public string Title { get; set; }       // اسم التمرين زي ما سوينا مع البووك اول 
        public string Category { get; set; }    // نوع التمرين بوش او بول او ليق او كور 
        public int Duration { get; set; }       // المدة 
        public int Calories { get; set; }       // عدد السعرات الي انحرقت
    }
}