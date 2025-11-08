using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.Loading
{
    internal class Loading
    {
        //              Loding Eager     بحمل في البداية على طول دفعة وحدة
        // في الكود الي تجت حيعطيني ايررور لانه ما حمل الكائن تبع الديبارتمينت
        //var student = db.Students.Find(1);
        //Console.WriteLine(student.department.Name);

        // the solution بستخدم في حال عندي كائن واحد فقط زي جدول الطلاب والديبارتمينت
        //var student = db.Students.Include(d => d.department).SingleOrDefault(s => s.StudentID == 2);
        //Console.WriteLine(student.department.Name);

        // في حال كان عندي كائن بدي اجيب عنه معلومات بس الكائن هاض عبارة عن جدول وجواته الكائن الي بدي اجيب عنه معلومات زي جدول الطلاب الكتب بس العلاقة بينهم مني تو مني عندي جدول 3 
        // الجدول الثالث هاض جواته الجدول المطلوب مثال
        // جدول الطلاب في studentbooks هسا انا بدي البوكس فجوا الحدول هاض في books عشان اوصله لازم استخدم ThenIncude

        // if i have theninclude the main include must be bezabt before the theninclude
        //var student = db.Students.Include(d => d.department).Include(b => b.Books).ThenInclude(b => b.book).SingleOrDefault(s => s.StudentID == 2);
        //foreach (var book in student.Books)
        //{
        //    Console.WriteLine(book.book.Name);
        //}



        //              Loding Explicit  هاي تستخدم في حال  بديش احمل الداتا تبعت الكائن من البداية مرة وحدة بس وصلت عند منطقة محتاج احمل اشي معين من الكائن الي جوا
        //var student = db.Students.SingleOrDefault(s => s.StudentID == 2);
        //db.Entry(student).Reference(d => d.department).Load();
        //Console.WriteLine(student.department.Name);

        ////   حطينا Collection لانه نوع البوك كوليكشن
        //db.Entry(student).Collection(st => st.Books).Query().Where(x => x.BookID == 2).ToList(); // or db.Entry(student).Collection(st => st.Books).Load(); to load all 
        //foreach (var book in student.Books)
        //{
        //    db.Entry(book).Reference(b=>b.book).Load();
        //    Console.WriteLine(book.book.Name);
        //}




        //              Loding Lazy  بتحملش الا بس احط انا كود زي الي تحت
        //  virtual بعد الببلك نحط navigation property عشان نسويه لازم نحط كل ال 
        //  بعدين بدنا انزل Microsoft.EntityFrameworkCore.Proxies
        //  optionsBuilder.UseLazyLoadingProxies().UseSqlServer(Connection.ConnectionString); OnConriguring جوا ال dbcontextfile بعدين بدنا نضيف لل ال 
        //var student = db.Students.SingleOrDefault(s => s.StudentID == 2);
        //Console.WriteLine(student.department.Name);

        //    foreach (var book in student.Books)
        //    {
        //        db.Entry(book).Reference(b => b.book).Load();
        //Console.WriteLine(book.book.Name);
        //    }
    }
}
            

