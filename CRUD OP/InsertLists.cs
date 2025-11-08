using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.CRUD_OP
{
    internal class InsertLists
    {
        //      Method 1
        //      ADD
        //using var db = new AppDBContext();

        //var departments = new Department
        //{
        //    Name = "Omar 3"
        //};
        //// الخطوة الي تحت هاي عشان يجيبلي الرسائل تبعون الانوتيشن في الشاشة وما يسوي كراش 

        //var context = new ValidationContext(departments);
        //var errors = new List<ValidationResult>();

        //if (!Validator.TryValidateObject(departments, context, errors, true))
        //{
        //    foreach (var validresult in errors)
        //    {
        //        Console.WriteLine(validresult);
        //    }
        //}else
        //{
        //    db.Departments.Add(departments);

        //    db.SaveChanges();
        //}



        //      Method 2
        //var db = new AppDBContext();

        //var grade = new List<Grade>() {
        //    new Grade()
        //{
        //    MajorName = "Advanced Software Engineering",
        //    AVG = 92,
        //    student = new Student()
        //    {
        //        Name = "Omar", Description="Perfect Student" , BirthDate = DateTime.Now , DepartmentID = 1 , MobileNumber = "07928848292"
        //    }
        //},
        //new Grade()
        //{
        //    MajorName = "Subject In Software Engineering",
        //    AVG = 93,
        //    student = new Student()
        //    {
        //        Name = "Omar", Description="Perfect Student" , BirthDate = DateTime.Now , DepartmentID = 1 , MobileNumber = "07928484892"
        //    }
        //}

        //};

        //db.AddRange(grade);
        //db.SaveChanges();
        //Console.WriteLine("Grade And Student Added Successfully");
    }
}
