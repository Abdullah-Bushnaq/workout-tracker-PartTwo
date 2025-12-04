namespace workout_tracker.Models
{
    public class UserModel
    {
        //الفكرة انو من هنا تنضاف وتنسحب البيانات الخاصة بالمستخدم
        public string FullName { get; set; } // الاسم الكامل

        public string Email { get; set; }// الايميل

        public string Phone { get; set; }// رقم الجوال

        public string Password { get; set; }// كلمة المرور
    }
}