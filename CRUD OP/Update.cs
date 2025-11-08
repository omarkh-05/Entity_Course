using Entity_Course.AppDBContext1;
using Entity_Course.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Course.CRUD_OP
{
    internal class Update
    {
        //      Method 1
        //using var db = new AppDBContext();

        //var departments = db.Departments.Find(1); or db.Departments.Find(d => d.id == 1)

        //if (departments != null)
        //{
        //    departments.Name = "Ali";

        //    db.SaveChanges();
        //}



        //      Method 2
        //var db = new AppDBContext();

        //var student = new Student()
        //{
        //    StudentID = 5, // Like Find Proparety
        //    Name = "Ali",
        //    Description = "Good Student",
        //    BirthDate = DateTime.Now,
        //    DepartmentID = 1,
        //    MobileNumber = "07928484321"
        //};

        //db.Update(student);
        //    db.SaveChanges();



        //      Method 3
        //var db = new AppDBContext();

        //var student = new Student()
        //{
        //    StudentID = 5, // Like Find Proparety
        //    Name = "Ali",
        //    Description = "Good Student",
        //    BirthDate = DateTime.Now,
        //    DepartmentID = 1,
        //    MobileNumber = "07928484321"
        //};

        //db.Entry(db.Students.Find(5)).CurrentValues.SetValues(student);
        //db.Entry(db.Students.Find(5)).Property(p => p.Name).IsModified = false; // هاي يعني الكولومز الي ما عدلت عليهم بدي يضلو عقيمتهم ما يصيرو نل
        //db.SaveChanges();



        //       Method 4       هاي اذا بدي اعدل اكثر من روو مع بعض وبتستخد برضو للاضافة
        //var db = new AppDBContext();
        // var department = new List<Department>() {
        // new Department()
        // {
        //  DepartmentId = 1,Name = "IT new",
        // student = new List<Student>(){
        // { new Student() { StudentID = 1, Name="Om........}
        // { new Student() { StudentID = 2, Name="Al........}
        //},
        //};

        //db.Department.UpdateRange(department);
        //db.SaveChanges();

    }
}
