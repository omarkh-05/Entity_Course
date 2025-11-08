using Entity_Course.AppDBContext1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course
{
    internal class Tracking_NoTracking
    {
        // var db = new AppDBContext();
       //  db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking; // for all dbcontext 
            // لفائدة الأساسية زيادة الأداء عند عرض البيانات فقط / SaveChanges() بإحضار البيانات فقط بدون تتبعها / أي تغييرات على الكائنات لن تُرسل تلقائيًا لقاعدة البيانات عند

            // for specific db 
            //using (var db = new AppDBContext())
            //{
            //    var students = db.Students.AsNoTracking().ToList(); // No-Tracking Query

            //    students[0].Name = "Ali Updated"; // لا يؤثر على قاعدة البيانات

            //    db.SaveChanges(); // لا يحدث أي تغيير
            //}


            //  No-Tracking : read/تقارير/Export
            //  Tracking : CRUD (تحديث/حذف/إضافة)

        //  Example : No Tracking

    //        using (var db = new AppDBContext())
    //        {
    //            // استعلام بيانات الطلاب بدون تتبع (Read-Only)
    //            var students = db.Students
    //                             .AsNoTracking()     // هنا نحدد No-Tracking
    //                             .Where(s => s.DepartmentID == 1)
    //                             .OrderBy(s => s.Name)
    //                             .ToList();

    //            // عرض البيانات
    //            foreach (var student in students)
    //            {
    //                Console.WriteLine($"Name: {student.Name}, Mobile: {student.MobileNumber}");
    //            }

    //// أي تعديل على الكائنات هنا لن يتم حفظه في قاعدة البيانات
    //students[0].Name = "Ali Updated";
    //            db.SaveChanges(); // لن يحدث أي تغيير لأن الكائنات غير متتبعة
    //        }

    }
}
